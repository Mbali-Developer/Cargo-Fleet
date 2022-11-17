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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //creating a connection string to connect to the database
            SqlConnection conn = new SqlConnection(@"");
            string query;

            //declaring variables to store the input values and assigning them
            int empNum = Convert.ToInt16(txtEmpNum.Text);
            string empName = txtEmpName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPass = txtConfirm.Text;

            query = "INSERT INTO LOGIN(EmpNum,Empname,Position,Email,Username,UPassword) VALUES({0},{1},{2},{3},{4},{5}"+ empNum+ empName+email+username+password;

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            conn.Close();

            /*string connectionString;
            SqlConnection conn;
            connectionString = @"";
            conn = new SqlConnection(connectionString);
            conn.Open();
           // MessageBox.Show("Connection open!");
           */

           

            //using combobox to login to the specified page
           if(cBoxPosition.SelectedItem.ToString() == "Office Manager")
            {
                //opening the specified page
                if (confirmPass == password)
                {
                    while (btnLogin.Enabled = true)
                    {
                        OfficeManager om = new OfficeManager();
                        om.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password");
                }
            }
            else if(cBoxPosition.SelectedItem.ToString() == "Vehicle Information Administrator")
            {
                if(confirmPass == password)
                {
                    while (btnLogin.Enabled = true)
                    {
                        VehInfoAdmin via = new VehInfoAdmin();
                        via.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password");
                }
                

            }
            else if(cBoxPosition.SelectedItem.ToString() == "Service Manager")
            {
                if (confirmPass == password)
                {
                    while (btnLogin.Enabled = true)
                    {
                        ServiceManager ser = new ServiceManager();
                        ser.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password");
                }
            }
            else if(cBoxPosition.SelectedItem.ToString() == "Trip/usage Manager")
            {
                if (confirmPass == password)
                {
                    while (btnLogin.Enabled = true)
                    {
                        TripUsage tu = new TripUsage();
                        tu.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password");
                }

            }
            else if(cBoxPosition.SelectedItem.ToString() == "Timesheet Manager")
            {
                if (confirmPass == password)
                {
                    while (btnLogin.Enabled = true)
                    {
                        TimesheetMan tsm = new TimesheetMan();
                        tsm.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password");
                }
            }
            else
            {
                //prompting the user to enter the correct conditions
                MessageBox.Show("Error!!! \nPlease enter the correct details");
            }

            //adding the inputs to the database
            /*SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into CargoFleet (EmpNum,EmpName,Position,Email,Username,Password) values

            conn.Close();*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
