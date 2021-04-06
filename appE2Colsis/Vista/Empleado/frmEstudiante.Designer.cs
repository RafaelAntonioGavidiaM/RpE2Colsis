
namespace appE2Colsis.Vista.Empleado
{
    partial class frmEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbBuscqueda = new Guna.UI.WinForms.GunaGroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.txtDocumentoBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCursoBuscar = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.cmbNivelEducativoBuscar = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbCurso = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lbAcudiente = new Guna.UI.WinForms.GunaLabel();
            this.btnAcudiente = new Guna.UI.WinForms.GunaButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.cmbTipoDocumento = new Guna.UI.WinForms.GunaComboBox();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.btnActualizar = new Guna.UI.WinForms.GunaButton();
            this.txtTipoSangre = new Guna.UI.WinForms.GunaTextBox();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.txtNombres = new Guna.UI.WinForms.GunaTextBox();
            this.cmbNivelEducativo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtSeguroEstudiantil = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtTelefono = new Guna.UI.WinForms.GunaTextBox();
            this.txtDocumento = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.dgvEstudiante = new Guna.UI.WinForms.GunaDataGridView();
            this.grbBuscqueda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBuscqueda
            // 
            this.grbBuscqueda.BackColor = System.Drawing.Color.Transparent;
            this.grbBuscqueda.BaseColor = System.Drawing.Color.White;
            this.grbBuscqueda.BorderColor = System.Drawing.Color.Gainsboro;
            this.grbBuscqueda.Controls.Add(this.groupBox2);
            this.grbBuscqueda.Controls.Add(this.groupBox1);
            this.grbBuscqueda.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscqueda.LineColor = System.Drawing.Color.Gainsboro;
            this.grbBuscqueda.Location = new System.Drawing.Point(383, 11);
            this.grbBuscqueda.Margin = new System.Windows.Forms.Padding(2);
            this.grbBuscqueda.Name = "grbBuscqueda";
            this.grbBuscqueda.Size = new System.Drawing.Size(607, 161);
            this.grbBuscqueda.TabIndex = 26;
            this.grbBuscqueda.Text = "Busqueda Estudiante";
            this.grbBuscqueda.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gunaLabel16);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtDocumentoBuscar);
            this.groupBox2.Controls.Add(this.gunaLabel14);
            this.groupBox2.Location = new System.Drawing.Point(5, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 63);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoSize = true;
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel16.Location = new System.Drawing.Point(13, 26);
            this.gunaLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(182, 21);
            this.gunaLabel16.TabIndex = 34;
            this.gunaLabel16.Text = "Buscar por documento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(470, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Size = new System.Drawing.Size(84, 27);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDocumentoBuscar
            // 
            this.txtDocumentoBuscar.BaseColor = System.Drawing.Color.White;
            this.txtDocumentoBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtDocumentoBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentoBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDocumentoBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDocumentoBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDocumentoBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumentoBuscar.Location = new System.Drawing.Point(314, 21);
            this.txtDocumentoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            this.txtDocumentoBuscar.PasswordChar = '\0';
            this.txtDocumentoBuscar.SelectedText = "";
            this.txtDocumentoBuscar.Size = new System.Drawing.Size(123, 26);
            this.txtDocumentoBuscar.TabIndex = 20;
            this.txtDocumentoBuscar.Tag = "Ingrese el nombre o documento";
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel14.Location = new System.Drawing.Point(237, 26);
            this.gunaLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel14.TabIndex = 31;
            this.gunaLabel14.Text = "Documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCursoBuscar);
            this.groupBox1.Controls.Add(this.gunaLabel15);
            this.groupBox1.Controls.Add(this.gunaLabel7);
            this.groupBox1.Controls.Add(this.cmbNivelEducativoBuscar);
            this.groupBox1.Controls.Add(this.gunaLabel5);
            this.groupBox1.Location = new System.Drawing.Point(5, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 63);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // cmbCursoBuscar
            // 
            this.cmbCursoBuscar.BackColor = System.Drawing.Color.Transparent;
            this.cmbCursoBuscar.BaseColor = System.Drawing.Color.White;
            this.cmbCursoBuscar.BorderColor = System.Drawing.Color.Silver;
            this.cmbCursoBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCursoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCursoBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCursoBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmbCursoBuscar.FormattingEnabled = true;
            this.cmbCursoBuscar.Location = new System.Drawing.Point(470, 23);
            this.cmbCursoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCursoBuscar.Name = "cmbCursoBuscar";
            this.cmbCursoBuscar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCursoBuscar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCursoBuscar.Size = new System.Drawing.Size(84, 26);
            this.cmbCursoBuscar.TabIndex = 32;
            this.cmbCursoBuscar.SelectionChangeCommitted += new System.EventHandler(this.cmbCursoBuscar_SelectionChangeCommitted);
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel15.Location = new System.Drawing.Point(13, 22);
            this.gunaLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(135, 21);
            this.gunaLabel15.TabIndex = 33;
            this.gunaLabel15.Text = "Buscar por curso";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(425, 27);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel7.TabIndex = 31;
            this.gunaLabel7.Text = "Curso:";
            // 
            // cmbNivelEducativoBuscar
            // 
            this.cmbNivelEducativoBuscar.BackColor = System.Drawing.Color.Transparent;
            this.cmbNivelEducativoBuscar.BaseColor = System.Drawing.Color.White;
            this.cmbNivelEducativoBuscar.BorderColor = System.Drawing.Color.Silver;
            this.cmbNivelEducativoBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNivelEducativoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelEducativoBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNivelEducativoBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNivelEducativoBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmbNivelEducativoBuscar.FormattingEnabled = true;
            this.cmbNivelEducativoBuscar.Location = new System.Drawing.Point(292, 22);
            this.cmbNivelEducativoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNivelEducativoBuscar.Name = "cmbNivelEducativoBuscar";
            this.cmbNivelEducativoBuscar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNivelEducativoBuscar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbNivelEducativoBuscar.Size = new System.Drawing.Size(84, 26);
            this.cmbNivelEducativoBuscar.TabIndex = 31;
            this.cmbNivelEducativoBuscar.SelectionChangeCommitted += new System.EventHandler(this.cmbNivelEducativoBuscar_SelectionChangeCommitted);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(199, 27);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(92, 15);
            this.gunaLabel5.TabIndex = 31;
            this.gunaLabel5.Text = "Nivel educativo:";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cmbCurso);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lbAcudiente);
            this.gunaGroupBox1.Controls.Add(this.btnAcudiente);
            this.gunaGroupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel12);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel10);
            this.gunaGroupBox1.Controls.Add(this.cmbTipoDocumento);
            this.gunaGroupBox1.Controls.Add(this.label);
            this.gunaGroupBox1.Controls.Add(this.btnRegistrar);
            this.gunaGroupBox1.Controls.Add(this.btnActualizar);
            this.gunaGroupBox1.Controls.Add(this.txtTipoSangre);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.txtNombres);
            this.gunaGroupBox1.Controls.Add(this.cmbNivelEducativo);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txtSeguroEstudiantil);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel11);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.txtTelefono);
            this.gunaGroupBox1.Controls.Add(this.txtDocumento);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.txtApellidos);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel9);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(15, 47);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(331, 524);
            this.gunaGroupBox1.TabIndex = 24;
            this.gunaGroupBox1.Text = "Registro";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurso.BaseColor = System.Drawing.Color.White;
            this.cmbCurso.BorderColor = System.Drawing.Color.Silver;
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ForeColor = System.Drawing.Color.Black;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(124, 413);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Size = new System.Drawing.Size(85, 26);
            this.cmbCurso.TabIndex = 30;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.Location = new System.Drawing.Point(42, 418);
            this.gunaLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel13.TabIndex = 29;
            this.gunaLabel13.Text = "Curso";
            // 
            // lbAcudiente
            // 
            this.lbAcudiente.AutoSize = true;
            this.lbAcudiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbAcudiente.Location = new System.Drawing.Point(121, 325);
            this.lbAcudiente.Name = "lbAcudiente";
            this.lbAcudiente.Size = new System.Drawing.Size(87, 15);
            this.lbAcudiente.TabIndex = 28;
            this.lbAcudiente.Text = "________________";
            // 
            // btnAcudiente
            // 
            this.btnAcudiente.AnimationHoverSpeed = 0.07F;
            this.btnAcudiente.AnimationSpeed = 0.03F;
            this.btnAcudiente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAcudiente.BorderColor = System.Drawing.Color.Black;
            this.btnAcudiente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAcudiente.FocusedColor = System.Drawing.Color.Empty;
            this.btnAcudiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAcudiente.ForeColor = System.Drawing.Color.White;
            this.btnAcudiente.Image = ((System.Drawing.Image)(resources.GetObject("btnAcudiente.Image")));
            this.btnAcudiente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAcudiente.Location = new System.Drawing.Point(209, 315);
            this.btnAcudiente.Name = "btnAcudiente";
            this.btnAcudiente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAcudiente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAcudiente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAcudiente.OnHoverImage = null;
            this.btnAcudiente.OnPressedColor = System.Drawing.Color.Black;
            this.btnAcudiente.Size = new System.Drawing.Size(96, 25);
            this.btnAcudiente.TabIndex = 27;
            this.btnAcudiente.Text = "Buscar";
            this.btnAcudiente.Click += new System.EventHandler(this.btnAcudiente_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(119, 176);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 26;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.Location = new System.Drawing.Point(13, 181);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(101, 15);
            this.gunaLabel12.TabIndex = 25;
            this.gunaLabel12.Text = "Fecha nacimiento";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(30, 315);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel10.TabIndex = 23;
            this.gunaLabel10.Text = "Acudiente";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDocumento.BaseColor = System.Drawing.Color.White;
            this.cmbTipoDocumento.BorderColor = System.Drawing.Color.Silver;
            this.cmbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "T.I",
            "C.C"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(123, 140);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTipoDocumento.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTipoDocumento.Size = new System.Drawing.Size(183, 26);
            this.cmbTipoDocumento.TabIndex = 22;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label.Location = new System.Drawing.Point(23, 213);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 15);
            this.label.TabIndex = 20;
            this.label.Text = "Tipo sangre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(15, 469);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Size = new System.Drawing.Size(93, 34);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AnimationHoverSpeed = 0.07F;
            this.btnActualizar.AnimationSpeed = 0.03F;
            this.btnActualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnActualizar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = null;
            this.btnActualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizar.Location = new System.Drawing.Point(112, 469);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnActualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActualizar.OnHoverImage = null;
            this.btnActualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnActualizar.Size = new System.Drawing.Size(91, 34);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.BaseColor = System.Drawing.Color.White;
            this.txtTipoSangre.BorderColor = System.Drawing.Color.Silver;
            this.txtTipoSangre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoSangre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTipoSangre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTipoSangre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipoSangre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTipoSangre.Location = new System.Drawing.Point(124, 213);
            this.txtTipoSangre.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.PasswordChar = '\0';
            this.txtTipoSangre.SelectedText = "";
            this.txtTipoSangre.Size = new System.Drawing.Size(182, 26);
            this.txtTipoSangre.TabIndex = 21;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(207, 469);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Size = new System.Drawing.Size(98, 34);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BaseColor = System.Drawing.Color.White;
            this.txtNombres.BorderColor = System.Drawing.Color.Silver;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombres.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombres.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombres.Location = new System.Drawing.Point(124, 48);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.Size = new System.Drawing.Size(182, 26);
            this.txtNombres.TabIndex = 9;
            // 
            // cmbNivelEducativo
            // 
            this.cmbNivelEducativo.BackColor = System.Drawing.Color.Transparent;
            this.cmbNivelEducativo.BaseColor = System.Drawing.Color.White;
            this.cmbNivelEducativo.BorderColor = System.Drawing.Color.Silver;
            this.cmbNivelEducativo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNivelEducativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelEducativo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNivelEducativo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNivelEducativo.ForeColor = System.Drawing.Color.Black;
            this.cmbNivelEducativo.FormattingEnabled = true;
            this.cmbNivelEducativo.Location = new System.Drawing.Point(125, 364);
            this.cmbNivelEducativo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNivelEducativo.Name = "cmbNivelEducativo";
            this.cmbNivelEducativo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNivelEducativo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbNivelEducativo.Size = new System.Drawing.Size(84, 26);
            this.cmbNivelEducativo.TabIndex = 16;
            this.cmbNivelEducativo.SelectionChangeCommitted += new System.EventHandler(this.cmbNivelEducativo_SelectionChangeCommitted);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(24, 48);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nombres";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(24, 110);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Documento";
            // 
            // txtSeguroEstudiantil
            // 
            this.txtSeguroEstudiantil.BaseColor = System.Drawing.Color.White;
            this.txtSeguroEstudiantil.BorderColor = System.Drawing.Color.Silver;
            this.txtSeguroEstudiantil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeguroEstudiantil.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSeguroEstudiantil.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSeguroEstudiantil.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSeguroEstudiantil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeguroEstudiantil.Location = new System.Drawing.Point(123, 243);
            this.txtSeguroEstudiantil.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeguroEstudiantil.Name = "txtSeguroEstudiantil";
            this.txtSeguroEstudiantil.PasswordChar = '\0';
            this.txtSeguroEstudiantil.SelectedText = "";
            this.txtSeguroEstudiantil.Size = new System.Drawing.Size(182, 26);
            this.txtSeguroEstudiantil.TabIndex = 14;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(24, 79);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Apellidos";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(13, 145);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(95, 15);
            this.gunaLabel11.TabIndex = 3;
            this.gunaLabel11.Text = "Tipo documento";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(32, 273);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BaseColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColor = System.Drawing.Color.Silver;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(124, 273);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(182, 26);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BaseColor = System.Drawing.Color.White;
            this.txtDocumento.BorderColor = System.Drawing.Color.Silver;
            this.txtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumento.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDocumento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDocumento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocumento.Location = new System.Drawing.Point(124, 110);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.Size = new System.Drawing.Size(182, 26);
            this.txtDocumento.TabIndex = 11;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(10, 243);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(102, 15);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "Seguro estudiantil";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BaseColor = System.Drawing.Color.White;
            this.txtApellidos.BorderColor = System.Drawing.Color.Silver;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidos.Location = new System.Drawing.Point(124, 79);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.Size = new System.Drawing.Size(182, 26);
            this.txtApellidos.TabIndex = 10;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(13, 369);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(89, 15);
            this.gunaLabel9.TabIndex = 8;
            this.gunaLabel9.Text = "Nivel educativo";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(11, 9);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(119, 24);
            this.gunaLabel8.TabIndex = 23;
            this.gunaLabel8.Text = "Registro Estudiante";
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvEstudiante.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiante.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiante.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudiante.EnableHeadersVisualStyles = false;
            this.dgvEstudiante.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstudiante.Location = new System.Drawing.Point(383, 175);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersVisible = false;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(607, 396);
            this.dgvEstudiante.TabIndex = 27;
            this.dgvEstudiante.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvEstudiante.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstudiante.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEstudiante.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEstudiante.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEstudiante.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEstudiante.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dgvEstudiante.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstudiante.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEstudiante.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEstudiante.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEstudiante.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEstudiante.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvEstudiante.ThemeStyle.ReadOnly = true;
            this.dgvEstudiante.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstudiante.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiante.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEstudiante.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstudiante.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEstudiante.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEstudiante.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellClick);
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 586);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.grbBuscqueda);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaLabel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstudiante";
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.grbBuscqueda.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grbBuscqueda;
        private Guna.UI.WinForms.GunaTextBox txtDocumentoBuscar;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel label;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaButton btnActualizar;
        private Guna.UI.WinForms.GunaTextBox txtTipoSangre;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaTextBox txtNombres;
        private Guna.UI.WinForms.GunaComboBox cmbNivelEducativo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtSeguroEstudiantil;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtTelefono;
        private Guna.UI.WinForms.GunaTextBox txtDocumento;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtApellidos;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaComboBox cmbTipoDocumento;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel lbAcudiente;
        private Guna.UI.WinForms.GunaButton btnAcudiente;
        private Guna.UI.WinForms.GunaComboBox cmbCurso;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaComboBox cmbNivelEducativoBuscar;
        private Guna.UI.WinForms.GunaComboBox cmbCursoBuscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaDataGridView dgvEstudiante;
    }
}