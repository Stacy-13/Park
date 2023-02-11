namespace Park
{
    partial class AddWindow
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
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.ImageLabel6 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.servicesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.arrayTimetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.DisplayMember = "CName";
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Location = new System.Drawing.Point(141, 12);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(248, 21);
            this.CategoryComboBox1.TabIndex = 65;
            // 
            // ImageLabel6
            // 
            this.ImageLabel6.AutoSize = true;
            this.ImageLabel6.Location = new System.Drawing.Point(112, 370);
            this.ImageLabel6.Name = "ImageLabel6";
            this.ImageLabel6.Size = new System.Drawing.Size(0, 13);
            this.ImageLabel6.TabIndex = 64;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(274, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 59;
            this.exitButton.Text = "Отмена";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(44, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 58;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Время проката:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Услуги:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Код клинта:";
            // 
            // servicesCheckedListBox
            // 
            this.servicesCheckedListBox.FormattingEnabled = true;
            this.servicesCheckedListBox.Location = new System.Drawing.Point(141, 51);
            this.servicesCheckedListBox.Name = "servicesCheckedListBox";
            this.servicesCheckedListBox.Size = new System.Drawing.Size(248, 124);
            this.servicesCheckedListBox.TabIndex = 67;
            // 
            // arrayTimetextBox
            // 
            this.arrayTimetextBox.Location = new System.Drawing.Point(141, 191);
            this.arrayTimetextBox.Name = "arrayTimetextBox";
            this.arrayTimetextBox.Size = new System.Drawing.Size(248, 20);
            this.arrayTimetextBox.TabIndex = 68;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 290);
            this.Controls.Add(this.arrayTimetextBox);
            this.Controls.Add(this.servicesCheckedListBox);
            this.Controls.Add(this.CategoryComboBox1);
            this.Controls.Add(this.ImageLabel6);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWindow";
            this.Text = "Добавить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.Label ImageLabel6;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox servicesCheckedListBox;
        private System.Windows.Forms.TextBox arrayTimetextBox;
    }
}