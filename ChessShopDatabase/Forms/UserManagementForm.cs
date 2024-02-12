using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChessShopDatabase.Database.Users;
using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class UserManagementForm : Form
    {

        #region Fields

        private List<UserModel> _selectedUsers;

        #endregion

        #region Constructors

        public UserManagementForm()
        {
            InitializeComponent();
            SelectedUsers = new List<UserModel>();
        }

        #endregion

        #region Properties

        private List<UserModel> SelectedUsers
        {
            get => _selectedUsers;

            set => _selectedUsers = value ?? throw new ArgumentNullException("SelectedUsers");
        }

        #endregion

        #region Event handlers

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            ReloadUsers();
        }

        private void commitChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Применить внесённые изменения?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }
            SaveChanges();
        }

        private void rollbackChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Отбросить внесённые изменения?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }
            ReloadUsers();
        }

        #endregion

        #region SQL

        private void ReloadUsers()
        {
            SelectUsers();
            Task.Factory.StartNew(() =>
            {
                lock (userManagementDataGridView)
                {
                    userManagementDataGridView.Invoke((MethodInvoker)(() =>
                    {
                        userManagementDataGridView.Rows.Clear();
                        for (var i = 0; i < SelectedUsers.Count; i++)
                        {
                            userManagementDataGridView.Rows.Add(new DataGridViewRow());
                            userManagementDataGridView.Columns[0].ReadOnly = false; // без этого чёто не оч
                            (userManagementDataGridView.Rows[i].Cells["UserType"] as DataGridViewComboBoxCell).Value = UserType.Items[SelectedUsers[i].UserTypeId - 2];
                            userManagementDataGridView.Rows[i].Cells["UserLogin"].Value = SelectedUsers[i].UserLogin;
                        }
                    }));
                }
            });
            userManagementDataGridView.Invalidate();
        }

        async private void SelectUsers()
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("dbo.sp_load_users", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                try
                {
                    using (var sqlDataReader = command.ExecuteReader())
                    {
                        await Task.Factory.StartNew(() =>
                        {
                            lock (sqlDataReader)
                            {
                                SelectedUsers.Clear();
                                while (sqlDataReader.Read())
                                {
                                    var user = new UserModel();
                                    user.Id = sqlDataReader.GetInt32(0);
                                    user.UserTypeId = sqlDataReader.GetInt32(1);
                                    user.CreateDate = sqlDataReader.GetDateTime(2);
                                    user.UserLogin = sqlDataReader.GetString(3);
                                    SelectedUsers.Add(user);
                                }
                                sqlDataReader.Close();
                            }
                        });
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        private void SaveChanges()
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                Parallel.For(0, userManagementDataGridView.Rows.Count, (i) =>
                {
                    var userDataGridViewRow = userManagementDataGridView.Rows[i];
                    var command = new SqlCommand("dbo.sp_update_user", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user_to_update_id", SelectedUsers[i].Id);
                    var userNewTypeIdParameter = command.Parameters.Add("@user_new_type_id", SqlDbType.Int);
                    switch ((string)(userDataGridViewRow.Cells[0] as DataGridViewComboBoxCell).Value)
                    {
                        case "Редактор":
                            userNewTypeIdParameter.Value = 2;
                            break;
                        case "Клиент":
                            userNewTypeIdParameter.Value = 3;
                            break;
                    }
                    command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                    command.ExecuteScalar();
                });
            }
            ReloadUsers();
        }

        #endregion

    }

}