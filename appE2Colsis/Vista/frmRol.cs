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

        List<clRol> listaRoles = new List<clRol>();
        clRol objRol = new clRol();
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
        public void mtdCargarCmbRol()
        {
            
            List<clRol> listaRol = new List<clRol>();
           listaRol= objRol.mtdConsultarRol();
            cmbRol.DataSource = listaRol;
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
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
            mtdCargarCmbRol();
            dgvSeleccionar.Visible=false;
           

        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {
           int idRol = 0;
          string[]  formularios = new string[2];
            formularios[0] = frm1.Text;
            formularios[1] = frm2.Text;

            Boolean[] opcion = new Boolean[2];
            opcion[0] = rbHabilitadofrm1.Checked;
            opcion[1] = rbHabilitadofrm2.Checked;

            List<clRol> listaComprobarid = new List<clRol>();

          listaComprobarid=  objRol.mtdConsultarRol();
            foreach (var item in listaComprobarid)
            {
                if (txtRol.Text==item.nombreRol)
                {
                    idRol = item.idRol;  
                    
                }
            }



            List<clRol> ListaRol = new List<clRol>();
            for (int i = 0; i < 2; i++)
            {
                clRol objRol = new clRol();
                objRol.idRol = idRol;
                objRol.nombreFormulario = formularios[i];
                if (opcion[i]==true)
                {
                    objRol.idPermiso = 1;

                }
                else
                {
                    objRol.idPermiso = 2;
                }

                ListaRol.Add(objRol);

              
                
            }
            rows = objRol.mtdRegistrarPermisos(ListaRol);
            mtdComprobar();
            mtdCargarCmbRol();
            




        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void mtdCargarGridEliminar()
        {
            objRol.nombreRol = cmbRol.Text;

            listaRoles = objRol.mtdColsutarPermisosRoles();
            dgvContenidoRol.DataSource = listaRoles;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            mtdCargarGridEliminar();
            dgvSeleccionar.Visible = true;
            
          
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            int idRolEliminar = 0;//id que me permitira eliminar los registro en rol y rol_permisos
            foreach (var item in listaRoles)
            {
                if (cmbRol.Text==item.nombreRol)
                {
                    idRolEliminar = item.idRol;

                }

            }

            DialogResult opcion = MessageBox.Show("¿Desea Realmente Eliminar el registro y los permisos?", "Advetencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (opcion==DialogResult.Yes)
            {
                objRol.idRol = idRolEliminar;
               rows= objRol.mtdEliminarRolYPermisos();
                mtdComprobar();
                mtdCargarGridEliminar();
                

            }
        }
    }
}
