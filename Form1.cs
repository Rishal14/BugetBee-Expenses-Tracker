using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugetBee_Expenses_Tracker
{
    public partial class Login : Form
    {
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
