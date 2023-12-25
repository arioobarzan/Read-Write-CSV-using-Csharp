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

namespace WindowsFormsApp14
{
    public partial class AddPhone : Form
    {
        public AddPhone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string model = textBox1.Text;
                string color = textBox2.Text;
                string price = textBox3.Text;

                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\WindowsFormsApp14\WindowsFormsApp14\Database1.mdf;Integrated Security=True";

                SqlConnection sc = new SqlConnection(cs);
                sc.Open();
                string cmd = "INSERT INTO phone_table (model,color,price) VALUES " +
                    "('" + model + "','" + color + "','" + price + "')";
                SqlCommand command = new SqlCommand(cmd, sc);
                if(command.ExecuteNonQuery() == 1)
                    MessageBox.Show("با موفقیت افزوده شد");
                else
                    MessageBox.Show("ایرادی وجود دارد");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
