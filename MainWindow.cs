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
        public MainWindow()
        {
            InitializeComponent();
            if (Context.secutityLevel == 0)
            {
                addButton.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.ShowDialog();
            this.Close();
        }



    }
}
