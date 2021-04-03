
namespace appE2Colsis.Vista
{
    partial class frmAsistencia
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
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.cmbCurso = new Guna.UI.WinForms.GunaComboBox();
            this.cmbAsignatura = new Guna.UI.WinForms.GunaComboBox();
            this.lblCurso = new Guna.UI.WinForms.GunaLabel();
            this.lblAsignatura = new Guna.UI.WinForms.GunaLabel();
            this.lblAsistencia = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.cmbCursoFiltro = new Guna.UI.WinForms.GunaComboBox();
            this.lblEstudiante = new Guna.UI.WinForms.GunaLabel();
            this.btnTomarAsistencia = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cmbFiltroAsignatura = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbFechaFiltro = new Guna.UI.WinForms.GunaComboBox();
            this.btnBuscarAsistencia = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.txtApellido = new Guna.UI.WinForms.GunaTextBox();
            this.btnAsistio = new Guna.UI.WinForms.GunaButton();
            this.btnFalto = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(437, 141);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.Size = new System.Drawing.Size(463, 373);
            this.dgvAsistencia.TabIndex = 0;
            this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
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
            this.cmbCurso.Location = new System.Drawing.Point(86, 35);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Size = new System.Drawing.Size(295, 26);
            this.cmbCurso.TabIndex = 1;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // cmbAsignatura
            // 
            this.cmbAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.cmbAsignatura.BaseColor = System.Drawing.Color.White;
            this.cmbAsignatura.BorderColor = System.Drawing.Color.Silver;
            this.cmbAsignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignatura.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAsignatura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAsignatura.ForeColor = System.Drawing.Color.Black;
            this.cmbAsignatura.FormattingEnabled = true;
            this.cmbAsignatura.Location = new System.Drawing.Point(86, 65);
            this.cmbAsignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAsignatura.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAsignatura.Size = new System.Drawing.Size(295, 26);
            this.cmbAsignatura.TabIndex = 2;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(34, 35);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 24);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.Location = new System.Drawing.Point(9, 65);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(73, 24);
            this.lblAsignatura.TabIndex = 4;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(380, 8);
            this.lblAsistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(108, 36);
            this.lblAsistencia.TabIndex = 5;
            this.lblAsistencia.Text = "Asistencia";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gunaPanel1.Controls.Add(this.lblAsistencia);
            this.gunaPanel1.Location = new System.Drawing.Point(-8, -1);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(919, 58);
            this.gunaPanel1.TabIndex = 7;
            // 
            // cmbCursoFiltro
            // 
            this.cmbCursoFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cmbCursoFiltro.BaseColor = System.Drawing.Color.White;
            this.cmbCursoFiltro.BorderColor = System.Drawing.Color.Silver;
            this.cmbCursoFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCursoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoFiltro.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCursoFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCursoFiltro.ForeColor = System.Drawing.Color.Black;
            this.cmbCursoFiltro.FormattingEnabled = true;
            this.cmbCursoFiltro.Location = new System.Drawing.Point(109, 50);
            this.cmbCursoFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCursoFiltro.Name = "cmbCursoFiltro";
            this.cmbCursoFiltro.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCursoFiltro.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCursoFiltro.Size = new System.Drawing.Size(288, 26);
            this.cmbCursoFiltro.TabIndex = 8;
            this.cmbCursoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbCursoFiltro_SelectedIndexChanged);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(40, 50);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(45, 24);
            this.lblEstudiante.TabIndex = 9;
            this.lblEstudiante.Text = "Curso";
            // 
            // btnTomarAsistencia
            // 
            this.btnTomarAsistencia.AnimationHoverSpeed = 0.07F;
            this.btnTomarAsistencia.AnimationSpeed = 0.03F;
            this.btnTomarAsistencia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTomarAsistencia.BorderColor = System.Drawing.Color.Black;
            this.btnTomarAsistencia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTomarAsistencia.FocusedColor = System.Drawing.Color.Empty;
            this.btnTomarAsistencia.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnTomarAsistencia.Image = null;
            this.btnTomarAsistencia.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTomarAsistencia.Location = new System.Drawing.Point(152, 95);
            this.btnTomarAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTomarAsistencia.Name = "btnTomarAsistencia";
            this.btnTomarAsistencia.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTomarAsistencia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTomarAsistencia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTomarAsistencia.OnHoverImage = null;
            this.btnTomarAsistencia.OnPressedColor = System.Drawing.Color.Black;
            this.btnTomarAsistencia.Size = new System.Drawing.Size(114, 35);
            this.btnTomarAsistencia.TabIndex = 10;
            this.btnTomarAsistencia.Text = "Tomar Asistencia";
            this.btnTomarAsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTomarAsistencia.Click += new System.EventHandler(this.btnTomarAsistencia_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cmbCurso);
            this.gunaGroupBox1.Controls.Add(this.cmbAsignatura);
            this.gunaGroupBox1.Controls.Add(this.btnTomarAsistencia);
            this.gunaGroupBox1.Controls.Add(this.lblCurso);
            this.gunaGroupBox1.Controls.Add(this.lblAsignatura);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(9, 81);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(410, 145);
            this.gunaGroupBox1.TabIndex = 12;
            this.gunaGroupBox1.Text = "Nueva Asistencia";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 93);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 24);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Asignatura";
            // 
            // cmbFiltroAsignatura
            // 
            this.cmbFiltroAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroAsignatura.BaseColor = System.Drawing.Color.White;
            this.cmbFiltroAsignatura.BorderColor = System.Drawing.Color.Silver;
            this.cmbFiltroAsignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroAsignatura.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFiltroAsignatura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroAsignatura.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroAsignatura.FormattingEnabled = true;
            this.cmbFiltroAsignatura.Location = new System.Drawing.Point(109, 94);
            this.cmbFiltroAsignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroAsignatura.Name = "cmbFiltroAsignatura";
            this.cmbFiltroAsignatura.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFiltroAsignatura.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFiltroAsignatura.Size = new System.Drawing.Size(288, 26);
            this.cmbFiltroAsignatura.TabIndex = 14;
            this.cmbFiltroAsignatura.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroAsignatura_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(40, 137);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 24);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Fecha";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.cmbFechaFiltro);
            this.gunaGroupBox2.Controls.Add(this.btnBuscarAsistencia);
            this.gunaGroupBox2.Controls.Add(this.cmbCursoFiltro);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox2.Controls.Add(this.lblEstudiante);
            this.gunaGroupBox2.Controls.Add(this.cmbFiltroAsignatura);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(9, 240);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(410, 227);
            this.gunaGroupBox2.TabIndex = 16;
            this.gunaGroupBox2.Text = "Busqueda de asistencia ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cmbFechaFiltro
            // 
            this.cmbFechaFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cmbFechaFiltro.BaseColor = System.Drawing.Color.White;
            this.cmbFechaFiltro.BorderColor = System.Drawing.Color.Silver;
            this.cmbFechaFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFechaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFechaFiltro.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFechaFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFechaFiltro.ForeColor = System.Drawing.Color.Black;
            this.cmbFechaFiltro.FormattingEnabled = true;
            this.cmbFechaFiltro.Location = new System.Drawing.Point(109, 141);
            this.cmbFechaFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFechaFiltro.Name = "cmbFechaFiltro";
            this.cmbFechaFiltro.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFechaFiltro.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFechaFiltro.Size = new System.Drawing.Size(288, 26);
            this.cmbFechaFiltro.TabIndex = 17;
            // 
            // btnBuscarAsistencia
            // 
            this.btnBuscarAsistencia.AnimationHoverSpeed = 0.07F;
            this.btnBuscarAsistencia.AnimationSpeed = 0.03F;
            this.btnBuscarAsistencia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscarAsistencia.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarAsistencia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarAsistencia.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarAsistencia.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAsistencia.Image = null;
            this.btnBuscarAsistencia.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarAsistencia.Location = new System.Drawing.Point(152, 180);
            this.btnBuscarAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarAsistencia.Name = "btnBuscarAsistencia";
            this.btnBuscarAsistencia.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscarAsistencia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarAsistencia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarAsistencia.OnHoverImage = null;
            this.btnBuscarAsistencia.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarAsistencia.Size = new System.Drawing.Size(120, 34);
            this.btnBuscarAsistencia.TabIndex = 16;
            this.btnBuscarAsistencia.Text = "Buscar";
            this.btnBuscarAsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarAsistencia.Click += new System.EventHandler(this.btnBuscarAsistencia_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(458, 70);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(56, 24);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Nombre";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(458, 105);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(56, 24);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(526, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(214, 26);
            this.txtNombre.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.BaseColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.Silver;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellido.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellido.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(526, 105);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(214, 26);
            this.txtApellido.TabIndex = 18;
            // 
            // btnAsistio
            // 
            this.btnAsistio.AnimationHoverSpeed = 0.07F;
            this.btnAsistio.AnimationSpeed = 0.03F;
            this.btnAsistio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAsistio.BorderColor = System.Drawing.Color.Black;
            this.btnAsistio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAsistio.FocusedColor = System.Drawing.Color.Empty;
            this.btnAsistio.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistio.ForeColor = System.Drawing.Color.White;
            this.btnAsistio.Image = null;
            this.btnAsistio.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAsistio.Location = new System.Drawing.Point(760, 70);
            this.btnAsistio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsistio.Name = "btnAsistio";
            this.btnAsistio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAsistio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAsistio.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAsistio.OnHoverImage = null;
            this.btnAsistio.OnPressedColor = System.Drawing.Color.Black;
            this.btnAsistio.Size = new System.Drawing.Size(109, 25);
            this.btnAsistio.TabIndex = 19;
            this.btnAsistio.Text = "Asistio";
            this.btnAsistio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAsistio.Click += new System.EventHandler(this.btnAsistio_Click);
            // 
            // btnFalto
            // 
            this.btnFalto.AnimationHoverSpeed = 0.07F;
            this.btnFalto.AnimationSpeed = 0.03F;
            this.btnFalto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFalto.BorderColor = System.Drawing.Color.Black;
            this.btnFalto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFalto.FocusedColor = System.Drawing.Color.Empty;
            this.btnFalto.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalto.ForeColor = System.Drawing.Color.White;
            this.btnFalto.Image = null;
            this.btnFalto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFalto.Location = new System.Drawing.Point(760, 106);
            this.btnFalto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFalto.Name = "btnFalto";
            this.btnFalto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFalto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFalto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFalto.OnHoverImage = null;
            this.btnFalto.OnPressedColor = System.Drawing.Color.Black;
            this.btnFalto.Size = new System.Drawing.Size(109, 25);
            this.btnFalto.TabIndex = 21;
            this.btnFalto.Text = "Falto";
            this.btnFalto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFalto.Click += new System.EventHandler(this.btnFalto_Click);
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(909, 524);
            this.Controls.Add(this.btnFalto);
            this.Controls.Add(this.btnAsistio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.dgvAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAsistencia";
            this.Text = "frmAsistencia";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistencia;
        private Guna.UI.WinForms.GunaComboBox cmbCurso;
        private Guna.UI.WinForms.GunaComboBox cmbAsignatura;
        private Guna.UI.WinForms.GunaLabel lblCurso;
        private Guna.UI.WinForms.GunaLabel lblAsignatura;
        private Guna.UI.WinForms.GunaLabel lblAsistencia;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaComboBox cmbCursoFiltro;
        private Guna.UI.WinForms.GunaLabel lblEstudiante;
        private Guna.UI.WinForms.GunaButton btnTomarAsistencia;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cmbFiltroAsignatura;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnBuscarAsistencia;
        private Guna.UI.WinForms.GunaComboBox cmbFechaFiltro;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaTextBox txtApellido;
        private Guna.UI.WinForms.GunaButton btnAsistio;
        private Guna.UI.WinForms.GunaButton btnFalto;
    }
}