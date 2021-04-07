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
    public partial class frmCurso : Form
    {
        frmFiltrarDocentes objFiltrarDocentes;
        public frmCurso()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        clCursos objCursoss = new clCursos();
        List<clCursos> listCursoss = new List<clCursos>();
        clPersona objPersonas = new clPersona();

        private void frmCursos_Load(object sender, EventArgs e)
        {
            txtDocente.Enabled = false;
            mtdCargarCmbCursos();
        }
        private void mtdCargarCmbCursos()
        {
            objCursoss.mtdCargarCursos();
            cmbNivelEducativo.DataSource = objCursoss.dtCursos;
            cmbNivelEducativo.DisplayMember = "curso";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (mtdValidarCampos() == true)
            {
                objCursoss.curso = txtCurso.Text;
                objCursoss.nombreCurso = txtNombreC.Text;
                objCursoss.año = txtAño.Text;
                objCursoss.idPersonal = idDocente;


                int RegistrosAfectados = objCursoss.mtdRegistrar();

                if (RegistrosAfectados > 0)
                {
                    MessageBox.Show("Curso correctamente Registrado!!!", "curso", MessageBoxButtons.OK);
                    mtdLimpiarCampos();
                    mtdRecargaGrilla();
                }
                else
                {
                    MessageBox.Show("El nombre de curso ya existe para el año digitado", "curso", MessageBoxButtons.OK);
                }
            }
        }

        private Boolean mtdValidarCampos()
        {
            Boolean ValidarCampos = false;
            if (txtCurso.Text != "" && txtNombreC.Text != "" && txtAño.Text !=""  && txtDocente.Text !="")
            {
                try
                {
                    int ValidaNumero = int.Parse(txtCurso.Text);
                    ValidarCampos = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("El Campo Curso  debe ser de tipo numerico");
                }

            }
            else
            {
                MessageBox.Show("Hay campos vacios");
            }
            return ValidarCampos;
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mtdValidarCampos() == true)
            {
                objCursoss.curso = txtCurso.Text;
                objCursoss.nombreCurso = txtNombreC.Text;
                objCursoss.año = txtAño.Text;
                objCursoss.idPersonal = idDocente;
                objCursoss.idCurso = idCurso;

                if (objCursoss.mtdActualizarCurso() > 0)
                {
                    MessageBox.Show("El Curso se actualizo Correctamente","Actualizacion", MessageBoxButtons.OK);
                    mtdLimpiarCampos();
                    mtdRecargaGrilla();
                }
                else
                {
                    MessageBox.Show("El nombre de curso ya existe para el año digitado", "Actualizacion", MessageBoxButtons.OK);
                }
               
            }
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            objFiltrarDocentes = new frmFiltrarDocentes();
            objFiltrarDocentes.ShowDialog();
            txtDocente.Text = objFiltrarDocentes.NombreDocente;
            idDocente = objFiltrarDocentes.idDocente;
        }

        private void cmbNivelEducativo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            objCursoss.mtdFiltrarCursos(cmbNivelEducativo.Text);
            dvgCursos.DataSource = objCursoss.dtCursos;
            dvgCursos.Columns["idCurso"].Visible = false;
            dvgCursos.Columns["idDocente"].Visible = false;

        }
        private int idDocente;
        private int idCurso;
        private void dvgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreC.Text = dvgCursos.Rows[e.RowIndex].Cells["nombreCurso"].Value.ToString();
                txtCurso.Text = dvgCursos.Rows[e.RowIndex].Cells["curso"].Value.ToString();
                txtAño.Text = dvgCursos.Rows[e.RowIndex].Cells["año"].Value.ToString();
                txtDocente.Text = dvgCursos.Rows[e.RowIndex].Cells["NombreDocente"].Value.ToString();
                idDocente = int.Parse(dvgCursos.Rows[e.RowIndex].Cells["idDocente"].Value.ToString());
                idCurso = int.Parse(dvgCursos.Rows[e.RowIndex].Cells["idCurso"].Value.ToString());

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch (Exception)
            {

            }
        }
        private void mtdLimpiarCampos()
        {
            txtNombreC.Text = "";
            txtCurso.Text = "";
            txtAño.Text = "";
            txtDocente.Text = "";
            idDocente = 0;
            idCurso = 0;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objCursoss.idCurso = idCurso;
            if(objCursoss.mtdEliminarCurso() > 0)
            {
                MessageBox.Show("El Curso se ha eliminado correctamente", "Eliminar", MessageBoxButtons.OK);
                mtdLimpiarCampos();
                mtdRecargaGrilla();
            }
            else
            {
                MessageBox.Show("Error al Actualizar Curso ", "Eliminar", MessageBoxButtons.OK);
            }
        }
        private void mtdRecargaGrilla()
        {
            objCursoss.mtdRefrescarGrilla();
            dvgCursos.DataSource = objCursoss.dtCursos;
            dvgCursos.Columns["idCurso"].Visible = false;
            dvgCursos.Columns["idDocente"].Visible = false;
        }

      
    }
}
