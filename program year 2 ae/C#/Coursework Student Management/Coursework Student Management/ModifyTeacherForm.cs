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

namespace Coursework_Student_Management
{
    public partial class ModifyTeacherForm : Form
    {


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\school management.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public ModifyTeacherForm()
        {
            InitializeComponent();

            TeacherDisplayData();
        }


        public void TeacherDisplayData()
        {
            Teacher teacher = new Teacher();
            teacherDataGridView.DataSource = teacher.TeacherData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (teacherID.Text == "" || teacherName.Text == "" || teacherGender.Text == "" || teacherEmail.Text == "" || teacherPassword.Text == "" || teacherTelephone.Text == "")
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

                        string checkTeacherExist = "SELECT COUNT(*) FROM Teacher WHERE id = @id";

                        using (SqlCommand checkteacherexist = new SqlCommand(checkTeacherExist, conn))
                        {
                            checkteacherexist.Parameters.AddWithValue("@id", teacherID.Text);
                            int count = (int)checkteacherexist.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("Teacher ID: " + teacherID.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string add = "INSERT INTO Teacher (id, username, email, telephone, role, password, gender, subjectID) VALUES (@id, @username, @email, @telephone, @role, @password, @gender, @subjectID)";

                                using (SqlCommand cmd = new SqlCommand(add, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", teacherID.Text);
                                    cmd.Parameters.AddWithValue("@username", teacherName.Text);
                                    cmd.Parameters.AddWithValue("@email", teacherEmail.Text);
                                    cmd.Parameters.AddWithValue("@telephone", teacherTelephone.Text);
                                    cmd.Parameters.AddWithValue("@role", "Teacher");
                                    cmd.Parameters.AddWithValue("@password", teacherPassword.Text);
                                    cmd.Parameters.AddWithValue("@gender", teacherGender.Text);
                                    if (subjectID.Text == "Programming Foundation")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 1);
                                    }
                                    if (subjectID.Text == "Database")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 2);
                                    }
                                    if (subjectID.Text == "OOP")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 3);
                                    }
                                    if (subjectID.Text == "Networking")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 4);
                                    }
                                    if (subjectID.Text == "DSA")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 5);
                                    }
                                    if (subjectID.Text == "Operating System")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 6);
                                    }
                                    if (subjectID.Text == "Math")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 7);
                                    }
                                    if (subjectID.Text == "English")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 8);
                                    }


                                    cmd.ExecuteNonQuery();

                                    TeacherDisplayData();

                                    ClearField();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
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


        public void ClearField()
        {
            teacherID.Text = "";
            teacherName.Text = "";
            teacherGender.Text = "";
            teacherEmail.Text = "";
            teacherPassword.Text = "";
            teacherTelephone.Text = "";
            subjectID.Text = "";
        }

        private void teacherDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacherDataGridView.Rows[e.RowIndex];
                teacherID.Text = row.Cells[0].Value.ToString();
                teacherName.Text = row.Cells[1].Value.ToString();
                teacherGender.Text = row.Cells[2].Value.ToString();
                teacherEmail.Text = row.Cells[3].Value.ToString();
                //teacherRole.Text = "Teacher";
                teacherPassword.Text = row.Cells[5].Value.ToString();
                teacherTelephone.Text = row.Cells[6].Value.ToString();
                subjectID.Text = row.Cells[7].Value.ToString();
            }
        }



        private void Update_Click(object sender, EventArgs e)
        {
            if (teacherID.Text == "" || teacherName.Text == "" || teacherGender.Text == "" || teacherEmail.Text == "" || teacherPassword.Text == "" || teacherTelephone.Text == "")
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

                        string checkTeacherExist = "SELECT COUNT(*) FROM Teacher WHERE id = @id";

                        using (SqlCommand checkteacherexist = new SqlCommand(checkTeacherExist, conn))
                        {
                            checkteacherexist.Parameters.AddWithValue("@id", teacherID.Text);
                            int count = (int)checkteacherexist.ExecuteScalar();
                            if (count < 1)
                            {
                                MessageBox.Show("Teacher ID: " + teacherID.Text + " is not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string update = "UPDATE Teacher SET username = @username, email = @email, telephone = @telephone, role = @role, password = @password, gender = @gender, classID = @classID WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(update, conn))
                                {

                                    cmd.Parameters.AddWithValue("@username", teacherName.Text);
                                    cmd.Parameters.AddWithValue("@email", teacherEmail.Text);
                                    cmd.Parameters.AddWithValue("@telephone", teacherTelephone.Text);
                                    cmd.Parameters.AddWithValue("@role", "Teacher");
                                    cmd.Parameters.AddWithValue("@password", teacherPassword.Text);
                                    cmd.Parameters.AddWithValue("@gender", teacherGender.Text);
                                    if (subjectID.Text == "Programming Foundation")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 1);
                                    }
                                    if (subjectID.Text == "Database")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 2);
                                    }
                                    if (subjectID.Text == "OOP")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 3);
                                    }
                                    if (subjectID.Text == "Networking")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 4);
                                    }
                                    if (subjectID.Text == "DSA")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 5);
                                    }
                                    if (subjectID.Text == "Operating System")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 6);
                                    }
                                    if (subjectID.Text == "Math")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 7);
                                    }
                                    if (subjectID.Text == "English")
                                    {
                                        cmd.Parameters.AddWithValue("@subjectID", 8);
                                    }

                                    cmd.Parameters.AddWithValue("@id", teacherID.Text);


                                    cmd.ExecuteNonQuery();

                                    TeacherDisplayData();

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
            if (teacherID.Text == "" || teacherName.Text == "" || teacherGender.Text == "" || teacherEmail.Text == "" || teacherPassword.Text == "" || teacherTelephone.Text == "")
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

                        string delete = "DELETE FROM Teacher WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", teacherID.Text);

                            cmd.ExecuteNonQuery();

                            TeacherDisplayData();

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
