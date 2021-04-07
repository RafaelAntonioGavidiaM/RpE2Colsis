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
    public partial class frmPeriodo : Form
    {
        public frmPeriodo()
        {
            InitializeComponent();
        }

        clPeriodo objPeriodo = new clPeriodo();
        List<clPeriodo> listaPeriodos = new List<clPeriodo>();


        public void mtdCargarCampos()
        {
            objPeriodo.nombrePeriodo = txtNombre.Text;
            objPeriodo.fechaI = DateTime.Parse(dtpInicio.Text).ToString("yyyy-MM-dd");
            objPeriodo.fechaFin = DateTime.Parse(dtpFin.Text).ToString("yyyy-MM-dd");
            objPeriodo.idPeriodo =int.Parse( cmbFiltrar.SelectedValue.ToString());
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mtdComprobarRegistro();

            if (comprobador==0)
            {
                mtdCargarCampos();

                filas = objPeriodo.mtdInsertarPeriodo();
                mtdComprobar();
                mtdConsultarPeriodos();

            }

         
           


           


        }

        int comprobador = 0;
        public void mtdComprobarRegistro()
        {

            if (txtNombre.Text==null )
            {
                MessageBox.Show("No estan permitidos los valores nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comprobador = 1;
            }

            foreach (var item in listaPeriodos)
            {
                if (item.nombrePeriodo==txtNombre.Text )
                {
                    MessageBox.Show("Ya se ha creado un periodo con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comprobador = 1;
                }
                else if (item.fechaI==dtpInicio.Text)
                {
                    MessageBox.Show("Ya se ha creado un periodo con la misma fecha Incial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comprobador = 1;
                }
                else if (item.fechaFin==dtpFin.Text)
                {
                    MessageBox.Show("Ya se ha creado un periodo con la misma fecha final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comprobador = 1;
                }

            }



        }

        int filas = -1;
        public  void mtdComprobar()
        {
            if (filas>0)
            {
                MessageBox.Show("Se realizo el proceso exitoso", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public void mtdConsultarPeriodos()
        {
            
            listaPeriodos=  objPeriodo.mtdconsultarPeridos();
            cmbFiltrar.DataSource = listaPeriodos;
            cmbFiltrar.DisplayMember = "nombrePeriodo";
            cmbFiltrar.ValueMember = "idPeriodo";


            
        }


        private void frmPeriodo_Load(object sender, EventArgs e)
        {
            mtdConsultarPeriodos();

        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in listaPeriodos)
                {

                    if (item.idPeriodo == int.Parse(cmbFiltrar.SelectedValue.ToString()))
                    {
                        txtNombre.Text = item.nombrePeriodo;
                        DateTime fechaI = DateTime.Parse(item.fechaI);
                        DateTime fechaFin = DateTime.Parse(item.fechaFin);
                        dtpInicio.Value=  fechaI;
                        dtpFin.Value = fechaFin;



                    }
                }

            }
            catch (Exception)
            {

                
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mtdCargarCampos();

          filas=  objPeriodo.mtdActualizar();
            mtdComprobar();
           mtdConsultarPeriodos();

        }

        private void btnCrearOpcion_Click(object sender, EventArgs e)
        {

            lblPeriodo.Visible=false;
            cmbFiltrar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnRegistrar.Visible = true;



        }

        private void btnModificarOpcion_Click(object sender, EventArgs e)
        {
            lblPeriodo.Visible = true;
            cmbFiltrar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;

        }

        private void btnEliminarOpcion_Click(object sender, EventArgs e)
        {
            lblPeriodo.Visible = true;
            cmbFiltrar.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = false;
            btnRegistrar.Visible = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar el periodo?", "Respuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta==DialogResult.Yes)
            {
                objPeriodo.idPeriodo = int.Parse(cmbFiltrar.SelectedValue.ToString());
                filas = objPeriodo.mtdEliminar();
                mtdComprobar();


            }




        }

     
    }
}
