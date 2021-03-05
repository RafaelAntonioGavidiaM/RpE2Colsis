using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appE2Colsis.Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text=="admin" &&txtPswd.Text=="admin2021")
            {
                pSettings.Visible = true;

            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pSettings.Visible = false;
            grpSetting.Visible = false;
        }

        private void pSettings_Click(object sender, EventArgs e)
        {
            grpSetting.Visible = true;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            pSettings.Visible = false;
            grpSetting.Visible = false;

        }
    }
}
