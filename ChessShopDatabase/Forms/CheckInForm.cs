using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class CheckInForm : Form
    {
        
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void checkInButton_Click(object sender, System.EventArgs e)
        {
            if (!Enumerable.Range(8, 20).Contains(userPasswordTextBox.Text.Length))
            {
                var errorMessage = "Длина пароля должна составлять от 8 до 20 символов.";
                MessageBox.Show(this, errorMessage, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("dbo.sp_check_in_user", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@new_user_login", userLoginTextBox.Text);
                    command.Parameters.AddWithValue("@new_user_password_md5_hash", MD5Hash.Compute(userLoginTextBox.Text + userPasswordTextBox.Text));
                    command.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Пользователь успешно зарегистрирован.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void anyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkInButton_Click(sender, e);
            }
        }

    }

}