namespace Practika
{
    partial class AutorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogitLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.AutorizationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogitLabel
            // 
            this.LogitLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogitLabel.Location = new System.Drawing.Point(96, 91);
            this.LogitLabel.Name = "LogitLabel";
            this.LogitLabel.Size = new System.Drawing.Size(150, 26);
            this.LogitLabel.TabIndex = 0;
            this.LogitLabel.Text = "Логин";
            this.LogitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(99, 121);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(147, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(99, 188);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(147, 22);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordLabel.Location = new System.Drawing.Point(96, 158);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(150, 26);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Абонент",
            "Оператор"});
            this.RoleComboBox.Location = new System.Drawing.Point(99, 267);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(147, 24);
            this.RoleComboBox.TabIndex = 4;
            // 
            // RoleLabel
            // 
            this.RoleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RoleLabel.Location = new System.Drawing.Point(96, 238);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(150, 26);
            this.RoleLabel.TabIndex = 5;
            this.RoleLabel.Text = "Роль";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutorizationButton
            // 
            this.AutorizationButton.Location = new System.Drawing.Point(110, 297);
            this.AutorizationButton.Name = "AutorizationButton";
            this.AutorizationButton.Size = new System.Drawing.Size(122, 38);
            this.AutorizationButton.TabIndex = 6;
            this.AutorizationButton.Text = "Вход";
            this.AutorizationButton.UseVisualStyleBackColor = true;
            this.AutorizationButton.Click += new System.EventHandler(this.AutorizationButton_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 477);
            this.Controls.Add(this.AutorizationButton);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LogitLabel);
            this.Name = "AutorizationForm";
            this.Text = "Autorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogitLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button AutorizationButton;
    }
}

