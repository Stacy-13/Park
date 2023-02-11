using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park
{
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO");
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно добавлено",
                "Добавлен товар",
                MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Что-то не так",
                "Что-то не так",
                MessageBoxButtons.OKCancel);
            }
        }
    }
}
