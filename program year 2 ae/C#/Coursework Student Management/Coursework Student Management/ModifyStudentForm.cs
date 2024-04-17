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
    public partial class ModifyStudentForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\school management.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public ModifyStudentForm()
        {
            InitializeComponent();

            studentDisplayData();
        }

        public void studentDisplayData()
        {
            Student student = new Student();
            studentDataGridView.DataSource = student.StudentData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Add_Click(object sender, EventArgs e)
        {
            if (studentID.Text == "" || studentName.Text == "" || studentGender.Text == "" || studentEmail.Text == "" || studentPassword.Text == "" || studentTelephone.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        string checkStudentExist = "SELECT COUNT(*) FROM Student WHERE id = @id";

                        using (SqlCommand checkstudentexist = new SqlCommand(checkStudentExist, conn))
                        {
                            checkstudentexist.Parameters.AddWithValue("@id", studentID.Text);
                            int count = (int)checkstudentexist.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID: " + studentID.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } 
                            else
                            {
                                string add = "INSERT INTO Student (id, username, email, telephone, role, password, gender, classID) VALUES (@id, @username, @email, @telephone, @role, @password, @gender, @classID)";

                                using (SqlCommand cmd =  new SqlCommand(add, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", studentID.Text);
                                    cmd.Parameters.AddWithValue("@username", studentName.Text);
                                    cmd.Parameters.AddWithValue("@email", studentEmail.Text);
                                    cmd.Parameters.AddWithValue("@telephone", studentTelephone.Text);
                                    cmd.Parameters.AddWithValue("@role", "Student");
                                    cmd.Parameters.AddWithValue("@password", studentPassword.Text);
                                    cmd.Parameters.AddWithValue("@gender", studentGender.Text);
                                    if(classID.Text == "1A")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 1);
                                    }
                                    if (classID.Text == "1B")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 2);
                                    }
                                    if (classID.Text == "1C")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 3);
                                    }
                                    if (classID.Text == "2A")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 4);
                                    }
                                    if (classID.Text == "2B")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 5);
                                    }
                                    if (classID.Text == "2C")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 6);
                                    }
                                    if (classID.Text == "3A")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 7);
                                    }
                                    if (classID.Text == "3B")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 8);
                                    }
                                    if (classID.Text == "3C")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 9);
                                    }



                                    cmd.ExecuteNonQuery();

                                    studentDisplayData();

                                    ClearField();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    

                                }
                            }
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }






        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void ClearField()
        {
            studentID.Text = "";
            studentName.Text = "";
            studentGender.Text = "";
            studentEmail.Text = "";
            studentPassword.Text = "";
            studentTelephone.Text = "";
            classID.Text = "";
        }

        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = studentDataGridView.Rows[e.RowIndex];
                studentID.Text = row.Cells[0].Value.ToString();
                studentName.Text = row.Cells[1].Value.ToString();
                studentGender.Text = row.Cells[2].Value.ToString();
                studentEmail.Text = row.Cells[3].Value.ToString();
                //studentRole.Text = "Student";
                studentPassword.Text = row.Cells[5].Value.ToString();
                studentTelephone.Text = row.Cells[6].Value.ToString();
                classID.Text = row.Cells[7].Value.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            if (studentID.Text == "" || studentName.Text == "" || studentGender.Text == "" || studentEmail.Text == "" || studentPassword.Text == "" || studentTelephone.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        string checkStudentExist = "SELECT COUNT(*) FROM Student WHERE id = @id";

                        using (SqlCommand checkstudentexist = new SqlCommand(checkStudentExist, conn))
                        {
                            checkstudentexist.Parameters.AddWithValue("@id", studentID.Text);
                            int count = (int)checkstudentexist.ExecuteScalar();
                            if (count < 1)
                            {
                                MessageBox.Show("Student ID: " + studentID.Text + " is not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string update = "UPDATE Student SET username = @username, email = @email, telephone = @telephone, role = @role, password = @password, gender = @gender, classID = @classID WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(update, conn))
                                {
                                    
                                    cmd.Parameters.AddWithValue("@username", studentName.Text);
                                    cmd.Parameters.AddWithValue("@email", studentEmail.Text);
                                    cmd.Parameters.AddWithValue("@telephone", studentTelephone.Text);
                                    cmd.Parameters.AddWithValue("@role", "Student");
                                    cmd.Parameters.AddWithValue("@password", studentPassword.Text);
                                    cmd.Parameters.AddWithValue("@gender", studentGender.Text);
                                    if (classID.Text == "1A")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 1);
                                    }
                                    if (classID.Text == "1B")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 2);
                                    }
                                    if (classID.Text == "1C")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 3);
                                    }
                                    if (classID.Text == "2A")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 4);
                                    }
                                    if (classID.Text == "2B")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 5);
                                    }
                                    if (classID.Text == "2C")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 6);
                                    }
                                    if (classID.Text == "3A")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 7);
                                    }
                                    if (classID.Text == "3B")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 8);
                                    }
                                    if (classID.Text == "3C")
                                    {
                                        cmd.Parameters.AddWithValue("@classID", 9);
                                    }

                                    cmd.Parameters.AddWithValue("@id", studentID.Text);


                                    cmd.ExecuteNonQuery();

                                    studentDisplayData();

                                    ClearField();

                                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (studentID.Text == "" || studentName.Text == "" || studentGender.Text == "" || studentEmail.Text == "" || studentPassword.Text == "" || studentTelephone.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        
                        string delete = "DELETE FROM Student WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", studentID.Text);

                            cmd.ExecuteNonQuery();

                            studentDisplayData();

                            ClearField();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
