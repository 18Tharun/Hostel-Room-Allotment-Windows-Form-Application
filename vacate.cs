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

namespace HostelManagementApplication
{
    public partial class vacate : Form
    {
        SqlConnection connection;
        SqlCommand SqlCommand,sqlc2;
        SqlDataReader SqlDataReader;
        public vacate()
        {
            InitializeComponent();
        }

        private void vacate_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leave_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("pass the parmeter of data base such as server name,DB name,securitytype");
            try
            {
                connection.Open();
                string check_roomQuery = "select * from Room where room_no ="+Convert.ToInt32(RoomNumber)+";";
                SqlCommand = new SqlCommand(check_roomQuery,connection);
                SqlDataReader = SqlCommand.ExecuteReader();
                if (SqlDataReader.Read())
                {
                    SqlDataReader.Close();
                    string vacquery = "update Room set status='vacant' where room_no=" + Convert.ToInt32(RoomNumber) + ";";
                    sqlc2 = new SqlCommand(vacquery,connection);
                    sqlc2.ExecuteNonQuery();
                    MessageBox.Show("Thank you..\n visit again");
                }
                else
                {
                    MessageBox.Show("Enter Correct Room Number",MessageBoxButtons.OKCancel.ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
        }
    }
}
