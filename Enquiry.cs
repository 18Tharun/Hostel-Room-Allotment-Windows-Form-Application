using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace HostelManagementApplication
{
    public partial class Enquiry : Form
    {
        SqlConnection conn;
        SqlCommand cmd; 
        DataTable dt=new DataTable();
        public Enquiry()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Enquiry_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("pass the parmeter of data base such as server name,DB name,securitytype");
            try {
                conn.Open();
                string q1 = "select room_no,floor from Room where status ='vacant'";
                cmd = new SqlCommand(q1, conn);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
            finally { conn.Close(); }

            }

        private void bookroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var allotment = new roomAllotment();
            allotment.Show();
        }
    }
}
