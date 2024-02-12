namespace ChessShopDatabase.Forms
{
    partial class AddNewGoodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewGoodForm));
            this.goodNameLabel = new System.Windows.Forms.Label();
            this.goodTypeLabel = new System.Windows.Forms.Label();
            this.goodDescriptionLabel = new System.Windows.Forms.Label();
            this.goodValueLabel = new System.Windows.Forms.Label();
            this.goodLeftInStockLabel = new System.Windows.Forms.Label();
            this.goodImageLabel = new System.Windows.Forms.Label();
            this.goodNameTextBox = new System.Windows.Forms.TextBox();
            this.goodDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.goodValueTextBox = new System.Windows.Forms.TextBox();
            this.goodLeftInStockTextBox = new System.Windows.Forms.TextBox();
            this.goodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.goodImage = new System.Windows.Forms.PictureBox();
            this.addGoodButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loadGoodImageButton = new System.Windows.Forms.Button();
            this.deleteGoodImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // goodNameLabel
            // 
            this.goodNameLabel.AutoSize = true;
            this.goodNameLabel.Location = new System.Drawing.Point(12, 15);
            this.goodNameLabel.Name = "goodNameLabel";
            this.goodNameLabel.Size = new System.Drawing.Size(83, 13);
            this.goodNameLabel.TabIndex = 0;
            this.goodNameLabel.Text = "Наименование";
            // 
            // goodTypeLabel
            // 
            this.goodTypeLabel.AutoSize = true;
            this.goodTypeLabel.Location = new System.Drawing.Point(12, 41);
            this.goodTypeLabel.Name = "goodTypeLabel";
            this.goodTypeLabel.Size = new System.Drawing.Size(26, 13);
            this.goodTypeLabel.TabIndex = 1;
            this.goodTypeLabel.Text = "Тип";
            // 
            // goodDescriptionLabel
            // 
            this.goodDescriptionLabel.AutoSize = true;
            this.goodDescriptionLabel.Location = new System.Drawing.Point(12, 121);
            this.goodDescriptionLabel.Name = "goodDescriptionLabel";
            this.goodDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.goodDescriptionLabel.TabIndex = 2;
            this.goodDescriptionLabel.Text = "Описание";
            // 
            // goodValueLabel
            // 
            this.goodValueLabel.AutoSize = true;
            this.goodValueLabel.Location = new System.Drawing.Point(12, 65);
            this.goodValueLabel.Name = "goodValueLabel";
            this.goodValueLabel.Size = new System.Drawing.Size(88, 13);
            this.goodValueLabel.TabIndex = 3;
            this.goodValueLabel.Text = "Стоимость, руб.";
            // 
            // goodLeftInStockLabel
            // 
            this.goodLeftInStockLabel.AutoSize = true;
            this.goodLeftInStockLabel.Location = new System.Drawing.Point(12, 94);
            this.goodLeftInStockLabel.Name = "goodLeftInStockLabel";
            this.goodLeftInStockLabel.Size = new System.Drawing.Size(80, 13);
            this.goodLeftInStockLabel.TabIndex = 4;
            this.goodLeftInStockLabel.Text = "В наличии, шт.";
            // 
            // goodImageLabel
            // 
            this.goodImageLabel.AutoSize = true;
            this.goodImageLabel.Location = new System.Drawing.Point(261, 15);
            this.goodImageLabel.Name = "goodImageLabel";
            this.goodImageLabel.Size = new System.Drawing.Size(77, 13);
            this.goodImageLabel.TabIndex = 5;
            this.goodImageLabel.Text = "Изображение";
            // 
            // goodNameTextBox
            // 
            this.goodNameTextBox.Location = new System.Drawing.Point(106, 12);
            this.goodNameTextBox.Name = "goodNameTextBox";
            this.goodNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.goodNameTextBox.TabIndex = 6;
            // 
            // goodDescriptionTextBox
            // 
            this.goodDescriptionTextBox.AcceptsReturn = true;
            this.goodDescriptionTextBox.Location = new System.Drawing.Point(15, 137);
            this.goodDescriptionTextBox.Multiline = true;
            this.goodDescriptionTextBox.Name = "goodDescriptionTextBox";
            this.goodDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.goodDescriptionTextBox.Size = new System.Drawing.Size(349, 132);
            this.goodDescriptionTextBox.TabIndex = 7;
            // 
            // goodValueTextBox
            // 
            this.goodValueTextBox.Location = new System.Drawing.Point(106, 65);
            this.goodValueTextBox.Name = "goodValueTextBox";
            this.goodValueTextBox.Size = new System.Drawing.Size(152, 20);
            this.goodValueTextBox.TabIndex = 8;
            this.goodValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodValueTextBox_KeyPress);
            // 
            // goodLeftInStockTextBox
            // 
            this.goodLeftInStockTextBox.Location = new System.Drawing.Point(106, 91);
            this.goodLeftInStockTextBox.Name = "goodLeftInStockTextBox";
            this.goodLeftInStockTextBox.Size = new System.Drawing.Size(152, 20);
            this.goodLeftInStockTextBox.TabIndex = 9;
            this.goodLeftInStockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goodLeftInStockTextBox_KeyPress);
            // 
            // goodTypeComboBox
            // 
            this.goodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodTypeComboBox.FormattingEnabled = true;
            this.goodTypeComboBox.Items.AddRange(new object[] {
            "Доска",
            "Фигура",
            "Игровой комплект",
            "Часы",
            "Литература",
            "Программа"});
            this.goodTypeComboBox.Location = new System.Drawing.Point(106, 38);
            this.goodTypeComboBox.Name = "goodTypeComboBox";
            this.goodTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.goodTypeComboBox.TabIndex = 10;
            // 
            // goodImage
            // 
            this.goodImage.InitialImage = global::ChessShopDatabase.Properties.Resources.NoImage;
            this.goodImage.Location = new System.Drawing.Point(264, 31);
            this.goodImage.Name = "goodImage";
            this.goodImage.Size = new System.Drawing.Size(100, 100);
            this.goodImage.TabIndex = 11;
            this.goodImage.TabStop = false;
            // 
            // addGoodButton
            // 
            this.addGoodButton.Location = new System.Drawing.Point(370, 137);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(150, 63);
            this.addGoodButton.TabIndex = 12;
            this.addGoodButton.Text = "Добавить товар в каталог";
            this.addGoodButton.UseVisualStyleBackColor = true;
            this.addGoodButton.Click += new System.EventHandler(this.addGoodButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(370, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 63);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loadGoodImageButton
            // 
            this.loadGoodImageButton.Location = new System.Drawing.Point(370, 31);
            this.loadGoodImageButton.Name = "loadGoodImageButton";
            this.loadGoodImageButton.Size = new System.Drawing.Size(150, 47);
            this.loadGoodImageButton.TabIndex = 14;
            this.loadGoodImageButton.Text = "Загрузить изображение (Рекомендуемый размер 100x100)";
            this.loadGoodImageButton.UseVisualStyleBackColor = true;
            this.loadGoodImageButton.Click += new System.EventHandler(this.loadGoodImageButton_Click);
            // 
            // deleteGoodImageButton
            // 
            this.deleteGoodImageButton.Location = new System.Drawing.Point(370, 84);
            this.deleteGoodImageButton.Name = "deleteGoodImageButton";
            this.deleteGoodImageButton.Size = new System.Drawing.Size(150, 47);
            this.deleteGoodImageButton.TabIndex = 15;
            this.deleteGoodImageButton.Text = "Удалить изображение";
            this.deleteGoodImageButton.UseVisualStyleBackColor = true;
            this.deleteGoodImageButton.Click += new System.EventHandler(this.deleteGoodImageButton_Click);
            // 
            // AddNewGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 281);
            this.Controls.Add(this.deleteGoodImageButton);
            this.Controls.Add(this.loadGoodImageButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addGoodButton);
            this.Controls.Add(this.goodImage);
            this.Controls.Add(this.goodTypeComboBox);
            this.Controls.Add(this.goodLeftInStockTextBox);
            this.Controls.Add(this.goodValueTextBox);
            this.Controls.Add(this.goodDescriptionTextBox);
            this.Controls.Add(this.goodNameTextBox);
            this.Controls.Add(this.goodImageLabel);
            this.Controls.Add(this.goodLeftInStockLabel);
            this.Controls.Add(this.goodValueLabel);
            this.Controls.Add(this.goodDescriptionLabel);
            this.Controls.Add(this.goodTypeLabel);
            this.Controls.Add(this.goodNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewGoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление товара в каталог";
            this.Load += new System.EventHandler(this.AddNewGoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodNameLabel;
        private System.Windows.Forms.Label goodTypeLabel;
        private System.Windows.Forms.Label goodDescriptionLabel;
        private System.Windows.Forms.Label goodValueLabel;
        private System.Windows.Forms.Label goodLeftInStockLabel;
        private System.Windows.Forms.Label goodImageLabel;
        private System.Windows.Forms.TextBox goodNameTextBox;
        private System.Windows.Forms.TextBox goodDescriptionTextBox;
        private System.Windows.Forms.TextBox goodValueTextBox;
        private System.Windows.Forms.TextBox goodLeftInStockTextBox;
        private System.Windows.Forms.ComboBox goodTypeComboBox;
        private System.Windows.Forms.PictureBox goodImage;
        private System.Windows.Forms.Button addGoodButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loadGoodImageButton;
        private System.Windows.Forms.Button deleteGoodImageButton;
    }
}