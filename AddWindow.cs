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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Park
{
    public partial class AddWindow : Form
    {

        SqlConnection sqlC = new SqlConnection(@"Data Source=DESKTOP-RLMBPA9;Initial Catalog=Park;Integrated Security=True;");
        public AddWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrder()
        {
            if (creationDateTextBox.Text != "" && timeCreationTextBox.Text != "" && clientCodeTextBox.Text != "" && timeTextBox.Text != "")
            {
                sqlC.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"INSERT INTO Orders(Order_Code, Creation_Date, Creation_Time, Client_Code, Status_Id, Time_Rent) VALUES " +
                    $"({clientCodeTextBox.Text + '/' + creationDateTextBox.Text}, {creationDateTextBox.Text}, {timeCreationTextBox.Text}, {clientCodeTextBox.Text}, {'1'}, {timeTextBox.Text})";
                SqlCommand command = new SqlCommand(querystring, sqlC);
                sqlC.Close();
                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(table);

                sqlC.Close();

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

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddOrder();            
        }
    }
}
