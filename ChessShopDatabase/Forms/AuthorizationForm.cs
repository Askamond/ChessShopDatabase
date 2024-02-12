using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class AuthorizationForm : Form
    {

        #region Constructors

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        #endregion

        private void connectButton_Click(object sender, EventArgs e)
        {
            var userId = default(int);
            SqlCommand command;
            try
            {
                using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
                {
                    connection.Open();
                    command = new SqlCommand("dbo.sp_authorize_user", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user_login", userLoginTextBox.Text);
                    command.Parameters.AddWithValue("@user_password_md5_hash", MD5Hash.Compute(userLoginTextBox.Text + userPasswordTextBox.Text));
                    var userIdParameter = command.Parameters.Add("@user_id", SqlDbType.Int);
                    userIdParameter.Direction = ParameterDirection.Output;
                    var userTypeIdParameter = command.Parameters.Add("@user_type_id", SqlDbType.Int);
                    userTypeIdParameter.Direction = ParameterDirection.Output;
                    command.ExecuteScalar();
                    userId = (int)command.Parameters[2].Value;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Авторизация прошла успешно.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            userLoginTextBox.Text = "";
            userPasswordTextBox.Text = "";
            userLoginTextBox.Select();
            UserInfo.Instance.Id = userId;
            var mainForm = new MainForm((UserTypes)command.Parameters[3].Value);
            mainForm.ShowDialog(this);
            Show();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            var checkInForm = new CheckInForm();
            Hide();
            userLoginTextBox.Text = "";
            userPasswordTextBox.Text = "";
            userLoginTextBox.Select();
            checkInForm.ShowDialog(this);
            Show();
        }

        private void anyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectButton_Click(sender, e);
            }
        }

    }

}