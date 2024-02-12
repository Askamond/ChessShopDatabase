using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

using ChessShopDatabase.Controls;
using ChessShopDatabase.Database.Goods;
using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class CatalogForm : Form
    {

        #region Fields

        private UserTypes _userType;
        private List<GoodModel> _selectedGoods;

        #endregion

        #region Constructors

        public CatalogForm(UserTypes userType)
        {
            InitializeComponent();
            UserType = userType;
            SelectedGoods = new List<GoodModel>();
        }

        #endregion

        #region Properties

        private UserTypes UserType
        {
            get => _userType;

            set => _userType = value;
        }

        private List<GoodModel> SelectedGoods
        {
            get => _selectedGoods;

            set => _selectedGoods = value ?? throw new ArgumentNullException();
        }

        #endregion

        #region Event handlers

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            ReloadGoods();
        }

        private void addNewGoodButton_Click(object sender, EventArgs e)
        {
            var addNewGoodForm = new AddNewGoodForm();
            Hide();
            addNewGoodForm.ShowDialog(this);
            ReloadGoods();
            Show();
        }

        #endregion

        #region SQL

        private void SelectGoods()
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("dbo.sp_load_goods", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                using (var sqlDataReader = command.ExecuteReader())
                {
                    SelectedGoods.Clear();
                    while (sqlDataReader.Read())
                    {
                        var good = new GoodModel();
                        good.Id = sqlDataReader.GetInt32(0);
                        good.GoodTypeId = sqlDataReader.GetInt32(1);
                        good.Name = sqlDataReader.GetString(2);
                        good.Description = sqlDataReader.GetString(3);
                        good.Value = sqlDataReader.GetDecimal(4);
                        good.LeftInStock = sqlDataReader.GetInt32(5);
                        byte[] bytes = new byte[128];
                        int index = 0;
                        var len = sqlDataReader.GetBytes(6, index, bytes, 0, 128);
                        var ms = new MemoryStream();
                        while (len == 128)
                        {
                            ms.Write(bytes, 0, 128);
                            index += 128;
                            len = sqlDataReader.GetBytes(6, index, bytes, 0, 128);
                        }
                        good.ImageBytes = ms.GetBuffer();
                        good.UserId = sqlDataReader.GetInt32(7);
                        good.GoodTypeName = sqlDataReader.GetString(8);
                        SelectedGoods.Add(good);
                    }
                    sqlDataReader.Close();
                }
            }
        }

        public void ReloadGoods()
        {
            SelectGoods();
            catalogPanel.Controls.Clear();
            for (int i = 0; i < SelectedGoods.Count; i++)
            {
                var goodView = new GoodViewTemplate(this, UserType, SelectedGoods[i]);
                goodView.Left = 3;
                goodView.Top = (i + 1) * 10 + i * goodView.Height;
                catalogPanel.Controls.Add(goodView);
            }
        }

        #endregion

    }

}