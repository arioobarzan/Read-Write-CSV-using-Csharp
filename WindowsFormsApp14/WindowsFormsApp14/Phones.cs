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
    public partial class Phones : Form
    {
        public Phones()
        {
            InitializeComponent();
        }

        private void Phones_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gheir\source\repos\WindowsFormsApp14\WindowsFormsApp14\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string cmd = "SELECT * FROM phone_table";

                SqlCommand command = new SqlCommand(cmd, connection);

                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    listBox1.Items.Add(sdr["model"] + " - " + sdr["color"]);
                    comboBox1.Items.Add(sdr["model"] + " - " + sdr["color"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
