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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenNextPage_Click(object sender, EventArgs e)
        {
        //this code only opens the login page following 
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }
    }
}
