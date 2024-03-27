using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int sosanhhon(int x, int y)
        {
            int a = int.Parse(richTextBox1.Text);
            int b = int.Parse(richTextBox2.Text);
            if (a > b)
            {
                return a;
            }
            return a;
        }


        public int sosanhbe(int x, int y)
        {
            int a = int.Parse(richTextBox1.Text);
            int b = int.Parse(richTextBox2.Text);
            int result = 0;
            if (a > b)
            {
                return b;
            }
            return b;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(richTextBox1.Text);
            int b = int.Parse(richTextBox2.Text);
            richTextBox3.Text = Convert.ToString(sosanhhon(a, b));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(richTextBox1.Text);
            int b = int.Parse(richTextBox2.Text);
            richTextBox3.Text = Convert.ToString(sosanhbe(a, b));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
