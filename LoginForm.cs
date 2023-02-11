using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Park
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlC = new SqlConnection(@"Data Source=DESKTOP-RLMBPA9;Initial Catalog=Park;Integrated Security=True;");
        public static int Role;
        public string capchaValue = "";
        public int failure = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
            Context.secutityLevel = 0;
        }

        private void CapchaLoad()
        {
            capchaValue = "";
            var rnd = new Random();
            Bitmap image = new Bitmap(capchaPictureBox.Width, capchaPictureBox.Height);
            var font = new Font("ComicSans", 40, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            capchaPictureBox.Image = image;
            for (int i = 0; i < 6; i++)
            {
                int value = rnd.Next(0, 9);
                capchaValue += value.ToString();
                graphics.DrawString(value.ToString(), font, Brushes.Blue, new Point(4 + i * 40, value * 2 + capchaPictureBox.Height / 5));
                capchaPictureBox.Refresh();
            }

            var colors = new Color[]
            {
                Color.Black,
                Color.Red,
                Color.Green
            };


            for (int n = 0; n < capchaPictureBox.Width; n++)
            {
                for (int j = 0; j < capchaPictureBox.Height; j++)
                {
                    if (rnd.Next() % 8 == 0)
                        image.SetPixel(n, j, colors[j % 3]);
                }
            }
            capchaPictureBox.Refresh();
            capchaTextBox.Visible = true;
            capchaPictureBox.Visible = true;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            sqlC.Open();
            var loginUser = loginTextBox.Text;
            var passwordUser = passwordTextBox.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select Login, Password, Access_Type from Users where Login = '{loginUser}' and Password = '{passwordUser}'";
            SqlCommand command = new SqlCommand(querystring, sqlC);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Role = dataReader.GetInt32(2);
            }
            sqlC.Close();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(table);

            if (table.Rows.Count == 1 && capchaValue == capchaTextBox.Text)
            {
                switch (Role)
                {
                    case 1:
                        Context.secutityLevel = 1;
                        break;
                    case 2:
                        Context.secutityLevel = 1;
                        break;
                    case 3:
                        Context.secutityLevel = 3;
                        break;
                    default: Context.secutityLevel = 0;
                        break;
                }
                MainWindow MF = new MainWindow();
                this.Hide();
                MF.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                failure++;
            }
            if (failure > 2)
            {
                CapchaLoad();
                capchaPictureBox.ResetText();
            }
        }
    }
}
