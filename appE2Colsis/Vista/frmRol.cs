using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appE2Colsis.Datos;

namespace appE2Colsis.Vista
{
    public partial class frmRol : Form
    {
        int rows = 0;
        public frmRol()
        {
            InitializeComponent();
        }

        public void mtdComprobar()
        {
            if (rows>0)
            {
                MessageBox.Show("Registro Satisfactorio", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No fue posible atender la Solicitud", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            clRol objRol = new clRol();
            objRol.nombreRol = txtRol.Text;
           rows=  objRol.mtdRegistrarRol();
            mtdComprobar();
            


        }
    }
}
