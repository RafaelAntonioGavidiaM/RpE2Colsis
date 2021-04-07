﻿using System;
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

        frmLogin objLogin = new frmLogin();
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
                btn.Enabled = true;

            }
            else
            {
                btn.Enabled = false;

            }





        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e) 
        {
            ///Se agregan formularios y botones
            lblnombreApellido.Text = nombrePersona;
            lblApellido.Text= apellido;
            Control[] btn = new Control[10];
            btn[0] = btnPersona;
            btn[1] = btnRol;
            btn[2] = btnReporte;
            btn[3] = btnNotas;
            btn[4] = btnAsignaturas;
            btn[5] = btnEstudiante;
            btn[6] = btnCurso;
            btn[7] = btnAsistencias;
            btn[8] = btnHorario;
            btn[9] = btnPeriodo;

            string[] nombreFormularioV = new string[10];
            nombreFormularioV[0] = "frmRePersonal";
            nombreFormularioV[1] = "frmRol";
            nombreFormularioV[2] = "frmReporte";
            nombreFormularioV[3] = "frmNota";
            nombreFormularioV[4] = "frmAsignatura";
            nombreFormularioV[5] = "frmEstudiante";
            nombreFormularioV[6] = "frmCursos";
            nombreFormularioV[7] = "frmAsistencia";
            nombreFormularioV[8] = "frmHorario";
            nombreFormularioV[9] = "frmPeriodo";





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
            objRePersonal.Parent = btn;
            objRePersonal.Show();
            mtdCerrarFormulario("frmRePersonal");
            
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            frmRol objRol = new frmRol();
            objRol.TopLevel = false;
            objRol.Parent = btn;
            objRol.Show();
            mtdCerrarFormulario("frmRol");
            //mtdVerificaPermisos("frmRol");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte objReporte = new frmReporte();
            objReporte.TopLevel = false;
            objReporte.Parent = btn;
            objReporte.Show();
            mtdCerrarFormulario("frmReporte");
            

        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            frmNota objNota = new frmNota(idPersonal);
            objNota.TopLevel = false;
            objNota.Parent = btn;
            objNota.Show();
            mtdCerrarFormulario("frmNota");


        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            frmEstudiante objEstudiante = new frmEstudiante();
            objEstudiante.TopLevel = false;
            objEstudiante.Parent = btn;
            objEstudiante.Show();
            mtdCerrarFormulario("frmEstudiante");
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            frmAsignatura objAsignaturas = new frmAsignatura();
            objAsignaturas.TopLevel = false;
            objAsignaturas.Parent = btn;
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
            objCurso.Parent = btn;
            objCurso.Show();
            mtdCerrarFormulario("frmCurso");
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            frmAsistencia objAsistencia = new frmAsistencia();
            objAsistencia.TopLevel = false;
            objAsistencia.Parent = btn;
            objAsistencia.Show();
            mtdCerrarFormulario("frmAsistencia");

        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            frmHorario objHorario = new frmHorario();
            objHorario.TopLevel = false;
            objHorario.Parent = btn;
            objHorario.Show();
            mtdCerrarFormulario("frmHorario");
        }

        private void btnCerrrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();          
            objLogin.Show();
            MessageBox.Show("Sesion cerrada correctamente","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objLogin.Close();
            Application.Exit();
        }
    }
}
