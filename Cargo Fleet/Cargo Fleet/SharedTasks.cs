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
    public partial class SharedTasks : Form
    {
        public SharedTasks()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            //creating a connection string to connect to the database
            SqlConnection con = new SqlConnection(@"");
            string query;

            //declaring variables to store the inputs
            string plateno = txtLplateNo.Text;
            string modelmake = txtModel.Text;
            string configuration = cBoxConfi.Text;
            string bodytype = cBoxType.Text;

            while(btnSaveRecord.Enabled = true)
            {
                //add to database
                query = "INSERT INTO LOGIN(plateno,modelmake,configuration,bodytype) VALUES({0},{1},{2},{3}" + plateno + modelmake + configuration + bodytype ;

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip scheduled successfully!");
                con.Close();
            }

        }

        private void btnSaveService_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                checkedListBox1.SetItemChecked(i, true);
                MessageBox.Show("Service successfully completed!");
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                checkedListBox1.SetItemChecked(i, false);
                MessageBox.Show("Please add the missing service");
            }

        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            checkedListBox1.ClearSelected();
        }

        private void btnTripDetails_Click(object sender, EventArgs e)
        {
            if(cBoxYesTire.Checked && cBoxYesTools.Checked && cBoxYesPetrol.Checked && cBoxFull.Checked)
            {

                MessageBox.Show("Trip details and supplies are successfully accepted. Vehicle is ready to go!");
            }
            else if(cBoxYesTire.Checked && cBoxYesTools.Checked && cBoxYesPetrol.Checked && cBoxHalf.Checked)
            {
                MessageBox.Show("Vehicle tank needs to be filled up and vehicle will be ready to go!");
            }
            else if(cBoxYesTire.Checked && cBoxYesTools.Checked && cBoxYesPetrol.Checked && cBoxEmpty.Checked)
            {
                MessageBox.Show("Petrol is empty, please fill up vehicle before trip!");
            }
            else if(cBoxNoTire.Checked && cBoxYesTools.Checked && cBoxYesPetrol.Checked && cBoxFull.Checked)
            {
                MessageBox.Show("Add spare tire to trip supplies for vehicle. \nAnd vehicle will be ready to go!");
            }
            else if(cBoxYesTire.Checked && cBoxNoTools.Checked && cBoxYesPetrol.Checked && cBoxFull.Checked)
            {
                MessageBox.Show("Add tools for trip supplies. \nAnd vehicle will be ready to go!");
            }
            else if (cBoxYesTire.Checked && cBoxYesTools.Checked && cBoxNoPetrol.Checked && cBoxEmpty.Checked)
            {
                MessageBox.Show("Petrol is empty, please fill up vehicle before trip!");
            }

        }

        private void btnClearT_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnClearI_Click(object sender, EventArgs e)
        {
            txtLplateNo.Clear();
            txtModel.Clear();
        }
    }
}
