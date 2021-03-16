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
using System.Reflection;


namespace appE2Colsis.Vista
{
    public partial class frmMenuPrincipal : Form
    {
        public int idRol { get; set; }
        public string nombrePersona { get; set; }

        public string apellido { get; set; }
        public frmMenuPrincipal(int idRol,string nombrePersona,string apellido)
        {
            this.idRol = idRol;
            this.nombrePersona = nombrePersona;
            this.apellido = apellido;


            InitializeComponent();
        }
        List<clRol> listaPermisos = new List<clRol>();

        private void mtdCerrarFormulario(string formulario = "")
        {
            FormCollection formulariosApp = Application.OpenForms;

            for (int i = 0; i < formulariosApp.Count; i++)
            {
                var nombre = formulariosApp[i].Name;
                if (nombre != "frmMenuPrincipal" && nombre != formulario)
                {
                    formulariosApp[i].Hide();
                }
            }


        }

        public void mtdVerificaPermisos(string nombreFormulario)// Este metodo verificará los permisos que el usuario tiene para el ingreso al programa 
        {

            clLogin objlogin = new clLogin();
            
            objlogin.idRol = idRol;
           listaPermisos= objlogin.mtdConsultarPermisos();
            Boolean ingreso = false;

            foreach (var item in listaPermisos)
            {
                if (item.nombreFormulario==nombreFormulario && item.idPermiso==1)
                {

                    ingreso = true;


                }
                

            }
            if (ingreso==true)
            {
                Type type = Type.GetType("appE2Colsis.Vista"+nombreFormulario); // This == null
                object obj = Activator.CreateInstance(type);
                (obj as Form).Parent = pnNombre;
                (obj as Form).Show();



            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a esta opcion");
                
            }






        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            string nombrecompleto = nombrePersona + " " + apellido;
            lblnombreApellido.Text = nombrecompleto;

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
            mtdCerrarFormulario("frmRePersonal");
            
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            frmRol objRol = new frmRol();
            objRol.TopLevel = false;
            objRol.Parent = pnNombre;
            objRol.Show();
            mtdCerrarFormulario("frmRol");
            //mtdVerificaPermisos("frmRol");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte objReporte = new frmReporte();
            objReporte.TopLevel = false;
            objReporte.Parent = pnNombre;
            objReporte.Show();
            mtdCerrarFormulario("frmReporte");
            

        }
    }
}
