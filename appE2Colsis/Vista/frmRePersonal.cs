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
        clPersona objPersona;
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

        public void mtdCargarDatos()
        {
            //clPersona objPersona = new clPersona();
            listRePersonal = new List<clRePersonal>();

            for (int i = 0; i < 1; i++)
            {
                clRePersonal objRePersonal = new clRePersonal();
                objRePersonal.nombre = txtNombre.Text;
                objRePersonal.apellido = txtApellido.Text;
                objRePersonal.documento = txtDocumento.Text;
                objRePersonal.telefono = txtTelefono.Text;
                objRePersonal.ciudad = txtCiudad.Text;
                objRePersonal.correoYemail = txtCorreo.Text;              
                objRePersonal.estado = txtEstado.Text;
                objRePersonal.idRol = int.Parse(cmbRol.SelectedValue.ToString());

                listRePersonal.Add(objRePersonal);
            }
            
            

        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mtdCargarDatos();
            DialogResult opcion = MessageBox.Show("Desea registrar" + txtNombre.Text + " " + txtApellido, "como nuevo personal ", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                int Registro = objRePersonal.mtdRegistrar(listRePersonal);

                if (Registro > 0)
                {
                    MessageBox.Show("se realizo el registro exitosamente");
                    mtdCargar();
                }
                else
                {
                    MessageBox.Show("no se pudo hacer el registro correspondinete del nuevo personal");
                } 
            }
        }
    }
}
