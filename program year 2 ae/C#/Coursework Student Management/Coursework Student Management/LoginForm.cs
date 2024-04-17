using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Coursework_Student_Management
{
    public partial class LoginForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\school management database.mdf"";Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0 || password.Text.Length == 0)
            {
                MessageBox.Show("please fill username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    conn.Open();


                    string inputData = "SELECT * FROM Person WHERE username = @username AND password = @password";


                    using (SqlCommand cmd = new SqlCommand(inputData, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);



                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully");
                            MainMenu mainMenu = new MainMenu();
                            mainMenu.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Database error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    conn.Close();
                }


                
            }
        }
    }
}
