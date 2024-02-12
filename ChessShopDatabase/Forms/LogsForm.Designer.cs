namespace ChessShopDatabase.Forms
{
    partial class LogsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsForm));
            this.logsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginFilterTextBox = new System.Windows.Forms.TextBox();
            this.loginFilterLabel = new System.Windows.Forms.Label();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateToFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).BeginInit();
            this.filtersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logsDataGridView
            // 
            this.logsDataGridView.AllowUserToAddRows = false;
            this.logsDataGridView.AllowUserToDeleteRows = false;
            this.logsDataGridView.AllowUserToResizeColumns = false;
            this.logsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.logsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.logsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserLogin,
            this.Content,
            this.CreateDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.logsDataGridView.GridColor = System.Drawing.Color.Black;
            this.logsDataGridView.Location = new System.Drawing.Point(12, 72);
            this.logsDataGridView.MultiSelect = false;
            this.logsDataGridView.Name = "logsDataGridView";
            this.logsDataGridView.ReadOnly = true;
            this.logsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.logsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.logsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logsDataGridView.Size = new System.Drawing.Size(653, 409);
            this.logsDataGridView.TabIndex = 0;
            // 
            // UserLogin
            // 
            this.UserLogin.HeaderText = "Логин пользователя";
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.ReadOnly = true;
            this.UserLogin.Width = 140;
            // 
            // Content
            // 
            this.Content.HeaderText = "Описание";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 360;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "Дата создания";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 150;
            // 
            // userLoginFilterTextBox
            // 
            this.userLoginFilterTextBox.Location = new System.Drawing.Point(50, 19);
            this.userLoginFilterTextBox.Name = "userLoginFilterTextBox";
            this.userLoginFilterTextBox.Size = new System.Drawing.Size(142, 20);
            this.userLoginFilterTextBox.TabIndex = 1;
            this.userLoginFilterTextBox.TextChanged += new System.EventHandler(this.anyFilter_ValueChanged);
            // 
            // loginFilterLabel
            // 
            this.loginFilterLabel.AutoSize = true;
            this.loginFilterLabel.Location = new System.Drawing.Point(6, 22);
            this.loginFilterLabel.Name = "loginFilterLabel";
            this.loginFilterLabel.Size = new System.Drawing.Size(38, 13);
            this.loginFilterLabel.TabIndex = 2;
            this.loginFilterLabel.Text = "Логин";
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.label2);
            this.filtersGroupBox.Controls.Add(this.label1);
            this.filtersGroupBox.Controls.Add(this.dateToFilterDateTimePicker);
            this.filtersGroupBox.Controls.Add(this.dateFromFilterDateTimePicker);
            this.filtersGroupBox.Controls.Add(this.userLoginFilterTextBox);
            this.filtersGroupBox.Controls.Add(this.loginFilterLabel);
            this.filtersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(654, 54);
            this.filtersGroupBox.TabIndex = 3;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Фильтры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Действия с";
            // 
            // dateToFilterDateTimePicker
            // 
            this.dateToFilterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToFilterDateTimePicker.Location = new System.Drawing.Point(556, 19);
            this.dateToFilterDateTimePicker.Name = "dateToFilterDateTimePicker";
            this.dateToFilterDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.dateToFilterDateTimePicker.TabIndex = 4;
            this.dateToFilterDateTimePicker.ValueChanged += new System.EventHandler(this.anyFilter_ValueChanged);
            // 
            // dateFromFilterDateTimePicker
            // 
            this.dateFromFilterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromFilterDateTimePicker.Location = new System.Drawing.Point(433, 19);
            this.dateFromFilterDateTimePicker.Name = "dateFromFilterDateTimePicker";
            this.dateFromFilterDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.dateFromFilterDateTimePicker.TabIndex = 3;
            this.dateFromFilterDateTimePicker.ValueChanged += new System.EventHandler(this.anyFilter_ValueChanged);
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 493);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.logsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Лог-журнал действий пользователей";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).EndInit();
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView logsDataGridView;
        private System.Windows.Forms.TextBox userLoginFilterTextBox;
        private System.Windows.Forms.Label loginFilterLabel;
        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.DateTimePicker dateFromFilterDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateToFilterDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }

}