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
    public partial class frmHorario : Form
    {
        public frmHorario()
        {
            InitializeComponent();
        }
        clHorario objHorario = new clHorario();
        List<clHorario> listaFiltro = new List<clHorario>(); // lista de filtro
        string[] dias = new string[7];
        List<clHorario> listaHorario = new List<clHorario>();
        int rowsAfectada = 0;

        public void mtdMostrarOpciones(Control valor, Control btnR)
        {
            Control[] opcionSolicitada = new Control[3];
            opcionSolicitada[0] = cmbDia;
            opcionSolicitada[1] = cmbModificarDia;
            opcionSolicitada[2] = cmbModificarDia;


            Control[] btn = new Control[3];
            btn[0] = btnRegistrar;
            btn[1] = btnModificar;
            btn[2] = btnEliminar;

            for (int i = 0; i < opcionSolicitada.Length; i++)
            {
               
                if (opcionSolicitada[i] == valor && btn[i]==btnR)
                {
                    opcionSolicitada[i].Visible = true;
                    opcionSolicitada[i].Location = new Point(103, 114);
                    btn[i].Visible = true;
                    btn[i].Location = new Point(86, 253);

                    

                }
                else
                {
                    opcionSolicitada[i].Visible = false;
                    opcionSolicitada[i].BackColor = TransparencyKey;
                    btn[i].Visible = false;
                    btn[i].BackColor = TransparencyKey;
                }
            }


            if (btnRegistrar.Visible == true)
            {
                cmbDia.Visible = true;

            }
            if (btnModificar.Visible == true)
            {
                cmbModificarDia.Visible = true;

               
            }

        }


        private void frmHorario_Load(object sender, EventArgs e)
        {

            dias[0] = "Domingo";
            dias[1] = "Lunes";
            dias[2] = "Martes";
            dias[3] = "Miercoles";
            dias[4] = "Jueves";
            dias[5] = "Viernes";
            dias[6] = "Sabado";

            cmbDia.DataSource = dias;

            List<clHorario> lista = new List<clHorario>();
            lista = objHorario.mtdConsultarCursos();
            cmbCurso.DataSource = lista;
            cmbCurso.DisplayMember = "nombreCurso";
            cmbCurso.ValueMember = "idCurso";
            cmbCursoFiltrar.DataSource = lista;
            cmbCursoFiltrar.DisplayMember = "nombreCurso";
            cmbCursoFiltrar.ValueMember = "idCurso";


            //Agregar Horas al Grid
            for (int i = 0; i <= 11; i++)
            {
                dgvResultado.Rows.Add();

                string hora = (i + 6).ToString() + " - " + (i + 7).ToString();
                dgvResultado.Rows[i].Cells[0].Value = hora;


            }
            Control valor = cmbDia;
            Control btn = btnRegistrar;
            mtdMostrarOpciones(valor,btn);


        }

        public void mtdComprobar()
        {
            if (rowsAfectada > 0)
            {
                MessageBox.Show("Se realizo el proceso exitosamente", "Succesul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void cmbCurso_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
                List<clHorario> listaAsignaturas = new List<clHorario>();
                listaAsignaturas = objHorario.mtdConsultarAsignaturasSegunCurso();
                cmbAsignatura.DataSource = listaAsignaturas;
                cmbAsignatura.DisplayMember = "nombreAsignatura";
                cmbAsignatura.ValueMember = "idAsignatura";
            }
            catch (Exception)
            {


            }

        }

        private void cmbAsignatura_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                objHorario.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
                objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());

                listaHorario = objHorario.mtConsultadModificar();
                cmbModificarDia.DataSource = listaHorario;
                cmbModificarDia.DisplayMember = "dia";

            }
            catch (Exception)
            {

            }

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            try
            {
                objHorario.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
           
            objHorario.dia = cmbDia.Text;
            objHorario.horaIncio = txthInicio.Text;
            objHorario.horaFinal = txthFinal.Text;
            int rows = objHorario.mtdInsertarHorario();
            if (rows > 0)
            {
                MessageBox.Show("Se realizo registro Exitoso", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mtdRecargarHorario();

        }
        public void mtdRecargarHorario()
        {

            //       try
            //       {
            try
            {
                objHorario.idCurso = int.Parse(cmbCursoFiltrar.SelectedValue.ToString());
            }
            catch (Exception)
            {


            }

            listaFiltro.Clear();
            listaFiltro = objHorario.mtdFiltarHorariosCurso();
            string dia = ""; string hI = ""; string hF = "";
            string[] horario = new string[] { "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18" }; //llenar vector

            int posicionfila = -1;
            int posicionColumna = -1;
            dgvResultado.Rows.Clear();
            for (int i = 0; i <= 11; i++)
            {
                dgvResultado.Rows.Add();

                string hora = (i + 6).ToString() + " - " + (i + 7).ToString();
                dgvResultado.Rows[i].Cells[0].Value = hora;


            }
            for (int i = 0; i < listaFiltro.Count; i++)
            {
                dia = listaFiltro[i].dia;
                hI = listaFiltro[i].horaIncio;
                hI = hI.Substring(0, 2);
                for (int j = 0; j <= 11; j++)
                {
                    if (hI == horario[j])
                    {
                        posicionfila = j;
                    }
                }
                for (int z = 0; z < 7; z++)
                {
                    if (listaFiltro[i].dia == dias[z])
                    {
                        posicionColumna = z;
                    }
                }
                dgvResultado.Rows[posicionfila + 1].Cells[posicionColumna].Value = listaFiltro[i].nombreAsignatura;
            }
            // }
            /*catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }*/



        }






        private void cmbCursoFiltrar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mtdRecargarHorario();

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objHorario.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
            objHorario.dia = cmbModificarDia.Text;
            objHorario.horaIncio = txthInicio.Text;
            objHorario.horaFinal = txthFinal.Text;

            rowsAfectada = objHorario.mtdModificar();
            mtdComprobar();
            mtdRecargarHorario();
        }

        private void cmbModificarDia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (var item in listaHorario)
            {
                if (item.dia == cmbModificarDia.Text)
                {
                    txthInicio.Text = item.horaIncio;
                    txthFinal.Text = item.horaFinal;
                }

            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objHorario.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());

            rowsAfectada = objHorario.mtdEliminar();
            mtdComprobar();
            mtdRecargarHorario();

        }

        private void btnOpcionCrear_Click(object sender, EventArgs e)
        {
            Control valor = cmbDia;
            Control btn = btnRegistrar;
            mtdMostrarOpciones(valor,btn);

        }

        private void btnOpcionModificar_Click(object sender, EventArgs e)
        {
            Control valor = cmbModificarDia;
            Control btn = btnModificar;
            mtdMostrarOpciones(valor,btn);

        }

        private void btnOpcionEliminar_Click(object sender, EventArgs e)
        {

            Control valor = cmbModificarDia;
            Control btn = btnEliminar;
            mtdMostrarOpciones(valor,btn);

        }
    }
}
