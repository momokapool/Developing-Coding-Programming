using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace file_manage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mytext;
            StreamReader myfile = new StreamReader("mytextfile.txt");
            mytext = myfile.ReadLine();
            richTextBox1.Text = mytext;
            myfile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "Me may\n";
                int[] nums = { 1, 2, 3, 4, 5, 6, };
                richTextBox1.Text += Convert.ToString(nums[10]);

            }
            catch(Exception ex) 
            {
                richTextBox1.Text += "out of bound";
                Console.WriteLine(ex.Message);
            }
            finally
            {
                richTextBox1.Text += "\nbeo";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mytext;
                StreamReader myfile = new StreamReader("mytextfile.txt");
                mytext = myfile.ReadLine();
                richTextBox1.Text = mytext;
                myfile.Close();
            }
            catch (Exception ex)
            {
                richTextBox1.Text += "The file doesnt exist";
                Console.WriteLine(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader myfile = new StreamReader("mytextfile.txt");

                while (myfile.Peek() != -1)
                {
                    int ascii_code = myfile.Read();
                    richTextBox1.Text += Convert.ToChar(ascii_code) + ": ";
                    richTextBox1.Text += Convert.ToString(ascii_code) + ": ";
                    richTextBox1.Text += '\n';
                }
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            StreamReader myfile = new StreamReader("mytextfile.txt");

            while (myfile.Peek() != -1)
            {
                int ascii_code = myfile.Read();

                richTextBox1.Text += Convert.ToChar(ascii_code);
                //richTextBox1.Text += Convert.ToString(ascii_code);

                if (ascii_code == 32)
                {
                    richTextBox1.Text += '\n';
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader myfile = new StreamReader("mynum.txt");

            string textnum = "";
            List<int> nums = new List<int>();

            while (myfile.Peek() != -1)
            {
                int ascii_code = myfile.Read();
                char current_char = (char)ascii_code;
                if (current_char != ' ')
                {
                    textnum += current_char;

                } else
                {
                    int num = Convert.ToInt32(current_char);
                    nums.Add(num);
                } if (current_char == '\n')
                {

                    //add sum
                    int sum = 0;
                    for (int i = 0; i < nums.Count; i++)
                    {
                        richTextBox1.Text += Convert.ToString(nums[i]);
                        if (i != nums.Count - 1)
                        {
                            richTextBox1.Text += '+';
                        }
                        sum += nums[i];
                    }

                    richTextBox1.Text += "=" + Convert.ToString(sum);
                    richTextBox1.Text += '\n';
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader myfile = new StreamReader("mynum.txt");

            string line = myfile.ReadLine();
            List<int> nums = new List<int>();

            foreach (char c in line)
            {
                int l = Convert.ToInt32(c);
                nums.Add(l);
            }

            int sum = 0;

            foreach(int n in nums)
            {
                sum += n;
            }

            richTextBox1.Text = sum.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StreamReader myfile = new StreamReader("mylist.txt");

            int num = Convert.ToInt32(myfile.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 0; i < num; i++)
            {

            }


        }
    }
}
