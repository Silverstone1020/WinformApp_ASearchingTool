using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppPractice11
{
    public partial class Form1 : Form
    {
        private string dir;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir = comboBox1.Text;
            listBox1.Items.Clear();
            foreach (string s in Directory.GetDirectories(dir))
            {
                listBox1.Items.Add(s);
            }

            listBox2.Items.Clear();
            foreach (string s in Directory.GetFiles(dir))
            {
                listBox2.Items.Add(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                comboBox1.Items.Add(s);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            dir = listBox1.Text;

            listBox1.Items.Clear();
            foreach (string s in Directory.GetDirectories(dir))
            {
                listBox1.Items.Add(s);
            }

            listBox2.Items.Clear();
            foreach (string s in Directory.GetFiles(dir))
            {
                listBox2.Items.Add(s);
            }

            MessageBox.Show(dir);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox3.Items.Clear();

            try
            {
                foreach (string s in Directory.GetFiles(dir, "*.doc*"))
                {
                    listBox3.Items.Add(s);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Sorted = true;
        }
    }
}
