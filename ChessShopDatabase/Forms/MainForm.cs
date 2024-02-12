using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class MainForm : Form
    {

        #region Fields

        private UserTypes _userType;

        #endregion

        #region Constructors

        public MainForm(UserTypes userType)
        {
            InitializeComponent();
            UserType = userType;
        }

        #endregion

        #region Properties

        private UserTypes UserType
        {
            get => _userType;

            set => _userType = value;
        }

        #endregion

        #region Event handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (UserType)
            {
                case UserTypes.Admin:
                    Text = "Пульт управления администратора";
                    Height = 190;
                    adminPanel.Visible = true;
                    break;
                case UserTypes.Editor:
                    Text = "Пульт управления редактора";
                    Height = 159;
                    editorPanel.Visible = true;
                    break;
                case UserTypes.Client:
                    userPanel.Visible = true;
                    break;
            }
        }

        #region Admin panel

        private void userManagementAdminButton_Click(object sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm();
            Hide();
            userManagementForm.ShowDialog(this);
            Show();
        }

        private void showLogsAdminButton_Click(object sender, EventArgs e)
        {
            var logsForm = new LogsForm();
            Hide();
            logsForm.ShowDialog(this);
            Show();
        }

        private void createDatabaseBackupAdminButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\";
            sfd.Filter = "Database backup file (*.dbbak)|*.dbbak";
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            CreateDatabaseBackup(sfd.FileName);
        }

        private void loadDatabaseBackupAdminButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Database backup file (*.dbbak)|*.dbbak";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            LoadDatabaseBackup(ofd.FileName);
        }

        #endregion

        #region Editor panel

        private void showLogsEditorButton_Click(object sender, EventArgs e)
        {
            var logsForm = new LogsForm();
            Hide();
            logsForm.ShowDialog(this);
            Show();
        }

        private void showCatalogEditorButton_Click(object sender, EventArgs e)
        {
            var catalogForm = new CatalogForm(UserType);
            Hide();
            catalogForm.ShowDialog(this);
            Show();
        }

        private void showOrdersEditorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Not done yet :(", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
            // TODO: -_-
            var ordersForm = new OrdersForm();
            Hide();
            ordersForm.ShowDialog(this);
            Show();
        }

        #endregion

        #region User panel

        private void showCatalogUserButton_Click(object sender, EventArgs e)
        {
            var catalogForm = new CatalogForm(UserType);
            Hide();
            catalogForm.ShowDialog(this);
            Show();
        }

        private void showCartUserButton_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm();
            Hide();
            cartForm.ShowDialog(this);
            Show();
        }

        #endregion

        #endregion

        #region SQL

        private void CreateDatabaseBackup(string fileName)
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("dbo.sp_create_database_backup", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@file_name", fileName);
                    command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                    command.ExecuteScalar();
                }
            }
            MessageBox.Show(this, "Резервная копия базы данных создана.", "Операция успешно завершена"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDatabaseBackup(string fileName)
        {
            using (var sqlRestoreConnection = new SqlConnection(Properties.Resources.RestoreConnectionString))
            {
                sqlRestoreConnection.Open();
                using (var command = new SqlCommand("dbo.sp_restore_database", sqlRestoreConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@file_name", fileName);
                    command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                    command.ExecuteScalar();
                }
                MessageBox.Show(this, "База данных была восстановлена из резервной копии.", "Операция успешно завершена"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

    }

}