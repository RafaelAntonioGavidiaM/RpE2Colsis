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
                grpPermisos.Text = txtRol.Text;
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

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            grpPermisos.Visible = true;
            grpfrmrol.Visible = true;
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            grpPermisos.Visible = false;
            grpfrmrol.Visible = false;
           

        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {

          string[]  formularios = new string[2];
            formularios[0] = frm1.Text;
            formularios[1] = frm2.Text;

            Boolean[] opcion = new Boolean[2];
            opcion[0] = rbHabilitadofrm1.Checked;
            opcion[1] = rbHabilitadofrm2.Checked;


            List<clRol> ListaRol = new List<clRol>();
            for (int i = 0; i < 2; i++)
            {
                clRol objRol = new clRol();
                objRol.nombreRol = txtRol.Text;
                objRol.nombreFormulario = formularios[i];
                if (opcion[i]==true)
                {
                    objRol.permiso = 1;

                }
                else
                {
                    objRol.permiso = 0;
                }

                ListaRol.Add(objRol);

            }

            dgvMostrar.DataSource = ListaRol;

        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
