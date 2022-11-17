using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cargo_Fleet
{
    public partial class ServiceManager : Form
    {
        public ServiceManager()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddServ_Click(object sender, EventArgs e)
        {
            this.ServiceBox.Hide();
            while(btnAddServ.Enabled = true)
            {
                ServiceBox.Show();
               
            }
          
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            SharedTasks st = new SharedTasks();
            st.Show();
            this.Close();
        }

        private void btnSaveServ_Click(object sender, EventArgs e)
        {
            //creating a connection string to connect to the database
            SqlConnection con = new SqlConnection(@"");
            string query;


            //declaring varibles to store inputs
            int vehnumber = Convert.ToInt32(txtVNum.Text);
            string servtype = cBoxServType.Text;
            DateTime servappointment = Convert.ToDateTime(dateTimePicker2);
            string servdescription = richTextBox1.Text;



            //store to database
            query = "INSERT INTO VEHSERVICES(VehNum,Servicetype,AppointDate,DescripService) VALUES({0},{1},{2},{3}" + vehnumber + servtype + servappointment + servdescription;

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
           

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AppointmentListReport alr = new AppointmentListReport();
            alr.Show();
            this.Close();
        }
    }
}
