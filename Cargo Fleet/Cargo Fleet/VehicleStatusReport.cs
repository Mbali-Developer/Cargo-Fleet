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
    public partial class VehicleStatusReport : Form
    {
        public VehicleStatusReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //creating a connection string to connect to the database
            SqlConnection con = new SqlConnection(@"");

            //this button will create a report for all the vehicles
            int vehno = Convert.ToInt16(comboBox1.Text);

            //you can use a for loop for this

            if (vehno == 1)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 1", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 2)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 2", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }

            }
            else if(vehno == 3)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 3", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 4)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 4", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 5)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 5", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 6)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 6", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 7)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 7", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 8)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 8", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 9)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 9", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }
            else if(vehno == 10)
            {
                //command to read from database
                SqlCommand myCommand = new SqlCommand("SELECT * FROM VEHICLEINFO WHERE LicPlateNum = 10", con);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    licplat.Text = myReader["LicPlateNum"].ToString();
                    model.Text = (myReader["ModelMake"].ToString());
                    confi.Text = (myReader["Configure"].ToString());
                    body.Text = (myReader["Bodytype"].ToString());
                    Manufacturer.Text = (myReader["Manufacturer"].ToString());
                    registr.Text = (myReader["RegistrationNum"].ToString());
                    engine.Text = (myReader["EngineSize"].ToString());
                    tank.Text = (myReader["Tank"].ToString());
                    numtyres.Text = (myReader["Numoftyres"].ToString());
                    current.Text = (myReader["ODOcur"].ToString());
                    next.Text = (myReader["ODOnext"].ToString());

                }
            }

        }

        private void btnSaveC_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            OfficeManager om = new OfficeManager();
            
            if (om.Enabled)
            {
                panel1.Show();
                if (btnSaveC.Enabled.Equals(true))
                {
                    MessageBox.Show("Comments saved successfully!");
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                panel1.Visible.Equals(false);
            }
           
        }
    }
}
