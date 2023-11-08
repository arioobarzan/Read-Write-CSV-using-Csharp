using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }
        public Factorial(int i)
        {
            InitializeComponent();
            textBox1.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int f = Fact(textBox1.Text);
            MessageBox.Show(Fact(i).ToString());
            textBox1.Text = "";
        }
        private int Fact(int i)
        {
            int f = 1;
            for (int x = 1; x <= i; x++)
                f *= x;

            return f;
        }
        private int Fact(string str)
        {
            int i = int.Parse(str);
            int f = 1;
            for (int x = 1; x <= i; x++)
                f *= x;

            return f;
        }

        private void Factorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public void SetText(string text)
        {
            textBox1.Text = text;
        }
        public void SetText2(string text)
        {
            if (text.Contains(","))
            {
                int commaIndex = text.IndexOf(",");
                string str1 = text.Substring(0, commaIndex);
                string str2 = text.Substring(commaIndex + 1);
                textBox1.Text = str1;
                textBox2.Text = str2;
            }
            else
                textBox1.Text = text;
        }
    }
}
