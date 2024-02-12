using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using ChessShopDatabase.Database.Goods;
using ChessShopDatabase.Forms;
using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Controls
{

    public partial class GoodViewTemplate : UserControl
    {

        #region Fields

        private UserTypes _userType;
        private GoodModel _good;
        private CatalogForm _catalogForm;

        #endregion

        #region Constructors

        public GoodViewTemplate(CatalogForm catalogForm, UserTypes userType, GoodModel good)
        {
            InitializeComponent();
            CatalogForm = catalogForm;
            UserType = userType;
            Good = good;
        }

        #endregion

        #region Properties

        private UserTypes UserType
        {
            get => _userType;

            set => _userType = value;
        }

        private GoodModel Good
        {
            get => _good;

            set => _good = value ?? throw new ArgumentNullException("Good");
        }

        private CatalogForm CatalogForm
        {
            get => _catalogForm;

            set => _catalogForm = value ?? throw new ArgumentNullException("CatalogForm");
        }

        #endregion

        #region Event handlers

        private void GoodViewTemplate_Load(object sender, EventArgs e)
        {
            goodNameLabel.Text += Good.Name;
            goodTypeLabel.Text += Good.GoodTypeName;
            goodImage.Image = new Bitmap(Image.FromStream(new MemoryStream(Good.ImageBytes)), new Size(50, 50));
        }

        private void editGoodButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Ну не доделал :(", "Вот же печаль(", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteGoodButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить товар?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }
            try
            {
                DeleteGood();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CatalogForm.ReloadGoods();
        }

        #endregion

        #region SQL

        private async void DeleteGood()
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand("[dbo].[sp_delete_good]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@good_id", Good.Id);
                    command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                    await command.ExecuteScalarAsync();
                    // TODO: editor -> manager
                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }

}