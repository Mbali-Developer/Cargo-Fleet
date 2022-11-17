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
    public partial class AppointmentListReport : Form
    {
        public AppointmentListReport()
        {
            InitializeComponent();
        }

        private void AppointmentListReport_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void btnSaveWA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Weekly appointments are successfully saved");
        }
    }
}
