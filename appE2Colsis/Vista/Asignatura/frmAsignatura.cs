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
        List<clAsignatura> listReAsignatura;

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

        private void dgvAsignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRegistarAsignatura_Click(object sender, EventArgs e)
        {
            mtdCargarDatosAsignatura();
            DialogResult opcion = MessageBox.Show("Desea registrar una nueva asignatura ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (opcion == DialogResult.Yes)
            {
                int registro = objAsignatura.mtdRegistrarAsignatura(listReAsignatura);

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
    }
}
