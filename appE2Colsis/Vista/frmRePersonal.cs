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
using MySql.Data.MySqlClient;
using System.IO;
namespace appE2Colsis.Vista
{
    public partial class frmRePersonal : Form
    {
        public frmRePersonal()
        {
            InitializeComponent();
        }
        clRePersonal objRePersonal;
        List<clRePersonal> listRePersonal;
        clRol objRol;
        clPersona objPersona;
        List<clRol> listaRol;
        MySqlConnection objConnection = new MySqlConnection();
        string[] decision = new string[2];

        private void frmRePersonal_Load(object sender, EventArgs e)
        {
            mtdCargar();
            dgvEmpleado.Columns["idRol"].Visible = false;
            dgvEmpleado.Columns["tipoDocumento"].Visible = false;
            dgvEmpleado.Columns["fechaNacimiento"].Visible = false;
            dgvEmpleado.Columns["tipoSangre"].Visible = false;
            dgvEmpleado.Columns["tipoSeguroYseguroMedico"].Visible = false;
            dgvEmpleado.Columns["seguroEstudiantil"].Visible = false;


            decision[0] = "Habilitado";
            decision[1] = "Desabilitado";
            cmbEstado.DataSource = decision;
        }

        public void mtdCargar()
        {
            listRePersonal = new List<clRePersonal>();
            objRePersonal = new clRePersonal();
            listRePersonal = objRePersonal.mtdListar();
            dgvEmpleado.DataSource = listRePersonal;

            objRol = new clRol();
            listaRol = new List<clRol>();
            listaRol = objRol.mtdConsultarRol();
            cmbRol.DataSource = listaRol;
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";


        }

        public void mtdCargarDatos()
        {

            listRePersonal = new List<clRePersonal>();

            for (int i = 0; i < 1; i++)
            {
                clRePersonal objRePersonal = new clRePersonal();
                objRePersonal.nombre = txtNombre.Text;
                objRePersonal.apellido = txtApellido.Text;
                objRePersonal.documento = txtDocumento.Text;
                objRePersonal.telefono = txtTelefono.Text;
                objRePersonal.direccion = txtDireccion.Text;
                objRePersonal.ciudad = txtCiudad.Text;
                objRePersonal.correoYemail = txtCorreo.Text;
                objRePersonal.clave = txtClave.Text;
                objRePersonal.estado = cmbEstado.Text;
                objRePersonal.foto = txtFoto.Text;
                objRePersonal.idRol = int.Parse(cmbRol.SelectedValue.ToString());

                listRePersonal.Add(objRePersonal);
            }



        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mtdCargarDatos();
            DialogResult opcion = MessageBox.Show("Desea registrar un nuevo personal ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion == DialogResult.Yes)
            {
                int Registro = objRePersonal.mtdRegistrar(listRePersonal);

                if (Registro > 0)
                {
                    MessageBox.Show("se realizo el registro exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdCargar();
                    //GUARDA LA IMAGEN EN LA CARPETA 
                    string ruta = Directory.GetCurrentDirectory() + "\\fotosPersonal\\";
                    File.Copy(openFoto.FileName, ruta + txtFoto.Text);
                    
                  

                    mtdBorrarTxt();
                }
                else
                {
                    MessageBox.Show("no se pudo hacer el registro correspondinete del nuevo personal", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int idPersona = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(" Desea eliminar el empleado " + txtNombre.Text + " " + txtApellido.Text, " eliminar empleado ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion == DialogResult.Yes)
            {
                int filasAfectadas = objRePersonal.mtdEliminarPersonal(idPersona);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se realizo el delete correctamente", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdCargar();
                    mtdBorrarTxt();
                }
                else
                {
                    MessageBox.Show("no se pudo elimnar la persona seleccionada", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvEmpleado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    dgvEmpleado.CurrentRow.Selected = true;
                    idPersona = int.Parse(dgvEmpleado.Rows[e.RowIndex].Cells["idPersonal"].FormattedValue.ToString());
                    txtNombre.Text = dgvEmpleado.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                    txtApellido.Text = dgvEmpleado.Rows[e.RowIndex].Cells["apellido"].FormattedValue.ToString();
                    txtDocumento.Text = dgvEmpleado.Rows[e.RowIndex].Cells["documento"].FormattedValue.ToString();
                    txtTelefono.Text = dgvEmpleado.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();
                    txtDireccion.Text = dgvEmpleado.Rows[e.RowIndex].Cells["direccion"].FormattedValue.ToString();
                    txtCiudad.Text = dgvEmpleado.Rows[e.RowIndex].Cells["ciudad"].FormattedValue.ToString();
                    txtCorreo.Text = dgvEmpleado.Rows[e.RowIndex].Cells["correoYemail"].FormattedValue.ToString();
                    txtClave.Text = dgvEmpleado.Rows[e.RowIndex].Cells["clave"].FormattedValue.ToString();
                    cmbEstado.Text = dgvEmpleado.Rows[e.RowIndex].Cells["estado"].FormattedValue.ToString();

                    string rol = dgvEmpleado.Rows[e.RowIndex].Cells["idRol"].FormattedValue.ToString();
                    string estado = dgvEmpleado.Rows[e.RowIndex].Cells["estado"].FormattedValue.ToString();

                    for (int i = 0; i < listaRol.Count; i++)
                    {
                        if (listaRol[i].idRol == int.Parse(rol))
                        {
                            cmbRol.Text = listaRol[i].nombreRol;
                        }
                    }
                    for (int i = 0; i < listRePersonal.Count; i++)
                    {
                        if (listRePersonal[i].estado == estado)
                        {
                            cmbEstado.Text = listRePersonal[i].estado;
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede editar este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listRePersonal = new List<clRePersonal>();
            listRePersonal = objRePersonal.mtdListar();
            int contador = 0;
            for (int i = 0; i < listRePersonal.Count; i++)
            {
                if (listRePersonal[i].nombre == txtNombre.Text && listRePersonal[i].apellido == txtApellido.Text && listRePersonal[i].documento == txtDocumento.Text && listRePersonal[i].telefono == txtTelefono.Text && listRePersonal[i].direccion == txtDireccion.Text && listRePersonal[i].ciudad == txtCiudad.Text && listRePersonal[i].correoYemail == txtCorreo.Text && listRePersonal[i].clave == txtClave.Text && cmbEstado.SelectedValue.Equals(listRePersonal[i].estado) && cmbRol.SelectedValue.Equals(listRePersonal[i].idRol) && txtFoto.Text==listRePersonal[i].foto)
                {

                    MessageBox.Show("No se registra ningun cambio");
                    contador = contador + 1;
                }
            }
            if (contador != 0)
            {
                MessageBox.Show("Verifique la informacion que desea actualizar");
            }
            else
            {

                objRePersonal.idPersonal = idPersona;
                objRePersonal.nombre = txtNombre.Text;
                objRePersonal.apellido = txtApellido.Text;
                objRePersonal.documento = txtDocumento.Text;
                objRePersonal.telefono = txtTelefono.Text;
                objRePersonal.direccion = txtDireccion.Text;
                objRePersonal.ciudad = txtCiudad.Text;
                objRePersonal.correoYemail = txtCorreo.Text;
                objRePersonal.foto = txtFoto.Text;
                objRePersonal.clave = txtClave.Text;
                objRePersonal.estado = cmbEstado.SelectedValue.ToString();
                objRePersonal.idRol = int.Parse(cmbRol.SelectedValue.ToString());



                objRePersonal.mtdActualizar();
                int filas = objRePersonal.mtdActualizar();

                if (filas > 0)
                {
                    MessageBox.Show("Actualizacion exitosa");
                    mtdCargar();
                    string ruta = Directory.GetCurrentDirectory() + "\\fotosPersonal\\";
                    File.Copy(openFoto.FileName, ruta + txtFoto.Text);
                    mtdBorrarTxt();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la actualizacion correctamente");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            mtdCargar();


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<clRePersonal> ListPersona = new List<clRePersonal>();
            objRePersonal.nombre = txtBuscar.Text;
            objRePersonal.documento = txtBuscar.Text;

            ListPersona = objRePersonal.mtdBuscar();

            foreach (var item in ListPersona)
            {
                if (txtBuscar.Text == item.nombre || txtBuscar.Text == item.documento)
                {
                    dgvEmpleado.DataSource = ListPersona;
                }
            }


        }

        public void mtdBorrarTxt()
        {

            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtCorreo.Clear();
            txtClave.Clear();

        }

        string extension = "";
        string registroFoto = "";
    

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            openFoto.Filter = "Image Files(JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";

            if (openFoto.ShowDialog() == DialogResult.OK)
            {
                string url = openFoto.FileName;

                extension = Path.GetExtension(url);
                txtFoto.Text = txtDocumento.Text + extension;
                registroFoto = txtFoto.Text;
            }
        }
    }
}
