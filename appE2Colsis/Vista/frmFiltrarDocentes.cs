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
    public partial class frmFiltrarDocentes : Form
    {
        //Atributos de solo lectura
        public int idDocente = 0;
        public string NombreDocente = "";

        clDocente objDocente = new clDocente();
        public frmFiltrarDocentes()
        {
            InitializeComponent();
        }

        private void frmFiltrarDocentes_Load(object sender, EventArgs e)
        {
            objDocente.mtdListarDocentes();
            dvgDocentes.DataSource = objDocente.tblPersona;
        }
        private Boolean mtdValidarCampo()
        {
            Boolean validarCampo = false;
            if (txtDocumento.Text != "")
            {
                try
                {
                    int validarNumerico = int.Parse(txtDocumento.Text);
                    validarCampo = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(" El Campo Documento debe ser de tipo Numerico ");
                }
            }
            else
            {
                MessageBox.Show("El campo documento esta Vasio");

            }
            return validarCampo;
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtdValidarCampo() == true)
            {
                objDocente.documento = txtDocumento.Text;
                objDocente.mtdBuscarDocentePorDocumento();
                if (objDocente.tblPersona.Rows.Count > 0)
                {
                    dvgDocentes.DataSource = objDocente.tblPersona;
                }
                else
                {
                    MessageBox.Show("No existe Docente");
                }
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            objDocente.mtdListarDocentes();
            dvgDocentes.DataSource = objDocente.tblPersona;
        }

        private void dvgDocentes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                idDocente = int.Parse(dvgDocentes.Rows[e.RowIndex].Cells["idPersonal"].Value.ToString());
                NombreDocente = dvgDocentes.Rows[e.RowIndex].Cells["NombreDocente"].Value.ToString();
                this.Hide();
            }
            catch (Exception) {}
        }
    }
}
