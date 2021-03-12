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
    public partial class frmReporte : Form
    {
        clReporte objReporte = new clReporte();
        Boolean seCargoLosCursos = false;
        public frmReporte()
        {
            InitializeComponent();
            btnBuscar.Enabled = false;
            btnReporte.Enabled = false;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            mtdCargarCursos();
            seCargoLosCursos = true;
        }
        private void mtdCargarCursos()
        {
            objReporte.mtdListarCursos();
            cmbGrado.DataSource = objReporte.tblPersona;
            cmbGrado.DisplayMember = "nombreCurso";
            cmbGrado.ValueMember = "idCurso";
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seCargoLosCursos == true) 
            {
                objReporte.idCurso = int.Parse(cmbGrado.SelectedValue.ToString());
                mtdCargarEstudiantes();
                mtdCargarPeriodo();
                btnBuscar.Enabled = true;
            }
        }
        private void mtdCargarEstudiantes()
        {
            objReporte.mtdListarEstudiantes();
            cmbNombres.DataSource = objReporte.tblPersona;
            cmbNombres.DisplayMember = "nombres";
            cmbNombres.ValueMember = "idEstudiante";
        }
        private void mtdCargarPeriodo()
        {
            objReporte.mtdListarPeriodos();
            cmbPeriodo.DataSource = objReporte.tblPersona;
            cmbPeriodo.DisplayMember = "nombrePeriodo";
            cmbPeriodo.ValueMember = "idPeriodo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objReporte.idEstudiante = int.Parse(cmbNombres.SelectedValue.ToString());
            objReporte.idPeriodo = int.Parse(cmbPeriodo.SelectedValue.ToString());
            objReporte.mtdListarReporte();
            dataGridView1.DataSource = objReporte.tblPersona;
            btnReporte.Enabled = true;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
           Cursor = Cursors.WaitCursor;

                string fechaHoy = DateTime.Now.ToString("dd-MM-yyyy");

                saveExcelReporte.DefaultExt = "xlsx";
                saveExcelReporte.FileName = fechaHoy+"_ReporteEstudiante";

                if(saveExcelReporte.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveExcelReporte.FileName;
                    mtdExportarExcel(ruta);
                    MessageBox.Show("Se exporto correctamente");
                }

            Cursor = Cursors.Default;
        } 
        private void mtdExportarExcel(string ruta)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile archivoExcel = new ExcelFile();

            ExcelWorksheet ws = archivoExcel.Worksheets.Add("Reporte");

            ws.InsertDataTable(objReporte.tblPersona,
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true,
                        StartRow = 0
                    });
            archivoExcel.Save(ruta);
        }
    }
}
