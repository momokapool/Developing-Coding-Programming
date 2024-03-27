using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = richTextBox1.Text;
            if (!IsvalidName(name))
            {
                MessageBox.Show("Invalid Name");
            }


            double salary;
            if(!double.TryParse(richTextBox2.Text, out salary))
            {
                MessageBox.Show("Invalid salary input");
                return;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool IsvalidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }
        
    }
}
