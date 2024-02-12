namespace ChessShopDatabase.Forms
{

    partial class UserManagementForm
    {
        
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.userManagementDataGridView = new System.Windows.Forms.DataGridView();
            this.commitChangesButton = new System.Windows.Forms.Button();
            this.rollbackChangesButton = new System.Windows.Forms.Button();
            this.UserType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UserLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userManagementDataGridView
            // 
            this.userManagementDataGridView.AllowUserToAddRows = false;
            this.userManagementDataGridView.AllowUserToDeleteRows = false;
            this.userManagementDataGridView.AllowUserToResizeColumns = false;
            this.userManagementDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.userManagementDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userManagementDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.userManagementDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userManagementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userManagementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserType,
            this.UserLogin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userManagementDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userManagementDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.userManagementDataGridView.GridColor = System.Drawing.Color.Black;
            this.userManagementDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userManagementDataGridView.MultiSelect = false;
            this.userManagementDataGridView.Name = "userManagementDataGridView";
            this.userManagementDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.userManagementDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.userManagementDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userManagementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userManagementDataGridView.Size = new System.Drawing.Size(306, 167);
            this.userManagementDataGridView.TabIndex = 1;
            // 
            // commitChangesButton
            // 
            this.commitChangesButton.Location = new System.Drawing.Point(12, 185);
            this.commitChangesButton.Name = "commitChangesButton";
            this.commitChangesButton.Size = new System.Drawing.Size(150, 25);
            this.commitChangesButton.TabIndex = 2;
            this.commitChangesButton.Text = "Применить изменения";
            this.commitChangesButton.UseVisualStyleBackColor = true;
            this.commitChangesButton.Click += new System.EventHandler(this.commitChangesButton_Click);
            // 
            // rollbackChangesButton
            // 
            this.rollbackChangesButton.Location = new System.Drawing.Point(168, 185);
            this.rollbackChangesButton.Name = "rollbackChangesButton";
            this.rollbackChangesButton.Size = new System.Drawing.Size(150, 25);
            this.rollbackChangesButton.TabIndex = 3;
            this.rollbackChangesButton.Text = "Отбросить изменения";
            this.rollbackChangesButton.UseVisualStyleBackColor = true;
            this.rollbackChangesButton.Click += new System.EventHandler(this.rollbackChangesButton_Click);
            // 
            // UserType
            // 
            this.UserType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.UserType.DisplayStyleForCurrentCellOnly = true;
            this.UserType.HeaderText = "Тип";
            this.UserType.Items.AddRange(new object[] {
            "Редактор",
            "Клиент"});
            this.UserType.MaxDropDownItems = 3;
            this.UserType.Name = "UserType";
            this.UserType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserType.Width = 125;
            // 
            // UserLogin
            // 
            this.UserLogin.HeaderText = "Логин";
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.ReadOnly = true;
            this.UserLogin.Width = 178;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 222);
            this.Controls.Add(this.rollbackChangesButton);
            this.Controls.Add(this.commitChangesButton);
            this.Controls.Add(this.userManagementDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пользователями";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userManagementDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userManagementDataGridView;
        private System.Windows.Forms.Button commitChangesButton;
        private System.Windows.Forms.Button rollbackChangesButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLogin;
    }

}