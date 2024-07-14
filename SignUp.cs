using CurvedTextBoxApp;
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
            return (connect.State == ConnectionState.Closed) ? true : false;

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

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username=@usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", textBox5.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count != 0)
                            {

                                string tempUser = textBox5.Text.Substring(0, 1).ToUpper() + textBox5.Text.Substring(1);
                                MessageBox.Show(tempUser + "is already there", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username,password,date_created) VALUES(@usern,@pass,@date)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {

                                    insertUser.Parameters.AddWithValue("@usern", textBox5.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", textBox4.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);
                                    insertUser.ExecuteNonQuery();
                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Login loginForm = new Login();
                                    loginForm.Show();
                                    this.Hide();

                                }

                            }
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username=@usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", textBox5.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count != 0)
                            {

                                string tempUser = textBox5.Text.Substring(0, 1).ToUpper() + textBox5.Text.Substring(1);
                                MessageBox.Show(tempUser + "is already there", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username,password,date_created) VALUES(@usern,@pass,@date)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {

                                    insertUser.Parameters.AddWithValue("@usern", textBox5.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", textBox4.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);
                                    insertUser.ExecuteNonQuery();
                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Login loginForm = new Login();
                                    loginForm.Show();
                                    this.Hide();

                                }

                            }
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }
    }
}
