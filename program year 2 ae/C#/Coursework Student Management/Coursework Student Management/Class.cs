using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coursework_Student_Management
{

    class Person
    {
        private string name { set; get; } //abstract
        private string email { set; get; }
        private string telephone { set; get; }

        public string Name { get { return name; } set { name = value; } } //encapsulation
        public string Email { get { return email; } set { email = value; } }

        public string Telephone { get {  return telephone; } set { telephone = value; } }
    }


    class Student : Person //inheritance
    {
        private int id { set; get; }
        public int Id { get { return id; } set { id = value; } }

        private string name { set; get; }
        public new string Name { get { return name; } set { name = value; } }

        private string email { set; get; }
        public new string Email { get { return email; } set { email = value; } }

        private string telephone { set; get; }
        public new string Telephone { get { return telephone; } set { telephone = value; } }

        private string role { set; get; }
        public string Role { get { return role; } set { role = value; } }

        private string password { set; get; }
        public string Password { get { return password; } set { password = value; } }

        private string gender { set; get; }
        public string Gender { get { return gender; } set { gender = value; } }

        private string classID { set; get; }
        public string ClassID { get { return classID; } set { classID = value; } }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\school management.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public List<Student> StudentData()
        {
            List<Student> studentlist = new List<Student>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM Student";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Student student = new Student();
                            student.id = (int)reader["id"];
                            student.name = reader["username"].ToString();
                            student.email = reader["email"].ToString();
                            student.telephone = reader["telephone"].ToString();
                            student.role = reader["role"].ToString();
                            student.password = reader["password"].ToString();
                            student.gender = reader["gender"].ToString();
                            student.classID = reader["classID"].ToString();

                            studentlist.Add(student);
                        }
                        reader.Close();
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
            return studentlist;
        }
    }


    class Teacher : Person //inheritance
    {
        private int id { set; get; }
        public int Id { get { return id; } set { id = value; } }


        private string name { set; get; }
        public new string Name { get { return name; } set { name = value; } }

        private string email { set; get; }
        public new string Email { get { return email; } set {email = value; } }

        private string telephone { set; get; }
        public new string Telephone { get { return telephone; } set { telephone = value; } }


        private string role { set; get; }
        public string Role { get { return role; } set { role = value; } }

        private string password { set; get; }
        public string Password { get { return password; } set { password = value; } }

        private string gender { set; get; }
        public string Gender { get { return gender; } set { gender = value; } }

        private string subjectID { set; get; }
        public string SubjectID { get { return subjectID; } set { subjectID = value; } }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\school management.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public List<Teacher> TeacherData()
        {
            List<Teacher> teacherlist = new List<Teacher>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM Teacher";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Teacher teacher = new Teacher();
                            teacher.id = (int)reader["id"];
                            teacher.name = reader["username"].ToString();
                            teacher.email = reader["email"].ToString();
                            teacher.telephone = reader["telephone"].ToString();
                            teacher.role = reader["role"].ToString();
                            teacher.password = reader["password"].ToString();
                            teacher.gender = reader["gender"].ToString();
                            teacher.subjectID = reader["subjectID"].ToString();

                            teacherlist.Add(teacher);
                        }
                        reader.Close();
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
            return teacherlist;
        }

    }
}
