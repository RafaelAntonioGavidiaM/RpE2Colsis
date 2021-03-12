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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            /* frmLogin objLogin = new frmLogin();
             objLogin.TopLevel = false;
             objLogin.Parent = pnNombre;
             objLogin.Show();*/

            frmRePersonal objRePersonal = new frmRePersonal();
            objRePersonal.TopLevel = false;
            objRePersonal.Parent = pnNombre;
            objRePersonal.Show();
            
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            frmRol objRol = new frmRol();
            objRol.TopLevel = false;
            objRol.Parent = pnNombre;
            objRol.Show();
        }
    }
}
