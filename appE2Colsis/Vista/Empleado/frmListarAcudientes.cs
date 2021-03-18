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
    public partial class frmListarAcudientes : Form
    {
        public int idAcudiente = 0;
        public string documento = "________________";
        private clAcudiente objAcudiente = new clAcudiente();
        public frmListarAcudientes()
        {
            InitializeComponent();
        }
        private void frmListarAcudientes_Load(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = false;
        }
        private Boolean mtdValidarCampo()
        {
            Boolean validarCampo = false;
            if (txtCedula.Text != "")
            {
                try { int validarCampoNumerico = int.Parse(txtCedula.Text); validarCampo = true; }
                catch (Exception) { MessageBox.Show("Campo numerico"); }
            }
            else
            {
                MessageBox.Show("Campo Vacio");
            }
            return validarCampo;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtdValidarCampo() == true)
            {
                objAcudiente.documento = txtCedula.Text;
                if (objAcudiente.mtdBuscar() > 0)
                {
                    btnSeleccionar.Enabled = true;
                    idAcudiente = objAcudiente.idAcudiente;
                    documento = objAcudiente.documento;
                }
                else
                {
                    MessageBox.Show("Acudiente no encontrado");
                    btnSeleccionar.Enabled = false;
                }
                dgvAcudiente.DataSource = objAcudiente.tblPersona;
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
