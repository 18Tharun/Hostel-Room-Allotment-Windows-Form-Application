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
    public partial class roomAllotment : Form
    {
        SqlConnection conn;
        SqlCommand cmd,c2,c3;
        SqlDataReader rdr;
        public roomAllotment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PAYMENT_Click(object sender, EventArgs e)
        {
            conn=new SqlConnection("pass the parmeter of data base such as server name,DB name,securitytype");
            try { conn.Open();
                string que1 = "select * from Room where room_no='"+roomno.Text+ "' AND status ='vacant';";
                cmd = new SqlCommand(que1, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read()) {
                    rdr.Close();
                    string que2 = "insert into Payment values ("
                        +Convert.ToInt32(roomno.Text)+
                        ","+
                        Convert.ToInt32(amt.Text)+
                        ","+
                        Convert.ToInt32(roomno.Text)+
                        ",'"+Nametextbox.Text.ToString().Trim()+"');";
                    c2 = new SqlCommand(que2,conn);
                    c2.ExecuteNonQuery();
                    string que3 = "update Room set status='alloted' where room_no="+Convert.ToInt32(roomno.Text)+";";
                    c3 = new SqlCommand(que3,conn);
                    c3.ExecuteNonQuery();
                    MessageBox.Show("allotment done");
                    MessageBox.Show("ALLOTMENT LETTER\n"+"Dear hostilite,\r\nwe are happy to inform you that you have been alloted the room that you have selected..\r\n\r\nfor your kind information that you have to follow the terms and condition of the hostel \r\nNote: Voilation of the rules is not tolerated and may lead to take action against the hostelite.\r\n\r\nhere are the allotment details\r\n"
                        +"Hostelite name:"+Nametextbox.Text.ToString()+"\n Alloted room number:"+roomno.Text.ToString()+"\nFees paid:"+amt.Text.ToString()+"\n From \n HOSTEL MANAGEMENT");
                    
                    /*var details = new AllotmentDetails();
                    details.Show();*/
                }
                else { MessageBox.Show("Room number Entered is Not available " +
                    "CHECK ENQUIRY LIST CAREFULLY AND TRY AGAIN"); }
            
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var e1 = new Enquiry();
            this.Hide();
            e1.Show();
        }

        private void roomAllotment_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
