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

namespace BugetBee_Expenses_Tracker
{
    public partial class SignUp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\risha\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUp()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? false : true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
