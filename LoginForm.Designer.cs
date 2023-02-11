namespace Park
{
    partial class LoginForm
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
            this.continueButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.capchaPictureBox = new System.Windows.Forms.PictureBox();
            this.capchaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.capchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(97, 192);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(151, 23);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Продолжить без входа";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(142, 150);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 93);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(188, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(97, 46);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(188, 20);
            this.loginTextBox.TabIndex = 6;
            // 
            // capchaPictureBox
            // 
            this.capchaPictureBox.Location = new System.Drawing.Point(84, 220);
            this.capchaPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.capchaPictureBox.Name = "capchaPictureBox";
            this.capchaPictureBox.Size = new System.Drawing.Size(133, 131);
            this.capchaPictureBox.TabIndex = 13;
            this.capchaPictureBox.TabStop = false;
            this.capchaPictureBox.Visible = false;
            // 
            // capchaTextBox
            // 
            this.capchaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capchaTextBox.Location = new System.Drawing.Point(84, 368);
            this.capchaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.capchaTextBox.Multiline = true;
            this.capchaTextBox.Name = "capchaTextBox";
            this.capchaTextBox.Size = new System.Drawing.Size(135, 27);
            this.capchaTextBox.TabIndex = 15;
            this.capchaTextBox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 435);
            this.Controls.Add(this.capchaTextBox);
            this.Controls.Add(this.capchaPictureBox);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "LoginForm";
            this.Text = "Войти";
            ((System.ComponentModel.ISupportInitialize)(this.capchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.PictureBox capchaPictureBox;
        public System.Windows.Forms.TextBox capchaTextBox;
    }
}

