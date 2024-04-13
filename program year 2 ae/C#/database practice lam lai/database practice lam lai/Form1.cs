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
using System.Xml.Linq;

namespace database_practice_lam_lai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
                    
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.employee);

        }


        
        
        private void load(object sender, EventArgs e)
        {
            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Developing-Coding-Programming UoG\program year 2 ae\C#\database practice lam lai\database practice lam lai\Database1.mdf"";Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    string query = "SELECT * FROM employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    employeeDataGridView.DataSource = datatable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            //employeeBindingSource.AddNew();
            int id = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            int salary = Convert.ToInt32(salaryTextBox.Text);
            string role = roleTextBox.Text;

            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Developing-Coding-Programming UoG\program year 2 ae\C#\database practice lam lai\database practice lam lai\Database1.mdf"";Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string query = "INSERT INTO employee(id, name, salary, role) VALUES (@id, @name, @salary, @role)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load(sender, e);
            //employeeDataGridView.SelectedRows.Clear();

        }


        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = employeeDataGridView.SelectedRows[0];
                idTextBox.Text = selectedRow.Cells["id"].Value.ToString();
                nameTextBox.Text = selectedRow.Cells["name"].Value.ToString();
                salaryTextBox.Text = selectedRow.Cells["salary"].Value.ToString();
                roleTextBox.Text = selectedRow.Cells["role"].Value.ToString();
            }
            else
            {
                idTextBox.Text = "";
                nameTextBox.Text = "";
                salaryTextBox.Text = "";
                roleTextBox.Text = "";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            

            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Developing-Coding-Programming UoG\program year 2 ae\C#\database practice lam lai\database practice lam lai\Database1.mdf"";Integrated Security=True";

            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = employeeDataGridView.SelectedRows[0];

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectString))
                    {
                        conn.Open();
                        string query = "DELETE FROM employee WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                load(sender, e);
            }
            //employeeDataGridView.SelectedRows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            int salary = Convert.ToInt32(salaryTextBox.Text);
            string role = roleTextBox.Text;

            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Admin\Documents\Developing-Coding-Programming UoG\program year 2 ae\C#\database practice lam lai\database practice lam lai\Database1.mdf"";Integrated Security=True";

            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = employeeDataGridView.SelectedRows[0];
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectString))
                    {
                        conn.Open();
                        string query = "UPDATE employee SET name = @name, salary = @salary, role = @role WHERE id = @id ";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                load(sender, e);
                //employeeDataGridView.Se
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
            roleTextBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
