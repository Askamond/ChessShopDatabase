using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using ChessShopDatabase.Helpers;

namespace ChessShopDatabase.Forms
{

    public partial class AddNewGoodForm : Form
    {

        #region Constructors

        public AddNewGoodForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        private void AddNewGoodForm_Load(object sender, EventArgs e)
        {
            goodImage.Image = Properties.Resources.NoImage;
        }

        private void loadGoodImageButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            goodImage.Image = new Bitmap(Image.FromFile(ofd.FileName), new Size(100, 100));
        }

        private void deleteGoodImageButton_Click(object sender, EventArgs e)
        {
            goodImage.Image = Properties.Resources.NoImage;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Вы уверены?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }
            Close();
        }

        private void addGoodButton_Click(object sender, EventArgs e)
        {
            string message = null;
            if (goodNameTextBox.Text.Length == 0)
            {
                message = (message ?? "") + string.Format("Укажите наименование товара!{0}", Environment.NewLine);
            }
            if (goodTypeComboBox.Text == string.Empty)
            {
                message = (message ?? "") + string.Format("Укажите тип товара!{0}", Environment.NewLine);
            }
            if (!decimal.TryParse(goodValueTextBox.Text.Replace('.', ','), out decimal goodValue))
            {
                message = (message ?? "") + string.Format("Введено некорректное значение стоимости товара!{0}", Environment.NewLine);
            }
            if (!int.TryParse(goodLeftInStockTextBox.Text, out int goodLeftInStock))
            {
                message = (message ?? "") + string.Format("Введено некорректное значение кол-ва товара на складе!{0}", Environment.NewLine);
            }
            if (message != null)
            {
                MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddGood(goodNameTextBox.Text, goodTypeComboBox.SelectedIndex + 1, goodDescriptionTextBox.Text, goodLeftInStock, goodValue);
        }

        private void goodValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tb.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && tb.Text.Length - tb.SelectionStart > 2)
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && tb.Text.Contains(".") && tb.SelectionStart > tb.Text.IndexOf('.')
                && tb.Text.Length - tb.Text.IndexOf('.') > 2)
            {
                e.Handled = true;
            }
        }

        private void goodLeftInStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            var tb = sender as TextBox;
            var textBoxText = tb.Text.Insert(tb.SelectionStart, e.KeyChar.ToString());
            if (Regex.IsMatch(textBoxText, "[^0-9]"))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region SQL

        private void AddGood(string name, int goodTypeId, string description, int leftInStock, decimal value)
        {
            using (var connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("dbo.sp_add_good", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@good_type_id", goodTypeId);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@left_in_stock", leftInStock);
                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@image", SerializeImage() ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@user_id", UserInfo.Instance.Id);
                    command.ExecuteScalar();
                }
            }
            MessageBox.Show(this, "Товар успешно добавлен в каталог.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

            byte[] SerializeImage()
            {
                if (goodImage.Image.Equals(Properties.Resources.NoImage)) // хнык
                {
                    return null;
                }
                using (var stream = new MemoryStream())
                {
                    goodImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return stream.ToArray();
                }
            }
        }

        #endregion

    }

}