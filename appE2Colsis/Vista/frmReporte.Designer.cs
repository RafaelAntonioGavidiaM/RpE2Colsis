
namespace appE2Colsis.Vista
{
    partial class frmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lbEstudiantes = new System.Windows.Forms.ListBox();
            this.cmbPeriodo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.cmbGrado = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.btnReporte = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveExcelReporte = new System.Windows.Forms.SaveFileDialog();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.lbEstudiantes);
            this.gunaGroupBox1.Controls.Add(this.cmbPeriodo);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.btnBuscar);
            this.gunaGroupBox1.Controls.Add(this.cmbGrado);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel9);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(11, 72);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(308, 468);
            this.gunaGroupBox1.TabIndex = 18;
            this.gunaGroupBox1.Text = "Digite los Datos :";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lbEstudiantes
            // 
            this.lbEstudiantes.FormattingEnabled = true;
            this.lbEstudiantes.Location = new System.Drawing.Point(3, 156);
            this.lbEstudiantes.Name = "lbEstudiantes";
            this.lbEstudiantes.Size = new System.Drawing.Size(292, 251);
            this.lbEstudiantes.TabIndex = 23;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriodo.BaseColor = System.Drawing.Color.White;
            this.cmbPeriodo.BorderColor = System.Drawing.Color.Silver;
            this.cmbPeriodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(95, 108);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbPeriodo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPeriodo.Size = new System.Drawing.Size(183, 26);
            this.cmbPeriodo.TabIndex = 22;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(22, 113);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "Periodo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(107, 422);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Size = new System.Drawing.Size(113, 34);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbGrado
            // 
            this.cmbGrado.BackColor = System.Drawing.Color.Transparent;
            this.cmbGrado.BaseColor = System.Drawing.Color.White;
            this.cmbGrado.BorderColor = System.Drawing.Color.Silver;
            this.cmbGrado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGrado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrado.ForeColor = System.Drawing.Color.Black;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(95, 68);
            this.cmbGrado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbGrado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbGrado.Size = new System.Drawing.Size(183, 26);
            this.cmbGrado.TabIndex = 16;
            this.cmbGrado.SelectedIndexChanged += new System.EventHandler(this.cmbGrado_SelectedIndexChanged);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(22, 79);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel9.TabIndex = 8;
            this.gunaLabel9.Text = "Grado";
            // 
            // btnReporte
            // 
            this.btnReporte.AnimationHoverSpeed = 0.07F;
            this.btnReporte.AnimationSpeed = 0.03F;
            this.btnReporte.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReporte.BorderColor = System.Drawing.Color.Black;
            this.btnReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReporte.FocusedColor = System.Drawing.Color.Empty;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = null;
            this.btnReporte.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReporte.Location = new System.Drawing.Point(525, 497);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReporte.OnHoverImage = null;
            this.btnReporte.OnPressedColor = System.Drawing.Color.Black;
            this.btnReporte.Size = new System.Drawing.Size(121, 31);
            this.btnReporte.TabIndex = 20;
            this.btnReporte.Text = "Imprimir Reporte ";
            this.btnReporte.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reporte del Estudiante ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 407);
            this.dataGridView1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(324, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 384);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Reporte";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1007, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaButton btnReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaComboBox cmbPeriodo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cmbGrado;
        private System.Windows.Forms.SaveFileDialog saveExcelReporte;
        private System.Windows.Forms.ListBox lbEstudiantes;
    }
}