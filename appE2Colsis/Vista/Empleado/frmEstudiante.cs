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

namespace appE2Colsis.Vista.Empleado
{
    public partial class frmEstudiante : Form
    {
        private frmListarAcudientes objListarAcudientes;
        private clEstudiante objEstudiante = new clEstudiante();
        private int idAcudiente;
        private int idEstudiante;
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            mtdCargarCmbNivelEducativo();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAcudiente_Click(object sender, EventArgs e)
        {
            objListarAcudientes = new frmListarAcudientes();
            objListarAcudientes.ShowDialog();
            lbAcudiente.Text = objListarAcudientes.documento;
            idAcudiente = objListarAcudientes.idAcudiente;
        }
        private void mtdCargarCmbNivelEducativo()
        {
            objEstudiante.mtdListarNivelEducativo();
            cmbNivelEducativo.DataSource = objEstudiante.tblPersona;
            cmbNivelEducativo.DisplayMember = "curso";

            //cmb 2
            cmbNivelEducativoBuscar.DataSource = objEstudiante.tblPersona;
            cmbNivelEducativoBuscar.DisplayMember = "curso";
        }
        private void mtdCargarCmbCurso()
        {
            objEstudiante.mtdListarCurso(cmbNivelEducativo.Text);
            cmbCurso.DataSource = objEstudiante.tblPersona;
            cmbCurso.DisplayMember = "nombreCurso";
            cmbCurso.ValueMember = "idCurso";
        }
        private void mtdCargarCmbCursoBuscar()
        {
            objEstudiante.mtdListarCurso(cmbNivelEducativoBuscar.Text);
            cmbCursoBuscar.DataSource = objEstudiante.tblPersona;
            cmbCursoBuscar.DisplayMember = "nombreCurso";
            cmbCursoBuscar.ValueMember = "idCurso";
        }
        private void cmbNivelEducativo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mtdCargarCmbCurso();
        }
        private void mtdCargarDatosRegistrarActualizar()
        {
            objEstudiante.idEstudiante = idEstudiante; //
            objEstudiante.nombre = txtNombres.Text; //
            objEstudiante.apellido = txtApellidos.Text; //
            objEstudiante.documento = txtDocumento.Text; //
            objEstudiante.tipoDocumento = cmbTipoDocumento.Text; //
            objEstudiante.fechaNacimiento = dtpFechaNacimiento.Value; //
            objEstudiante.tipoSangre = txtTipoSangre.Text; //
            objEstudiante.seguroEstudiantil = txtSeguroEstudiantil.Text; //
            objEstudiante.telefono = txtTelefono.Text; //
            objEstudiante.idAcudiente = idAcudiente; //
            objEstudiante.idCurso = int.Parse(cmbCurso.SelectedValue.ToString()); //
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (mtdValidarCampos() == true)
            {
                mtdCargarDatosRegistrarActualizar();
                if (objEstudiante.mtdCrearEstudiante() > 0)
                {
                    MessageBox.Show("Estudiante creado correctamente");
                    mtdLimpiarCampos();
                    objEstudiante.mtdBuscarEstudiantePorDocumento();
                    dgvEstudiante.DataSource = objEstudiante.tblPersona;
                }
                else
                {
                    MessageBox.Show("El documento ya existe");
                }
            }
        }
        private Boolean mtdValidarCampos()
        {
            Boolean validarCampos = false;

            if(txtNombres.Text != "" && txtApellidos.Text != "" && txtDocumento.Text != "" && cmbTipoDocumento.Text != "" &&
               txtTipoSangre.Text != "" && txtSeguroEstudiantil.Text != "" && txtTelefono.Text != "" && 
               lbAcudiente.Text != "________________" && cmbCurso.Text != "")
            {
                try 
                {
                    int validarCampoNumerico = int.Parse(txtDocumento.Text);
                    validarCampos = true;
                }
                catch(Exception)
                { MessageBox.Show("Campo Documento de tipo numerico"); }
            }
            else
            {
                MessageBox.Show("Hay campos vacios");
            }

            return validarCampos;
        }

        private void mtdLimpiarCampos()
        {
            txtNombres.Text = "";  
            txtApellidos.Text = ""; 
            txtDocumento.Text = ""; 
            cmbTipoDocumento.SelectedIndex = 0; 
            dtpFechaNacimiento.Value = DateTime.Now; 
            txtTipoSangre.Text = ""; 
            txtSeguroEstudiantil.Text = "";
            txtTelefono.Text = "";
            lbAcudiente.Text = "________________";
            cmbNivelEducativo.SelectedIndex = 0;
            cmbCurso.SelectedIndex = 0;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void cmbNivelEducativoBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mtdCargarCmbCursoBuscar();
        }

        private void cmbCursoBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            objEstudiante.idCurso = int.Parse(cmbCursoBuscar.SelectedValue.ToString());
            objEstudiante.mtdBuscarEstudiantesPorCurso();
            dgvEstudiante.DataSource = objEstudiante.tblPersona;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDocumentoBuscar.Text != "")
            {
                try
                {
                    int validarCampoNumerico = int.Parse(txtDocumentoBuscar.Text);
                    objEstudiante.documento = txtDocumentoBuscar.Text;
                    objEstudiante.mtdBuscarEstudiantePorDocumento();
                    dgvEstudiante.DataSource = objEstudiante.tblPersona;
                }
                catch(Exception)
                {
                    MessageBox.Show("Campo de tipo numerico");
                }
            }
            else
            {
                MessageBox.Show("Campo documento vacio");
            }
        }

        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                idEstudiante = int.Parse(dgvEstudiante.Rows[e.RowIndex].Cells["idEstudiante"].Value.ToString());
                txtNombres.Text = dgvEstudiante.Rows[e.RowIndex].Cells["nombres"].Value.ToString();
                txtApellidos.Text = dgvEstudiante.Rows[e.RowIndex].Cells["apellidos"].Value.ToString();
                txtDocumento.Text = dgvEstudiante.Rows[e.RowIndex].Cells["documento"].Value.ToString();
                cmbTipoDocumento.Text = dgvEstudiante.Rows[e.RowIndex].Cells["tipoDocumento"].Value.ToString();
                dtpFechaNacimiento.Value = DateTime.Parse(dgvEstudiante.Rows[e.RowIndex].Cells["fechaNacimiento"].Value.ToString());
                txtTipoSangre.Text = dgvEstudiante.Rows[e.RowIndex].Cells["tipoSangre"].Value.ToString();
                txtSeguroEstudiantil.Text = dgvEstudiante.Rows[e.RowIndex].Cells["seguroEstudiantil"].Value.ToString();
                txtTelefono.Text = dgvEstudiante.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                lbAcudiente.Text = dgvEstudiante.Rows[e.RowIndex].Cells["CC_Acudiente"].Value.ToString();
                idAcudiente = int.Parse(dgvEstudiante.Rows[e.RowIndex].Cells["idAcudiente"].Value.ToString());
                cmbNivelEducativo.Text = dgvEstudiante.Rows[e.RowIndex].Cells["nivelEducativo"].Value.ToString();
                mtdCargarCmbCurso();
                cmbCurso.Text = dgvEstudiante.Rows[e.RowIndex].Cells["curso"].Value.ToString();

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            catch(Exception)
            { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (mtdValidarCampos() == true)
            {
                mtdCargarDatosRegistrarActualizar();
                if (objEstudiante.mtdActualizarEstudiante() > 0)
                {
                    MessageBox.Show("Estudiante actualizado correctamente");
                    objEstudiante.mtdBuscarEstudiantePorDocumento();
                    dgvEstudiante.DataSource = objEstudiante.tblPersona;
                    mtdLimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar estudiante");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el estudiante?", "Eliminar Estudiante", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mtdCargarDatosRegistrarActualizar();
                if (objEstudiante.mtdEliminarEstudiante() > 0)
                {
                    MessageBox.Show("Estudiante eliminado correctamente");
                    mtdLimpiarCampos();
                    dgvEstudiante.DataSource = "";
                }
                else
                {
                    MessageBox.Show("Error al eliminar estudiante");
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada");
            }
        }
    }
}
