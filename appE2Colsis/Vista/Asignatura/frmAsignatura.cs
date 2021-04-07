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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        clAsignatura objAsignatura;
        clAsignatura objArea;
        List<clAsignatura> listAsignatura;
        List<clAsignatura> listArea;

        private void frmAsignatura_Load(object sender, EventArgs e)
        {
            mtdcargar();
            dgvAsignatura.Columns["nombreArea"].Visible = false;
            dgvArea.Columns["idAsignatura"].Visible = false;
            dgvArea.Columns["nombreAsignatura"].Visible = false;

            txtId.Enabled = false;
            txtIdArea.Enabled = false;
        }

        public void mtdcargar()
        {
            // tabla de asignatura
            listAsignatura = new List<clAsignatura>();
            objAsignatura = new clAsignatura();
            listAsignatura = objAsignatura.mtdListarAsignatura();
            dgvAsignatura.DataSource = listAsignatura;

            objAsignatura = new clAsignatura();
            listAsignatura = new List<clAsignatura>();
            listAsignatura = objAsignatura.mtdListarArea();
            cmbArea.DataSource = listAsignatura;
            cmbArea.DisplayMember = "nombreArea";
            cmbArea.ValueMember = "idArea";


            // tabla de area
            listArea = new List<clAsignatura>();
            objArea = new clAsignatura();
            listArea = objArea.mtdListarArea();
            dgvArea.DataSource = listArea;


            // Filtro

            objAsignatura = new clAsignatura();
            listAsignatura = new List<clAsignatura>();
            listAsignatura = objAsignatura.mtdListarArea();
            cmbFiltroArea.DataSource = listAsignatura;
            cmbFiltroArea.DisplayMember = "nombreArea";
            cmbFiltroArea.ValueMember = "idArea";

            //Ocultar campos consulta
            dgvAsignatura.Columns["nombreArea"].Visible = false;
            dgvArea.Columns["idAsignatura"].Visible = false;
            dgvArea.Columns["nombreAsignatura"].Visible = false;

        }

        //metodos y del groupbox de registro de asignatura 

        public void mtdCargarDatosAsignatura()
        {
            objAsignatura.nombreAsignatura = txtAsignatura.Text;
            objAsignatura.idArea = int.Parse(cmbArea.SelectedValue.ToString());
        }

        private void dgvAsignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                idAsignatura = int.Parse(dgvAsignatura.Rows[e.RowIndex].Cells["idAsignatura"].FormattedValue.ToString());


                dgvAsignatura.CurrentRow.Selected = true;
                txtId.Text = dgvAsignatura.Rows[e.RowIndex].Cells["idAsignatura"].FormattedValue.ToString();
                txtAsignatura.Text = dgvAsignatura.Rows[e.RowIndex].Cells["nombreAsignatura"].FormattedValue.ToString();
                cmbArea.Text = dgvAsignatura.Rows[e.RowIndex].Cells["idArea"].FormattedValue.ToString();

                string area = dgvAsignatura.Rows[e.RowIndex].Cells["idArea"].FormattedValue.ToString();

                for (int i = 0; i < listAsignatura.Count; i++)
                {
                    if (listAsignatura[i].idArea == int.Parse(area))
                    {
                        cmbArea.Text = listArea[i].nombreArea;
                    }

                }
            }
            catch (Exception)
            {
            }

        }

        private void btnRegistarAsignatura_Click(object sender, EventArgs e)
        {
            mtdCargarDatosAsignatura();
            DialogResult opcion = MessageBox.Show("Desea registrar una nueva asignatura ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (opcion == DialogResult.Yes)
            {
                int registro = objAsignatura.mtdRegistrarAsignatura();

                if (registro > 0)
                {

                    MessageBox.Show("Se regsitro la asignatura correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdcargar();
                    mtdBorrarTxt();

                }
                else
                {
                    MessageBox.Show("El nombre de asignatura ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        int idAsignatura = 0;
        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(" Desea eliminar la asignatura", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion == DialogResult.Yes)
            {
                int filasAfectadas = objAsignatura.mtdEliminarAsignatura(idAsignatura);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se elimino  la asignatura correctamente", "Eliminaddo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdcargar();
                    mtdBorrarTxt();
                }
                else
                {
                    MessageBox.Show("No se puedo hacer la eliminacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnModificarAsignatura_Click(object sender, EventArgs e)
        {
            objAsignatura.idAsignatura = idAsignatura;
            objAsignatura.nombreAsignatura = txtAsignatura.Text;
            objAsignatura.idArea = int.Parse(cmbArea.SelectedValue.ToString());

            if (objAsignatura.mtdModificarAsignatura() > 0)
            {
                MessageBox.Show("Actualizacion exitoso");
                mtdcargar();
                mtdBorrarTxt();
            }
            else
            {
                MessageBox.Show("El nombre de Asignatura ya existe");
            }
        }

        // metodos y groupbox de area

        public void mtdCargarDatosArea()
        {
            objArea = new clAsignatura();
            objArea.nombreArea = txtArea.Text;
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idArea = int.Parse(dgvArea.Rows[e.RowIndex].Cells["idArea"].FormattedValue.ToString());
            if (dgvArea.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvArea.CurrentRow.Selected = true;
                txtIdArea.Text = dgvArea.Rows[e.RowIndex].Cells["idArea"].FormattedValue.ToString();
                txtArea.Text = dgvArea.Rows[e.RowIndex].Cells["nombreArea"].FormattedValue.ToString();
            }

        }

        private void btnRegistrarArea_Click(object sender, EventArgs e)
        {
            mtdCargarDatosArea();
            DialogResult opcion = MessageBox.Show("Desea registrar una nueva area ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (opcion == DialogResult.Yes)
            {
                if (objArea.mtdRegistrarArea() > 0)
                {

                    MessageBox.Show("Se regsitro el area correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdcargar();
                    mtdBorrarTxt();

                }
                else
                {
                    MessageBox.Show("El area ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        int idArea = 0;
        private void btnEliminarArea_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(" Desea eliminar el area", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion == DialogResult.Yes)
            {
                int filasAfectadas = objArea.mtdEliminarArea(idArea);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se elimino el area correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdcargar();
                    mtdBorrarTxt();
                }
                else
                {
                    MessageBox.Show("No se puedo hacer la eliminacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnModificarArea_Click(object sender, EventArgs e)
        {

            objArea.idArea = int.Parse(txtIdArea.Text);
            objArea.nombreArea = txtArea.Text;
                   
            if (objArea.mtdModificarArea() > 0)
            {
                MessageBox.Show("Actualizacion exitoso");
                mtdcargar();
                mtdBorrarTxt();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar");
            }

        }

        private void cmbFiltroArea_SelectionChangeCommitted(object sender, EventArgs e)
        {

            objAsignatura = new clAsignatura();
            objAsignatura.idArea = int.Parse(cmbFiltroArea.SelectedValue.ToString());
            objAsignatura.mtdBuscarAsignaturaPorArea();
            dgvAsignatura.DataSource = objAsignatura.tblAsignatura;
        }


        private void btnRecargar_Click(object sender, EventArgs e)
        {
            mtdcargar();
        }

        // metdos de limpieza de textBox

        public void mtdBorrarTxt()
        {
            txtAsignatura.Clear();
            txtArea.Clear();
            txtId.Clear();
            txtIdArea.Clear();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmAsignaturaCurso objAsignaturaCurso = new frmAsignaturaCurso();
            objAsignaturaCurso.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
