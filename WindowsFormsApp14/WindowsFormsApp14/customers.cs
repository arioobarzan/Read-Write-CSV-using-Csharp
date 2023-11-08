using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string family = textBox2.Text;
                string tel = textBox3.Text;
                string line = name + "," + family + "," + tel + "\n";
                File.AppendAllText("sample.csv", line);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
