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
            this.label8 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeCreationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.parkDataSet1 = new Park.ParkDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Время проката";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(127, 262);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(140, 20);
            this.timeTextBox.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Код услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Код клиента";
            // 
            // clientCodeTextBox
            // 
            this.clientCodeTextBox.Location = new System.Drawing.Point(127, 57);
            this.clientCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientCodeTextBox.Name = "clientCodeTextBox";
            this.clientCodeTextBox.Size = new System.Drawing.Size(139, 20);
            this.clientCodeTextBox.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Время заказа";
            // 
            // timeCreationTextBox
            // 
            this.timeCreationTextBox.Location = new System.Drawing.Point(126, 34);
            this.timeCreationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeCreationTextBox.Name = "timeCreationTextBox";
            this.timeCreationTextBox.Size = new System.Drawing.Size(140, 20);
            this.timeCreationTextBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Дата Заказа";
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.Location = new System.Drawing.Point(126, 11);
            this.creationDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.Size = new System.Drawing.Size(140, 20);
            this.creationDateTextBox.TabIndex = 68;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(169, 299);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 30);
            this.closeButton.TabIndex = 67;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(34, 299);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(68, 30);
            this.saveButton.TabIndex = 66;
            this.saveButton.Text = "Добавить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(127, 91);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 154);
            this.checkedListBox1.TabIndex = 82;
            // 
            // parkDataSet1
            // 
            this.parkDataSet1.DataSetName = "ParkDataSet";
            this.parkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 340);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeCreationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creationDateTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Name = "AddWindow";
            this.Text = "Добавить заказ";
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeCreationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private ParkDataSet parkDataSet1;
    }
}