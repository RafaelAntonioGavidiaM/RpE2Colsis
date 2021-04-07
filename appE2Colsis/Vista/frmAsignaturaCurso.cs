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
    public partial class frmAsignaturaCurso : Form
    {
        public frmAsignaturaCurso()
        {
            InitializeComponent();
        }
        clAsignaturaCurso objAsignaturaCurso = new clAsignaturaCurso();
        int rows = 0;
        List<clAsignaturaCurso> listaAsignaturas = new List<clAsignaturaCurso>();

        int comprobacion = 0;
        public void mtdComprobarRegistro()
        {

            foreach (var item in listaAsignaturas)
            {

                if (item.nombreAsignatura==cmbAsignatura.Text && item.idCurso==int.Parse(cmbCurso.SelectedValue.ToString()) && item.idPersonal==int.Parse(cmbDocente.SelectedValue.ToString()))
                {
                    MessageBox.Show("Esta Asignacion ya fue registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comprobacion = 1;

                }
                else if (item.nombreAsignatura == cmbAsignatura.Text && item.idCurso == int.Parse(cmbCurso.SelectedValue.ToString()) && item.idPersonal != int.Parse(cmbDocente.SelectedValue.ToString()))
                {
                    MessageBox.Show("Esta Asignacion ya fue registrada  con un docente diferente , modifique la asignacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comprobacion = 1;

                }


            }
        }

        public void mtdEsconderCampos() {
            int contador = 0;
            for (int i = 0; i < dgvAsignaturas.Columns.Count; i++)
            {

                if (contador == 3 || contador == 4 || contador == 6)
                {
                    dgvAsignaturas.Columns[i].Visible = true;

                }
                else
                {
                    dgvAsignaturas.Columns[i].Visible = false;

                }
                contador++;

            }
        }

        public void mtdMostrarOpciones(Control valor)
        {
            Control[] opcionSolicitada = new Control[3];
            opcionSolicitada[0] = btnRegistrar;
            opcionSolicitada[1] = btnModificar;
            opcionSolicitada[2] = btnEliminar;

            for (int i = 0; i < opcionSolicitada.Length; i++)
            {
                if (opcionSolicitada[i] == valor)
                {
                    opcionSolicitada[i].Visible = true;
                    opcionSolicitada[i].Location = new Point(120, 152);


                }
                else
                {
                    opcionSolicitada[i].Visible = false;
                    opcionSolicitada[i].BackColor = TransparencyKey;
                }
            }



        }














        private void cmbCurso_Load(object sender, EventArgs e)
        {
            List<clAsignaturaCurso> listaCursos = new List<clAsignaturaCurso>();
           listaCursos= objAsignaturaCurso.mtdConsultaCursos();
            List<clAsignaturaCurso> listaAsignaturas = new List<clAsignaturaCurso>();
            listaAsignaturas= objAsignaturaCurso.mtdConsultaAsignatura();
            List<clAsignaturaCurso> listaDocente = new List<clAsignaturaCurso>();
            listaDocente = objAsignaturaCurso.mtdConsultarPersonal();
            cmbDocente.DataSource = listaDocente;
            cmbDocente.DisplayMember = "nombreCompleto";
            cmbDocente.ValueMember = "idPersonal";

            cmbCurso.DataSource = listaCursos;
            cmbCurso.DisplayMember = "nombreCurso";
            cmbCurso.ValueMember = "idCurso";
            cmbCursoBuscar.DataSource = listaCursos;
            cmbCursoBuscar.ValueMember = "idCurso";
            cmbCursoBuscar.DisplayMember = "nombreCurso";




            cmbAsignatura.DataSource = listaAsignaturas;
            cmbAsignatura.DisplayMember = "nombreAsignatura";
            cmbAsignatura.ValueMember = "idAsignatura";

            mtdCargarDatagriedview();
            mtdEsconderCampos();


        }

        public void mtdComprobar(int filas)
        {


            if (filas>0)
            {
                MessageBox.Show("Proceso realizado Exitosamente", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo realizar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void mtdCargarDatagriedview()
        {

            try
            {
                objAsignaturaCurso.idCurso = int.Parse(cmbCursoBuscar.SelectedValue.ToString());
            }
            catch (Exception)
            {


            }

           

            listaAsignaturas = objAsignaturaCurso.mtdBuscarAsignaturasCurso();

            dgvAsignaturas.DataSource = listaAsignaturas;
        }

        private void cmbCursoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

            mtdCargarDatagriedview();
            
                

           
            

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            rows = 0;
            mtdComprobarRegistro();
            if (comprobacion==0)
            {
                objAsignaturaCurso.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
                objAsignaturaCurso.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
                objAsignaturaCurso.idPersonal = int.Parse(cmbDocente.SelectedValue.ToString());
                mtdComprobarRegistro();
                rows = objAsignaturaCurso.mtdInsertar();
                mtdComprobar(rows);
                mtdCargarDatagriedview();

            }
            




        }
        int idAsignaturaCurso=0;

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAsignaturas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvAsignaturas.CurrentRow.Selected = true;
                    cmbCurso.SelectedValue = int.Parse(cmbCursoBuscar.SelectedValue.ToString());
                    cmbAsignatura.SelectedValue = int.Parse(dgvAsignaturas.Rows[e.RowIndex].Cells["idAsignatura"].FormattedValue.ToString());
                    cmbDocente.SelectedValue = int.Parse(dgvAsignaturas.Rows[e.RowIndex].Cells["idPersonal"].FormattedValue.ToString());
                    idAsignaturaCurso = int.Parse(dgvAsignaturas.Rows[e.RowIndex].Cells["idAsignaturaCurso"].FormattedValue.ToString());


                }


            }
            catch (Exception)
            {

            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            objAsignaturaCurso.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objAsignaturaCurso.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
            objAsignaturaCurso.idPersonal = int.Parse(cmbDocente.SelectedValue.ToString());
            objAsignaturaCurso.idAsignaturaCurso = idAsignaturaCurso;

          int filasAfectadas=  objAsignaturaCurso.mtdActualizarCurso();
            mtdComprobar(filasAfectadas);
            mtdCargarDatagriedview();




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            rows = 0;
            objAsignaturaCurso.idAsignaturaCurso = idAsignaturaCurso;
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar la Asignacion?", "Respuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta==DialogResult.Yes)
            {
             rows=   objAsignaturaCurso.mtdEliminarAsignacionCurso();
                mtdComprobar(rows);
            }

            mtdCargarDatagriedview();
        }

        private void btnOpcionCrear_Click(object sender, EventArgs e)
        {

            Control valor = btnRegistrar;
            mtdMostrarOpciones(valor);
        }

        private void btnOpcionModificar_Click(object sender, EventArgs e)
        {
            Control valor = btnModificar;
            mtdMostrarOpciones(valor);

        }

        private void btnOpcionEliminar_Click(object sender, EventArgs e)
        {
            Control valor = btnEliminar;
            mtdMostrarOpciones(valor);
        }
    }
}
