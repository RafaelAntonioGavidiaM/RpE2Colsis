namespace appE2Colsis.Vista
{
    partial class frmRol
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
            this.lblRol = new Guna.UI.WinForms.GunaLabel();
            this.txtRol = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new Guna.UI.WinForms.GunaButton();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.cmbDecision = new System.Windows.Forms.ComboBox();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.grpEliminarRol = new System.Windows.Forms.GroupBox();
            this.dgvSeleccionar = new System.Windows.Forms.GroupBox();
            this.dgvContenidoRol = new System.Windows.Forms.DataGrid();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnSeleccionar = new Guna.UI.WinForms.GunaButton();
            this.cmbRol = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbModificar = new Guna.UI.WinForms.GunaComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModifica = new Guna.UI.WinForms.GunaButton();
            this.lblFrmModificar = new System.Windows.Forms.Label();
            this.cmbMod = new System.Windows.Forms.ComboBox();
            this.btnModificarRegistros = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtModificar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.grpEliminarRol.SuspendLayout();
            this.dgvSeleccionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoRol)).BeginInit();
            this.grpPermisos.SuspendLayout();
            this.grpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(12, 58);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(85, 17);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Nombre Rol";
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.Transparent;
            this.txtRol.BaseColor = System.Drawing.Color.White;
            this.txtRol.BorderColor = System.Drawing.Color.Silver;
            this.txtRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRol.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRol.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRol.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRol.Location = new System.Drawing.Point(103, 58);
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.Radius = 10;
            this.txtRol.SelectedText = "";
            this.txtRol.Size = new System.Drawing.Size(123, 26);
            this.txtRol.TabIndex = 1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(60, 91);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(69, 31);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Crear Rol";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpPermisos);
            this.groupBox1.Controls.Add(this.gunaButton3);
            this.groupBox1.Controls.Add(this.gunaButton1);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Location = new System.Drawing.Point(15, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 446);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.AnimationHoverSpeed = 0.07F;
            this.btnOk.AnimationSpeed = 0.03F;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOk.BorderColor = System.Drawing.Color.Black;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.FocusedColor = System.Drawing.Color.Empty;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = null;
            this.btnOk.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOk.Location = new System.Drawing.Point(180, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOk.OnHoverImage = null;
            this.btnOk.OnPressedColor = System.Drawing.Color.Black;
            this.btnOk.Radius = 10;
            this.btnOk.Size = new System.Drawing.Size(63, 29);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "Definir";
            this.btnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(7, 29);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(220, 118);
            this.dgvMostrar.TabIndex = 18;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
            // 
            // cmbDecision
            // 
            this.cmbDecision.FormattingEnabled = true;
            this.cmbDecision.Location = new System.Drawing.Point(53, 158);
            this.cmbDecision.Name = "cmbDecision";
            this.cmbDecision.Size = new System.Drawing.Size(121, 21);
            this.cmbDecision.TabIndex = 10;
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Location = new System.Drawing.Point(6, 158);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(35, 13);
            this.lblFormulario.TabIndex = 9;
            this.lblFormulario.Text = "label1";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(135, 93);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 10;
            this.gunaButton3.Size = new System.Drawing.Size(107, 29);
            this.gunaButton3.TabIndex = 8;
            this.gunaButton3.Text = "Permisos";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(67, 217);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(107, 29);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Text = "Asignar Permisos";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click_1);
            // 
            // grpEliminarRol
            // 
            this.grpEliminarRol.Controls.Add(this.dgvSeleccionar);
            this.grpEliminarRol.Controls.Add(this.btnSeleccionar);
            this.grpEliminarRol.Controls.Add(this.cmbRol);
            this.grpEliminarRol.Controls.Add(this.gunaLabel1);
            this.grpEliminarRol.Location = new System.Drawing.Point(302, 92);
            this.grpEliminarRol.Name = "grpEliminarRol";
            this.grpEliminarRol.Size = new System.Drawing.Size(290, 446);
            this.grpEliminarRol.TabIndex = 4;
            this.grpEliminarRol.TabStop = false;
            // 
            // dgvSeleccionar
            // 
            this.dgvSeleccionar.Controls.Add(this.dgvContenidoRol);
            this.dgvSeleccionar.Controls.Add(this.gunaLabel2);
            this.dgvSeleccionar.Controls.Add(this.gunaButton4);
            this.dgvSeleccionar.Location = new System.Drawing.Point(6, 146);
            this.dgvSeleccionar.Name = "dgvSeleccionar";
            this.dgvSeleccionar.Size = new System.Drawing.Size(265, 245);
            this.dgvSeleccionar.TabIndex = 8;
            this.dgvSeleccionar.TabStop = false;
            // 
            // dgvContenidoRol
            // 
            this.dgvContenidoRol.AlternatingBackColor = System.Drawing.Color.White;
            this.dgvContenidoRol.BackgroundColor = System.Drawing.Color.White;
            this.dgvContenidoRol.CaptionBackColor = System.Drawing.Color.White;
            this.dgvContenidoRol.DataMember = "";
            this.dgvContenidoRol.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvContenidoRol.Location = new System.Drawing.Point(9, 50);
            this.dgvContenidoRol.Name = "dgvContenidoRol";
            this.dgvContenidoRol.ReadOnly = true;
            this.dgvContenidoRol.Size = new System.Drawing.Size(223, 141);
            this.dgvContenidoRol.TabIndex = 7;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(6, 11);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(213, 15);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "El Rol contiene los siguientes permisos:\r\n";
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(79, 197);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(69, 31);
            this.gunaButton4.TabIndex = 6;
            this.gunaButton4.Text = "Eliminar";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionar.AnimationSpeed = 0.03F;
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionar.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = null;
            this.btnSeleccionar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionar.Location = new System.Drawing.Point(25, 109);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnHoverImage = null;
            this.btnSeleccionar.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Radius = 10;
            this.btnSeleccionar.Size = new System.Drawing.Size(69, 31);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click_1);
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BaseColor = System.Drawing.Color.White;
            this.cmbRol.BorderColor = System.Drawing.Color.Silver;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.Black;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(25, 77);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRol.Size = new System.Drawing.Size(150, 26);
            this.cmbRol.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(22, 49);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(153, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Seleccione el Rol a eliminar:";
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.btnOk);
            this.grpPermisos.Controls.Add(this.dgvMostrar);
            this.grpPermisos.Controls.Add(this.gunaButton2);
            this.grpPermisos.Controls.Add(this.lblFormulario);
            this.grpPermisos.Controls.Add(this.cmbDecision);
            this.grpPermisos.Location = new System.Drawing.Point(9, 128);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(272, 274);
            this.grpPermisos.TabIndex = 20;
            this.grpPermisos.TabStop = false;
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.gunaButton5);
            this.grpModificar.Controls.Add(this.gunaLabel4);
            this.grpModificar.Controls.Add(this.txtModificar);
            this.grpModificar.Controls.Add(this.btnModificarRegistros);
            this.grpModificar.Controls.Add(this.btnModifica);
            this.grpModificar.Controls.Add(this.lblFrmModificar);
            this.grpModificar.Controls.Add(this.dataGridView1);
            this.grpModificar.Controls.Add(this.cmbMod);
            this.grpModificar.Controls.Add(this.cmbModificar);
            this.grpModificar.Controls.Add(this.gunaLabel3);
            this.grpModificar.Location = new System.Drawing.Point(598, 92);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(311, 446);
            this.grpModificar.TabIndex = 5;
            this.grpModificar.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(43, 49);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(161, 15);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Seleccione el Rol a modificar:";
            // 
            // cmbModificar
            // 
            this.cmbModificar.BackColor = System.Drawing.Color.Transparent;
            this.cmbModificar.BaseColor = System.Drawing.Color.White;
            this.cmbModificar.BorderColor = System.Drawing.Color.Silver;
            this.cmbModificar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbModificar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModificar.ForeColor = System.Drawing.Color.Black;
            this.cmbModificar.FormattingEnabled = true;
            this.cmbModificar.Location = new System.Drawing.Point(46, 77);
            this.cmbModificar.Name = "cmbModificar";
            this.cmbModificar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbModificar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbModificar.Size = new System.Drawing.Size(158, 26);
            this.cmbModificar.TabIndex = 2;
            this.cmbModificar.SelectedIndexChanged += new System.EventHandler(this.cmbModificar_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(220, 118);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModifica
            // 
            this.btnModifica.AnimationHoverSpeed = 0.07F;
            this.btnModifica.AnimationSpeed = 0.03F;
            this.btnModifica.BackColor = System.Drawing.Color.Transparent;
            this.btnModifica.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModifica.BorderColor = System.Drawing.Color.Black;
            this.btnModifica.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifica.FocusedColor = System.Drawing.Color.Empty;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Image = null;
            this.btnModifica.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModifica.Location = new System.Drawing.Point(197, 323);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModifica.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifica.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifica.OnHoverImage = null;
            this.btnModifica.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifica.Radius = 10;
            this.btnModifica.Size = new System.Drawing.Size(63, 29);
            this.btnModifica.TabIndex = 22;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblFrmModificar
            // 
            this.lblFrmModificar.AutoSize = true;
            this.lblFrmModificar.Location = new System.Drawing.Point(23, 328);
            this.lblFrmModificar.Name = "lblFrmModificar";
            this.lblFrmModificar.Size = new System.Drawing.Size(35, 13);
            this.lblFrmModificar.TabIndex = 20;
            this.lblFrmModificar.Text = "label1";
            // 
            // cmbMod
            // 
            this.cmbMod.FormattingEnabled = true;
            this.cmbMod.Location = new System.Drawing.Point(70, 328);
            this.cmbMod.Name = "cmbMod";
            this.cmbMod.Size = new System.Drawing.Size(121, 21);
            this.cmbMod.TabIndex = 21;
            // 
            // btnModificarRegistros
            // 
            this.btnModificarRegistros.AnimationHoverSpeed = 0.07F;
            this.btnModificarRegistros.AnimationSpeed = 0.03F;
            this.btnModificarRegistros.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarRegistros.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificarRegistros.BorderColor = System.Drawing.Color.Black;
            this.btnModificarRegistros.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarRegistros.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarRegistros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnModificarRegistros.Image = null;
            this.btnModificarRegistros.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificarRegistros.Location = new System.Drawing.Point(84, 398);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificarRegistros.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarRegistros.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarRegistros.OnHoverImage = null;
            this.btnModificarRegistros.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarRegistros.Radius = 10;
            this.btnModificarRegistros.Size = new System.Drawing.Size(107, 29);
            this.btnModificarRegistros.TabIndex = 23;
            this.btnModificarRegistros.Text = "Modificar Rol";
            this.btnModificarRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarRegistros.Click += new System.EventHandler(this.btnModificarRegistros_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(17, 123);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(85, 17);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Nombre Rol";
            // 
            // txtModificar
            // 
            this.txtModificar.BackColor = System.Drawing.Color.Transparent;
            this.txtModificar.BaseColor = System.Drawing.Color.White;
            this.txtModificar.BorderColor = System.Drawing.Color.Silver;
            this.txtModificar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModificar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtModificar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModificar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModificar.Location = new System.Drawing.Point(108, 123);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.PasswordChar = '\0';
            this.txtModificar.Radius = 10;
            this.txtModificar.SelectedText = "";
            this.txtModificar.Size = new System.Drawing.Size(123, 26);
            this.txtModificar.TabIndex = 25;
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(237, 120);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(73, 29);
            this.gunaButton5.TabIndex = 26;
            this.gunaButton5.Text = "Renombrar";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 737);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpEliminarRol);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRol";
            this.Text = "frmRol";
            this.Load += new System.EventHandler(this.frmRol_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.grpEliminarRol.ResumeLayout(false);
            this.grpEliminarRol.PerformLayout();
            this.dgvSeleccionar.ResumeLayout(false);
            this.dgvSeleccionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoRol)).EndInit();
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblRol;
        private Guna.UI.WinForms.GunaTextBox txtRol;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.GroupBox grpEliminarRol;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnSeleccionar;
        private Guna.UI.WinForms.GunaComboBox cmbRol;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGrid dgvContenidoRol;
        private System.Windows.Forms.GroupBox dgvSeleccionar;
        private System.Windows.Forms.ComboBox cmbDecision;
        private System.Windows.Forms.Label lblFormulario;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private Guna.UI.WinForms.GunaButton btnOk;
        private System.Windows.Forms.GroupBox grpPermisos;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grpModificar;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtModificar;
        private Guna.UI.WinForms.GunaButton btnModificarRegistros;
        private Guna.UI.WinForms.GunaButton btnModifica;
        private System.Windows.Forms.Label lblFrmModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMod;
        private Guna.UI.WinForms.GunaComboBox cmbModificar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton gunaButton5;
    }
}