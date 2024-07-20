using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BugetBee_Expenses_Tracker
{
    

    public partial class Login : Form

    {
        string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\risha\\OneDrive\\Documents\\expense.mdf;Integrated Security=True;Connect Timeout=30";
        

        public Login()
        {
            InitializeComponent();
            InitializeCustomControls();
        }
        private void InitializeCustomControls()
        {
            {
                RoundedButton roundedButton = new RoundedButton();
                roundedButton.Text = "Rounded Button";
                roundedButton.Size = new Size(150, 50);
                roundedButton.Location = new Point(100, 50);
                roundedButton.BackColor = Color.LightBlue;

                this.Controls.Add(roundedButton);
            }

            // Add the button to the form
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

       

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void roundedButton2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users where username =@usern and password=@pass";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBox1.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    
                    if(table.Rows.Count>0)
                    {
                        MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}
