using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChessShopDatabase.Database.Logs;
using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class LogsForm : Form
    {

        #region Fields

        private List<LogModel> _selectedLogs;
        private CancellationTokenSource _taskKiller;

        #endregion

        #region Constructors

        public LogsForm()
        {
            InitializeComponent();
            SelectedLogs = new List<LogModel>();
            TaskKiller = new CancellationTokenSource();
        }

        #endregion

        #region Properties

        private List<LogModel> SelectedLogs
        {
            get => _selectedLogs;

            set => _selectedLogs = value ?? throw new ArgumentNullException("SelectedLogs");
        }

        private CancellationTokenSource TaskKiller
        {
            get => _taskKiller;

            set => _taskKiller = value ?? throw new ArgumentNullException("TaskKiller");
        }

        #endregion

        #region Event handlers

        private void LogsForm_Load(object sender, EventArgs e)
        {
            dateFromFilterDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateToFilterDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

        private void anyFilter_ValueChanged(object sender, EventArgs e)
        {
            if (TaskKiller.IsCancellationRequested)
            {
                TaskKiller.Cancel(false);
                TaskKiller.Dispose();
                TaskKiller = new CancellationTokenSource();
            }
            ReloadLogs();
        }

        #endregion

        #region SQL

        private void ReloadLogs()
        {
            SelectLogs();
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(700);
                lock (logsDataGridView)
                {
                    logsDataGridView.Invoke((MethodInvoker)(() =>
                    {
                        logsDataGridView.Rows.Clear();
                        for (var i = 0; i < SelectedLogs.Count; i++)
                        {
                            logsDataGridView.Rows.Add(new DataGridViewRow());
                            logsDataGridView.Rows[i].Cells["UserLogin"].Value = SelectedLogs[i].UserLogin;
                            logsDataGridView.Rows[i].Cells["Content"].Value = SelectedLogs[i].Content;
                            logsDataGridView.Rows[i].Cells["CreateDate"].Value = SelectedLogs[i].CreateDate;
                        }
                    }));
                }
            });
        }

        async private void SelectLogs()
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("dbo.sp_load_logs", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_login_filter", userLoginFilterTextBox.Text);
                command.Parameters.AddWithValue("@date_from", dateFromFilterDateTimePicker.Value);
                command.Parameters.AddWithValue("@date_to", dateToFilterDateTimePicker.Value);
                command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                try
                {
                    using (var sqlDataReader = command.ExecuteReader())
                    {
                        TaskKiller.Token.Register(() =>
                        {
                            sqlDataReader.Close();
                        });
                        await Task.Factory.StartNew(() =>
                        {
                            lock (sqlDataReader)
                            {
                                SelectedLogs.Clear();
                                while (sqlDataReader.Read())
                                {
                                    var log = new LogModel();
                                    log.Id = sqlDataReader.GetInt32(0);
                                    log.UserLogin = sqlDataReader.GetString(1);
                                    log.Content = sqlDataReader.GetString(2);
                                    log.CreateDate = sqlDataReader.GetDateTime(3);
                                    SelectedLogs.Add(log);
                                }
                                sqlDataReader.Close();
                            }
                        }, TaskKiller.Token);
                    }
                }
                catch (SqlException ex)
                {
                    dateToFilterDateTimePicker.ValueChanged -= new EventHandler(anyFilter_ValueChanged);
                    MessageBox.Show(this, ex.Message, "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        #endregion

    }

}