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
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        clAsistencia objAsistencia = new clAsistencia();
        clAsistencia objFecha = new clAsistencia();
        clAsistencia objFiltro = new clAsistencia();
        int idAsignaturaCuso = 0;
        int idAsistencia = 0;
        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            mtdCargarComboBox();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
                
        }

        public void mtdEsconderCampos()
        {

            dgvAsistencia.Columns["idDocente"].Visible = false;
            dgvAsistencia.Columns["idCurso"].Visible = false;
            dgvAsistencia.Columns["idAsignatura"].Visible = false;
            dgvAsistencia.Columns["idAsistencia"].Visible = false;
            dgvAsistencia.Columns["fechaHoras2"].Visible = false;
            dgvAsistencia.Columns["idAsignaturaCurso"].Visible = false;


        }

        public void mtdCargarComboBox()
        {
            List<clAsistencia> listaCursos = new List<clAsistencia>();
            listaCursos = objAsistencia.mtdConsultarCursos();
            cmbCurso.DataSource = listaCursos;
            cmbCurso.DisplayMember = "nombreCurso";
            cmbCurso.ValueMember = "idCurso";
            cmbCursoFiltro.DataSource = listaCursos;
            cmbCursoFiltro.DisplayMember = "nombreCurso";
            cmbCursoFiltro.ValueMember = "idCurso";
        }

        public void mtdCargarFechas()
        {
            int asignatura = 0;
            int curso = int.Parse(cmbCursoFiltro.SelectedValue.ToString());
            try
            {
                asignatura = int.Parse(cmbFiltroAsignatura.SelectedValue.ToString());
            }
            catch (Exception)
            {
            }

            List<clAsistencia> listaFecha = new List<clAsistencia>();
            listaFecha = objFecha.mtdConsultarFechaSegunCursoAsignatura(curso, asignatura);
            cmbFechaFiltro.DataSource = listaFecha;
            cmbFechaFiltro.DisplayMember = "fechaHoras2";
            cmbFechaFiltro.ValueMember = "idAsistencia";

        }

        public void mtdCargarDgvAsisgnatura()
        {
            List<clAsistencia> listaAsignatura = new List<clAsistencia>();
            objAsistencia = new clAsistencia();
            listaAsignatura = objAsistencia.mtdListarAsistencia();
            dgvAsistencia.DataSource = listaAsignatura;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objAsistencia.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
                List<clAsistencia> listaAsignaturas = new List<clAsistencia>();
                listaAsignaturas = objAsistencia.mtdConsultarAsignaturasSegunCurso();
                cmbAsignatura.DataSource = listaAsignaturas;
                cmbAsignatura.DisplayMember = "nombreAsignatura";
                cmbAsignatura.ValueMember = "idAsignatura";

            }
            catch (Exception)
            {


            }


        }

        public void mtdComprobar(int rows)
        {
            if (rows > 0)
            {
                MessageBox.Show("Se realizo registro exitosamente", "Succeful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTomarAsistencia_Click(object sender, EventArgs e)
        {

            objAsistencia.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objAsistencia.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
            int filasAfectadas = objAsistencia.mtdInsertarAsistencia();
            mtdComprobar(filasAfectadas);
            List<clAsistencia> listAsistencia = new List<clAsistencia>();
            listAsistencia = objAsistencia.mtdListarAsistencia();
            dgvAsistencia.DataSource = listAsistencia;
            mtdEsconderCampos();
        }

        private void cmbCursoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objAsistencia.idCurso = int.Parse(cmbCursoFiltro.SelectedValue.ToString());
                List<clAsistencia> listAsignaturaFiltro = new List<clAsistencia>();
                listAsignaturaFiltro = objAsistencia.mtdConsultarAsignaturasSegunCurso();
                cmbFiltroAsignatura.DataSource = listAsignaturaFiltro;
                cmbFiltroAsignatura.DisplayMember = "nombreAsignatura";
                cmbFiltroAsignatura.ValueMember = "idAsignatura";
            }
            catch (Exception)
            {


            }
        }

        public void mtdFiltrarAsistencia()
        {
            List<clAsistencia> listAsistencia = new List<clAsistencia>();
            listAsistencia = objAsistencia.mtdBuscarAsistencia();
            dgvAsistencia.DataSource = listAsistencia;
        }

        public void mtdRecargarAsistencia()
        {
            List<clAsistencia> listAsistencia = new List<clAsistencia>();
            listAsistencia = objAsistencia.mtdBuscarAsistencia();
            dgvAsistencia.DataSource = listAsistencia;
        }

        private void btnBuscarAsistencia_Click(object sender, EventArgs e)
        {
            string fecha = cmbFechaFiltro.Text;
            objAsistencia.fechaHora = DateTime.Parse(fecha);
            objAsistencia.idAsignatura = int.Parse(cmbFiltroAsignatura.SelectedValue.ToString());
            mtdRecargarAsistencia();
            mtdEsconderCampos();
            
        }



        private void cmbFiltroAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtdCargarFechas();
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                idAsistencia = int.Parse(dgvAsistencia.Rows[e.RowIndex].Cells["idAsistencia"].FormattedValue.ToString());
                idAsignaturaCuso = int.Parse(dgvAsistencia.Rows[e.RowIndex].Cells["idAsignaturaCurso"].FormattedValue.ToString());
                dgvAsistencia.CurrentRow.Selected = true;
                txtNombre.Text = dgvAsistencia.Rows[e.RowIndex].Cells["nombres"].FormattedValue.ToString();
                txtApellido.Text = dgvAsistencia.Rows[e.RowIndex].Cells["apellidos"].FormattedValue.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnAsistio_Click(object sender, EventArgs e)
        {
            string asistio = "Asistio";
            objAsistencia.idAsistencia = idAsistencia;
            objAsistencia.mtdAsistioFalto(asistio);
            mtdRecargarAsistencia();
        }

        private void btnFalto_Click(object sender, EventArgs e)
        {
            string falto = "Falto";
            objAsistencia.idAsistencia = idAsistencia;
            objAsistencia.mtdAsistioFalto(falto);
            mtdRecargarAsistencia();
        }
    }
}
