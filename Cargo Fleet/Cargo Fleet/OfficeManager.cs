using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargo_Fleet
{
    public partial class OfficeManager : Form
    {
        public OfficeManager()
        {
            InitializeComponent();
        }

        private void rbtnTasks_CheckedChanged(object sender, EventArgs e)
        {
            SharedTasks st = new SharedTasks();
            st.Show();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(chBoxVehInfo.Checked = true)
            {
                //open the report for this checkbox
                VehicleStatusReport vsr = new VehicleStatusReport();
                vsr.Show();
                this.Close();

              
            }
            else if(chBoxTrip.Checked = true)
            {
                //open report
            }
            else if(chBoxTimesheet.Checked = true)
            {
                //open report
            }
            else if(chBoxService.Checked = true)
            {
                //open report
            }
        }

        private void rbtnWriteReport_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
