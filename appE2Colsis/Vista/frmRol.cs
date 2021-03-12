﻿using System;
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


    public partial class frmRol : Form
    {

        List<clRol> listaRoles = new List<clRol>();
        List<clRol> permisos = new List<clRol>();
        List<clRol> listaModificar = new List<clRol>();
        List<clRol> listaRolFiltrar = new List<clRol>();
        List<clRol> listaRol = new List<clRol>();// lista trae valores de la tabla rol
        string[] decision = new string[2];
        int registro = 0; //Almacena si encuentra algun registro con el nombre de rol y lo comprueba por medio del mtdComprobarRol

        clRol objRol = new clRol();
        int rows = 0;
       // int idRol = 0; // Necesario para asignar permisos
        public frmRol()
        {
            InitializeComponent();
        }

        
        

        public void mtdComprobar()
        {
            if (rows>0)
            {
                MessageBox.Show("Accion Realizada Satisfactoriamente", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //grpPermisos.Text = txtRol.Text;
            }
            else
            {
                MessageBox.Show("No fue posible atender la Solicitud", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


         

        }
        


        /// <summary>
        /// Este metodo escondera y mostrará la opcion deseada segun el boton que la persona de clic crear,eliminar,modificar
        /// </summary>
        public void mtdMostrarOpciones( Control valor)
        {
            Control[] opcionSolicitada = new Control[3];
            opcionSolicitada[0] = grpCrear;
            opcionSolicitada[1] = grpModificar;
            opcionSolicitada[2] = grpEliminarRol;

            for (int i = 0; i < opcionSolicitada.Length; i++)
            {
                if (opcionSolicitada[i]==valor)
                {
                    opcionSolicitada[i].Visible = true;
                    

                }
                else
                {
                    opcionSolicitada[i].Visible = false;
                    opcionSolicitada[i].BackColor = TransparencyKey;
                }
            }



        }

        public void mtdBlanquearRegistrar()
        {
            txtRol.Clear();

              
        }

        public void mtdCargarCmbRol()
        {
            
            
           listaRol= objRol.mtdConsultarRol();
            cmbRol.DataSource = listaRol;
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
            cmbModificar.DataSource = listaRol;
            cmbModificar.DisplayMember = "nombreRol";
            cmbModificar.ValueMember = "idRol";
            cmbFiltrar.DataSource = listaRol;
            cmbFiltrar.DisplayMember="nombreRol";
            cmbFiltrar.ValueMember = "idRol";


        }

        public void mtdComprobarRol(string validar) //Comprueba si ya existe un rol con el mismo nombre que con el que el usuario desea ingresar o modificar 
        {
            foreach (var item in listaRol)
            {
                if (item.nombreRol == validar)
                {

                    registro = 1;
                }
                else if (validar == "")
                {

                    registro = 2;

                }



            }


        }



        private void gunaButton1_Click(object sender, EventArgs e) // Permite crear un registro en la tabla rol
        {


            mtdComprobarRol(txtRol.Text);
           

            if (registro==0)
            {
                objRol.nombreRol = txtRol.Text;
                rows = objRol.mtdRegistrarRol();
                mtdComprobar();
                btnPermisos.Visible = true;
            }
            else if (registro==1)
            {
                MessageBox.Show("Este Rol ya esta ingresado en el sistema ", "Error al Ingresar rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registro==2)
            {
                MessageBox.Show("No se pueden ingresar valores nulos  ", "Error al Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }      
            


            
            

            
            


        }

        public void mtdListarDecisionPermiso()
        {
            string[] formularios = new string[4]; // Añadir formularios
            formularios[0] = "frmLogin";
            formularios[1] = "frmRol";
            formularios[2] = "frmRepersonal";
            formularios[3] = "frmInformes";

            decision[0] = "Habilitado";
            decision[1] = "Desabilitado";





            for (int i = 0; i < formularios.Length; i++)
            {
                clRol objRolPermiso = new clRol();
                objRolPermiso.nombreFormulario = formularios[i];
                objRolPermiso.nombrePermiso = decision[0].ToString();
                permisos.Add(objRolPermiso);

            }


            dgvMostrar.DataSource = permisos;
          /* for (int i = 0; i < permisos.Count; i++)
            {
                dgvMostrar.Rows[i].Cells["nombreFormulario"].Value = permisos[i].nombreFormulario;
                dgvMostrar.Rows[i].Cells["nombrePermiso"].Value = permisos[i].nombrePermiso;

            }*/
                

            

            cmbDecision.DataSource = decision;
            cmbDecision.DisplayMember = "nombrePermiso";
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            grpPermisos.Visible = true;
            
            
            


            mtdListarDecisionPermiso();
            dgvMostrar.Columns[0].Visible = false;
            dgvMostrar.Columns[1].Visible = false;
            dgvMostrar.Columns[2].Visible = true;
            dgvMostrar.Columns[3].Visible = false;
            dgvMostrar.Columns[4].Visible = true;
            dgvMostrar.Columns[5].Visible = false;



        }

       


    
        public void mtdCargarGridEliminar()
        {
            objRol.nombreRol = cmbRol.Text;

            listaRoles = objRol.mtdColsutarPermisosRoles();
             dgvContenidoRol.DataSource = listaRoles;

            

        }

       

       
        

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMostrar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lblFormulario.Text = dgvMostrar.Rows[e.RowIndex].Cells["nombreFormulario"].FormattedValue.ToString();
                    cmbDecision.Text = dgvMostrar.Rows[e.RowIndex].Cells["nombrePermiso"].FormattedValue.ToString();


                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lo sentimos no se puede seleccionar valor", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (var item in permisos)
            {
                if (item.nombreFormulario == lblFormulario.Text)
                {
                    item.nombrePermiso = cmbDecision.Text;
                    dgvMostrar.Refresh();

                }

            }

        }

        

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
           int idRolCrear = 0;

            foreach (var item in permisos)
            {
                if (item.nombrePermiso=="Habilitado")
                {
                    item.idPermiso = 1;

                }
                else if (item.nombrePermiso=="Desabilitado")
                {
                    item.idPermiso = 2;

                }
            }

            List<clRol> consultarIdRol = new List<clRol>();
            consultarIdRol = objRol.mtdConsultarRol();

            foreach (var item in consultarIdRol)
            {

                if (txtRol.Text == item.nombreRol)
                {
                    idRolCrear = item.idRol;
                

                }
            }
           

          rows =  objRol.mtdRegistrarPermisos(permisos,idRolCrear);
            mtdComprobar();
            mtdCargarCmbRol();
            mtdBlanquearRegistrar();
            grpPermisos.Visible = false;
            permisos.Clear();
            btnPermisos.Visible = false;

        }

        private void frmRol_Load_1(object sender, EventArgs e)
        {
            mtdCargarCmbRol();
            Control valor = grpCrear;
            mtdMostrarOpciones(valor);



            decision[0] = "Habilitado";
            decision[1] = "Desabilitado";
            cmbMod.DataSource = decision;



            dgvSeleccionar.Visible = false;
            grpPermisos.Visible = false;
            btnPermisos.Visible = false;

        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            mtdCargarGridEliminar();
            dgvSeleccionar.Visible = true;
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            int idRolEliminar = 0;//id que me permitira eliminar los registro en rol y rol_permisos
            foreach (var item in listaRoles)
            {
                if (cmbRol.Text == item.nombreRol)
                {
                    idRolEliminar = item.idRol;

                }

            }

            DialogResult opcion = MessageBox.Show("¿Desea Realmente Eliminar el registro y los permisos?", "Advetencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (opcion == DialogResult.Yes)
            {
                objRol.idRol = idRolEliminar;
                rows = objRol.mtdEliminarRolYPermisos();
                mtdComprobar();
                mtdCargarGridEliminar();
                mtdCargarCmbRol();


            }

            dgvSeleccionar.Visible = false; // oculta el groupbox de eliminar

        }

        private void cmbModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   int idRol = 0;
           objRol.nombreRol= cmbModificar.Text;
           
           listaModificar= objRol.mtdColsutarPermisosRoles(); //lista se carga con los valores solicitados
            foreach (var item in listaModificar)
            {
                if (cmbModificar.Text==item.nombreRol)
                {
                    txtModificar.Text = item.nombreRol;
                    lblMrol.Text = item.nombreRol;
                  //  idRol = item.idRol;
                }
                


            }
            dataGridView1.DataSource = listaModificar;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            string validar = txtModificar.Text;
            mtdComprobarRol(validar);

            if (registro == 0)
            {

                foreach (var item in listaModificar)
                {
                    if (lblMrol.Text == item.nombreRol)
                    {
                        item.nombreRol = txtModificar.Text;


                    }



                }
                dataGridView1.Refresh();

            }
            else if (registro == 1)
            {
                MessageBox.Show("Este Rol ya esta ingresado en el sistema ", "Error al Ingresar rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registro == 2)
            {
                MessageBox.Show("No se pueden ingresar valores nulos  ", "Error al Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lblFrmModificar.Text = dataGridView1.Rows[e.RowIndex].Cells["nombreFormulario"].FormattedValue.ToString();
                    cmbMod.Text = dataGridView1.Rows[e.RowIndex].Cells["nombrePermiso"].FormattedValue.ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos no se puede seleccionar valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string contenido = lblFrmModificar.Text;

            foreach (var item in listaModificar)
            {
                if (item.nombreFormulario==contenido)
                {
                    item.nombrePermiso = cmbMod.Text;

                }
                if (item.nombrePermiso == "Habilitado")
                {
                    item.idPermiso = 1;
                }
                else if (item.nombrePermiso == "Desabilitado")
                {
                    item.idPermiso = 2;
                }

            }

            dataGridView1.Refresh();

        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            
            
                int idRolModificar = listaModificar[0].idRol;
              string nombreRolModificar   = listaModificar[0].nombreRol;

            

            
           rows = objRol.mtdModificarRolPermisos(listaModificar,idRolModificar,nombreRolModificar);
            mtdComprobar();
            txtModificar.Clear();
            listaModificar = objRol.mtdColsutarPermisosRoles();
            mtdCargarCmbRol();





        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreRol = cmbFiltrar.Text;
            


            listaRolFiltrar= objRol.mtdFiltrar(nombreRol);
            try
            {
                dataGridView2.DataSource = listaRolFiltrar;

            }
            catch (Exception)
            {

                
            }
            
            

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            Control valor = grpCrear;
            mtdMostrarOpciones(valor);

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Control valor = grpModificar;
            mtdMostrarOpciones(valor);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Control valor = grpEliminarRol;
            mtdMostrarOpciones(valor);
        }
    }
}
