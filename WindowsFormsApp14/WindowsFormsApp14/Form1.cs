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
    public partial class Form1 : Form
    {
        Factorial fa = new Factorial();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fa.Show();
            fa.SetText2(textBox1.Text);


            //MessageBox.Show(textBox1.Text.);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customers cs = new customers();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCustomers sc = new ShowCustomers();
            sc.Show();
        }
    }
}
