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
using GemBox.Spreadsheet;

namespace appE2Colsis.Vista
{
    public partial class frmNota : Form
    {
        public int idDocente { get; set; }
        public frmNota(int idDocente)
        {
            this.idDocente = idDocente;

            InitializeComponent();
        }

        int Curso = 0;
        int Asignatura = 0;
        int Estudiante = 0;
        int export = 0;
        List<clNota> listaNotas = new List<clNota>();
        DataTable estudiantenota = new DataTable();
        clNota objNota = new clNota();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreNota = txtNombreNota.Text;
            nombreNota = nombreNota.Replace(" ", String.Empty);
            objNota.nombreNota = nombreNota;
            objNota.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
            objNota.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objNota.idDocente = idDocente;
            int rows = objNota.mtdRegistrarNota();
            if (rows > 0)
            {
                MessageBox.Show("Se registro exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo Registrar");

            }
            txtNombreNota.Clear();



        }

        private void frmNota_Load(object sender, EventArgs e)
        {
            objNota.idDocente = idDocente;
            List<clNota> listaCursos = new List<clNota>();
            listaCursos = objNota.mtdConsultarCursos();
            cmbCurso.DataSource = listaCursos;
            cmbAsignatura.DataSource = listaCursos;
            cmbCurso.DisplayMember = "nombreCurso";
            cmbCurso.ValueMember = "idCurso";
            cmbAsignatura.DisplayMember = "nombreAsignatura";
            cmbAsignatura.ValueMember = "idAsignatura";
            cmbCursoF.DataSource = listaCursos;
            cmbAsignaturaF.DataSource = listaCursos;
            cmbCursoF.DisplayMember = "nombreCurso";
            cmbCursoF.ValueMember = "idCurso";
            cmbAsignaturaF.DisplayMember = "nombreAsignatura";
            cmbAsignaturaF.ValueMember = "idAsignatura";




        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objNota.idAsignatura = int.Parse(cmbAsignaturaF.SelectedValue.ToString());
            objNota.idCurso = int.Parse(cmbCursoF.SelectedValue.ToString());


            estudiantenota = objNota.mtdConsultarNotasDeEstudiantes();
            dgvMostrarNEstudiantes.DataSource = estudiantenota;
         int   contador = 0;
            for (int i = 0; i < dgvMostrarNEstudiantes.Columns.Count; i++)
            {
                if (contador == 0 || contador == 1 || contador == 2)
                {
                    dgvMostrarNEstudiantes.Columns[i].Visible = false;

                }
                else
                {
                   dgvMostrarNEstudiantes.Columns[i].Visible = true;

                }
                contador++;

            }








        }

        /// <summary>
        /// Metodo que consulta las notas del estudiante y carga en datagrid de modificar Notas
        /// </summary>

        public void mtdCargarDgvM()
        {
            objNota.idCurso = Curso;
            objNota.idAsignatura = Asignatura;
            objNota.idEstudiante = Estudiante;


            listaNotas = objNota.mtdCargarNotas();
            dgvEstudianteNotas.DataSource = listaNotas;

            int contador = 0;
            for (int i = 0; i < dgvEstudianteNotas.Columns.Count; i++)
            {
                if (contador == 0 || contador == 1 || contador == 8)
                {
                    dgvEstudianteNotas.Columns[i].Visible = true;

                }
                else
                {
                    dgvEstudianteNotas.Columns[i].Visible = false;

                }
                contador++;

            }


        }


        private void dgvMostrarNEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMostrarNEstudiantes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvMostrarNEstudiantes.CurrentRow.Selected = true;
                Curso = int.Parse(dgvMostrarNEstudiantes.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                Asignatura = int.Parse(dgvMostrarNEstudiantes.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                Estudiante = int.Parse(dgvMostrarNEstudiantes.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                lblEstudiante.Text = (dgvMostrarNEstudiantes.Rows[e.RowIndex].Cells[3].FormattedValue.ToString() + " " + dgvMostrarNEstudiantes.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());


                mtdCargarDgvM();





            }
        }

        private void dgvEstudianteNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvEstudianteNotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lblNota.Text = dgvEstudianteNotas.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtCalificacion.Text = dgvEstudianteNotas.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();










                }

            }
            catch (Exception)
            {

            }



        }

        private void btnCambiarN_Click(object sender, EventArgs e)
        {
            foreach (var item in listaNotas)
            {
                if (item.nombreNota == lblNota.Text)
                {
                    item.nota = float.Parse(txtCalificacion.Text);

                }
            }
            dgvEstudianteNotas.Refresh();
        }

        private void btnActualizarDB_Click(object sender, EventArgs e)
        {
            int rows = objNota.mtdActualizarNotas(listaNotas);

            if (rows > 0)
            {
                MessageBox.Show("Actualizacion de notas Exitosamente", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo Actualizar Registros :(", "Lo sentimos ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnExportarAN_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string fechaHoy = DateTime.Now.ToString("dd-MM-yyyy");
            SaveFileDialog saveExcelReporte = new SaveFileDialog();
            saveExcelReporte.DefaultExt = "xlsx";
            saveExcelReporte.FileName = fechaHoy + "_ReporteNotasEstudiantes";

            if (saveExcelReporte.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveExcelReporte.FileName;
                mtdExportarExcel(ruta);

                if (export==0)
                {
                    MessageBox.Show("Se exporto correctamente");

                }
                
                
            }

            Cursor = Cursors.Default;



        }

        private void mtdExportarExcel(string ruta)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile archivoExcel = new ExcelFile();

            ExcelWorksheet ws = archivoExcel.Worksheets.Add("Reporte");

            ws.InsertDataTable(estudiantenota,//toma los datos a exportar
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true,
                        StartRow = 0
                    });
            export = 0;
            try
            {
                archivoExcel.Save(ruta);

            }
            catch (Exception)
            {
                export = 1;

                MessageBox.Show("El archivo esta en uso , por favor cierre el archivo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private ExcelFile ef;


        private void grpImportar_Click(object sender, EventArgs e)
        {


        }
    }
}

