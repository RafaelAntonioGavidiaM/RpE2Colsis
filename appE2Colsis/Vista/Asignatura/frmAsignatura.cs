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



        }

        //metodos y groupbox de regustro de asignatura 

        public void  mtdCargarDatosAsignatura()
        {
            listAsignatura = new List<clAsignatura>();

            for (int i = 0; i < 1; i++)
            {
                clAsignatura objDatosAsignatura = new clAsignatura();
                objAsignatura.nombreAsignatura = txtAsignatura.Text;
                objAsignatura.idArea = int.Parse(cmbArea.SelectedValue.ToString());

                listAsignatura.Add(objAsignatura);
            }

        }
        int idMateria = 0;
        private void dgvAsignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsignatura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                
                dgvAsignatura.CurrentRow.Selected = true;
                idMateria = int.Parse(dgvAsignatura.Rows[e.RowIndex].Cells["idAsignatura"].FormattedValue.ToString());
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

                }
                else
                {
                    MessageBox.Show("No se pudo hacer el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        int idAsignatura = 0;
        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(" Desea eliminar la asignatura"," Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion == DialogResult.OK)
            {
                int filasAfectadas = objAsignatura.mtdEliminarAsignatura(idAsignatura);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se elimino  la asignatura correctamente", "Elimado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdcargar();
                }
                else
                {
                    MessageBox.Show("No se puedo hacer la eliminacion", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }

            }
        }

        private void btnModificarAsignatura_Click(object sender, EventArgs e)
        {
            listAsignatura = new List<clAsignatura>();
            listAsignatura = objAsignatura.mtdListarAsignatura();
            int contador = 0;
            for (int i = 0; i < listAsignatura.Count; i++)
            {
                if (listAsignatura[i].nombreAsignatura == txtAsignatura.Text && cmbArea.SelectedValue.Equals(listAsignatura[i].idArea))
                {
                    MessageBox.Show("No se registro ningun cambio", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    contador = contador + 1;
                }
            }
            if (contador != 0)
            {
                MessageBox.Show("Verifique la informacion que desea modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objAsignatura.idAsignatura = idAsignatura;
                objAsignatura.nombreAsignatura = txtAsignatura.Text;
                objAsignatura.idArea = int.Parse(cmbArea.SelectedValue.ToString());

                objAsignatura.mtdModificarAsignatura();
                int filas = objAsignatura.mtdModificarAsignatura();

                if (filas > 0)
                {
                    MessageBox.Show("Actualizacion exitoso");
                    mtdcargar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
        }
    }
}
