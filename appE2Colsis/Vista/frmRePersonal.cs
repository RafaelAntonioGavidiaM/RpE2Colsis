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
    public partial class frmRePersonal : Form
    {
        public frmRePersonal()
        {
            InitializeComponent();
        }
        clRePersonal objRePersonal;
        List<clRePersonal> listRePersonal;   
        clRol objRol;
        private void frmRePersonal_Load(object sender, EventArgs e)
        {
            mtdCargar();
        }

        public void mtdCargar()
        {
            listRePersonal = new List<clRePersonal>();
            objRePersonal = new clRePersonal();
            listRePersonal = objRePersonal.mtdListar();
            dgvEmpleado.DataSource = listRePersonal;

            objRol = new clRol();
            List<clRol> listaRol = new List<clRol>();
            listaRol = objRol.mtdConsultarRol();
            cmbRol.DataSource = listaRol;
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";


        }




    }
}
