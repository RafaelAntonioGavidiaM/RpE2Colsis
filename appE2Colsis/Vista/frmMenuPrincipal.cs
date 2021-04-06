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
using appE2Colsis.Vista.Empleado;
using System.IO;


namespace appE2Colsis.Vista
{
    public partial class frmMenuPrincipal : Form
    {
        public int idRol { get; set; }
        public string nombrePersona { get; set; }

        public string apellido { get; set; }
        public int idPersonal { get; set; }

        public string foto { get; set; }

        public frmMenuPrincipal(int idRol,string nombrePersona,string apellido, int idPersonal, string foto)
        {
            this.idRol = idRol;
            this.nombrePersona = nombrePersona;
            this.apellido = apellido;
            this.idPersonal = idPersonal;
            this.foto = foto;

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

        public void mtdVerificaPermisos(string nombreFormulario,Control btn)// Este metodo verificará los permisos que el usuario tiene para el ingreso al programa 
        {
            clRol objRol = new clRol();
          int registros=  objRol.mtdAccesoModulos(idPersonal, nombreFormulario);

            if (registros>0) //permisos segun boton
            {
                btn.Visible = true;

            }
            else
            {
                btn.Visible = false;

            }





        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e) 
        {
            ///Se agregan formularios y botones
            lblnombreApellido.Text = nombrePersona;
            lblApellido.Text= apellido;
            Control[] btn = new Control[3];
            btn[0] = btnPersona;
            btn[1] = btnRol;
            btn[2] = btnReporte;

            string[] nombreFormularioV = new string[3];
            nombreFormularioV[0] = "frmRePersonal";
            nombreFormularioV[1] = "frmRol";
            nombreFormularioV[2] = "frmReporte";

            for (int i = 0; i < nombreFormularioV.Length; i++)
            {
                mtdVerificaPermisos(nombreFormularioV[i], btn[i]);
            }

            try
            {
                string ruta = Directory.GetCurrentDirectory() + "\\fotosPersonal\\" + foto;
                pbfoto.Load(ruta);

            }
            catch (Exception)
            {

               
            }
            



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

        private void btnNotas_Click(object sender, EventArgs e)
        {
            frmNota objNota = new frmNota(idPersonal);
            objNota.TopLevel = false;
            objNota.Parent = pnNombre;
            objNota.Show();
            mtdCerrarFormulario("frmNota");


        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            frmEstudiante objEstudiante = new frmEstudiante();
            objEstudiante.TopLevel = false;
            objEstudiante.Parent = pnNombre;
            objEstudiante.Show();
            mtdCerrarFormulario("frmEstudiante");
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            frmAsignatura objAsignaturas = new frmAsignatura();
            objAsignaturas.TopLevel = false;
            objAsignaturas.Parent = pnNombre;
            objAsignaturas.Show();
            mtdCerrarFormulario("frmAsignatura");
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            frmPeriodo objPeriodo = new frmPeriodo();
            objPeriodo.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            frmCurso objCurso = new frmCurso();
            objCurso.TopLevel = false;
            objCurso.Parent = pnNombre;
            objCurso.Show();
            mtdCerrarFormulario("frmCurso");
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            frmAsistencia objAsistencia = new frmAsistencia();
            objAsistencia.TopLevel = false;
            objAsistencia.Parent = pnNombre;
            objAsistencia.Show();
            mtdCerrarFormulario("frmAsistencia");

        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            frmHorario objHorario = new frmHorario();
            objHorario.TopLevel = false;
            objHorario.Parent = pnNombre;
            objHorario.Show();
            mtdCerrarFormulario("frmHorario");
        }
    }
}
