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
    public partial class TripUsage : Form
    {
        public TripUsage()
        {
            InitializeComponent();
        }

        private void rbtnSchedule_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            while(rbtnSchedule.Enabled = true)
            {
                groupBox1.Show();
               
            }
        }

        private void btnOpTask_Click(object sender, EventArgs e)
        {
            SharedTasks st = new SharedTasks();
            st.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //creating a connection string to connect to the database
            SqlConnection con = new SqlConnection(@"");
            string query;

            //declaring variables to store inputs
            int vehnum = Convert.ToInt32(txtVehNo.Text);
            DateTime appointDate = Convert.ToDateTime(dateTimePicker1.Text);
            int procode = Convert.ToInt32(txtProCode.Text);
            string description = txtDescrip.Text;
            string configure = comboBox1.Text;
            string bodytype = comboBox2.Text;
            string destination = txtdestination.Text;
            int fuelusage = Convert.ToInt32(txtfuel.Text);
            DateTime time = Convert.ToDateTime(txtTime.Text);

            //add to database
            query = "INSERT INTO SCHEDULETRIP(vehnum,appointDate,procode,description,configure,bodytype,destination,fuelusage,time) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8}" + vehnum + appointDate + procode + description + configure+ bodytype+ destination+ fuelusage + time;

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Trip scheduled successfully!");
            con.Close();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
