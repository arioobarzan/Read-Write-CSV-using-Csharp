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
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void ShowCustomers_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("sample.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                listBox2.Items.Add(lines[i]);
                comboBox1.Items.Add(lines[i]);
            }

        }
    }
}
