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
    public partial class MainWindow : Form
    {
        SqlConnection sqlC = new SqlConnection(@"Data Source=DESKTOP-RLMBPA9;Initial Catalog=Park;Integrated Security=True;");

        private void Access_Level()
        {
            switch (Context.secutityLevel)
            {
                case 1:
                    postLabel.Text = "Администратор";
                    createReportButton.Visible = true;
                    enterHistoryButton.Visible = true;
                    break;
                case 2:
                    postLabel.Text = "Старший смены";
                    addOrderButton.Visible = true;
                    break;
                case 3:
                    postLabel.Text = "Продавец";
                    addOrderButton.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Access_Level();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {       
            sqlC.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable servicesList = new DataTable();
            DataTable ordersList = new DataTable();

            string querystring = $"select * from Services";
            SqlCommand command = new SqlCommand(querystring, sqlC);


            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(servicesList);
            dataGridView1.DataSource = servicesList;


            querystring = $"select * from Orders";
            command = new SqlCommand(querystring, sqlC);

            sqlC.Close();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(ordersList);

            dataGridView2.DataSource = ordersList;
            sqlC.Close();
        }

        private void enterHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddWindow AW = new AddWindow();
            this.Hide();
            AW.ShowDialog();
            this.Show();
        }
    }
}
