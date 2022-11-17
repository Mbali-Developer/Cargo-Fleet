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
    public partial class VehInfoAdmin : Form
    {
        //creating a connection string to connect to the database
        SqlConnection con = new SqlConnection(@"");
        string query;
        //SqlCommand cmd = new SqlCommand(query, con);
        //con.Open();
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("Data has been saved");
        //    con.Close();
        public VehInfoAdmin()
        {
            InitializeComponent();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            //creating a connection string to connect to the database
            SqlConnection con = new SqlConnection(@"");

            //declaring variables to save inputs
            string licplateno = txtPlateno.Text;
            string modelmake = txtModel.Text;
            string configure = txtConf.Text;
            string bodytype = txtBType.Text;
            string manufacturer = txtManufac.Text;
            int regnum = Convert.ToInt32(txtRegNo.Text);
            int engsize = Convert.ToInt32(txtEngSize.Text);
            int tank = Convert.ToInt32(txtTank.Text);
            int numoftyres = Convert.ToInt32(txtNoTyres.Text);
            string odocur = txtCurReading.Text;
            string odonext = txtNextReading.Text;
            int checkVeh = Convert.ToInt32(txtCheckedVeh.Text);

            //the while loop will add  the information to the database
            while(btnSaveInfo.Enabled = true)
            {
                string query = "INSERT INTO SCHEDULETRIP(LicPlateNum,ModelMake,Configure,Bodytype,Manufacturer,RegistrationNum,EngineSize,Tank,Numoftyres,ODOcur,ODOnext) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}" + licplateno + modelmake + configure + bodytype + manufacturer + regnum + engsize + tank + numoftyres + odocur + odonext;

                //this code will send a message back to the user 
                MessageBox.Show("Vehicle information saved successfully");
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            //ask the user which vehicle's details to change
            MessageBox.Show("Please select the vehicle number");

          


            if (cBoxNumbering.SelectedItem.ToString() == "1")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 1", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                  txtModel.Text= (myReader["ModelMake"].ToString());
                    txtConf.Text =(myReader["Configure"].ToString());
                    txtBType.Text =(myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                   txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                 }  
            }
            else if(cBoxNumbering.SelectedItem.ToString() == "2")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 2", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }

            }
            else if(cBoxNumbering.SelectedItem.ToString() == "3")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 3", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(cBoxNumbering.SelectedItem.ToString() == "4")
            {

                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 4", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(cBoxNumbering.SelectedItem.ToString() == "5")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 5", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if (cBoxNumbering.SelectedItem.ToString() == "6")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 6", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if (cBoxNumbering.SelectedItem.ToString() == "7")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 7", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if (cBoxNumbering.SelectedItem.ToString() == "8")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 9", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if (cBoxNumbering.SelectedItem.ToString() == "10")
            {
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 10", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    txtPlateno.Text = myReader["LicPlateNum"].ToString();
                    txtModel.Text = (myReader["ModelMake"].ToString());
                    txtConf.Text = (myReader["Configure"].ToString());
                    txtBType.Text = (myReader["Bodytype"].ToString());
                    txtManufac.Text = (myReader["Manufacturer"].ToString());
                    txtRegNo.Text = (myReader["RegistrationNum"].ToString());
                    txtEngSize.Text = (myReader["EngineSize"].ToString());
                    txtTank.Text = (myReader["Tank"].ToString());
                    txtNoTyres.Text = (myReader["Numoftyres"].ToString());
                    txtCurReading.Text = (myReader["ODOcur"].ToString());
                    txtNextReading.Text = (myReader["ODOnext"].ToString());

                }
            }

        }

        private void ClearInfo_Click(object sender, EventArgs e)
        {
            txtPlateno.Clear();
            txtModel.Clear();
            txtConf.Clear();
            txtBType.Clear();
            txtManufac.Clear();
            txtRegNo.Clear();
            txtEngSize.Clear();
            txtTank.Clear();
            txtNoTyres.Clear();
            txtCurReading.Clear();
            txtNextReading.Clear();
        }

        private void btnOpenTasks_Click(object sender, EventArgs e)
        {
            SharedTasks st = new SharedTasks();
            st.Show();
            this.Close();

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            VehicleStatusReport vsr = new VehicleStatusReport();
            vsr.Show();
            this.Close();


        }

        private void btnStatement_Click(object sender, EventArgs e)
        {

        }
    }
}
