using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appE2Colsis.Vista.Reportes
{
    public partial class frmReporteNotas : Form
    {
        public frmReporteNotas()
        {
            InitializeComponent();
        }

        private void frmReporteNotas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
