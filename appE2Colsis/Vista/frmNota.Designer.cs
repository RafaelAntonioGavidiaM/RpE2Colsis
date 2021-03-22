
namespace appE2Colsis.Vista
{
    partial class frmNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNota));
            this.txtNombreNota = new Guna.UI.WinForms.GunaTextBox();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.cmbAsignatura = new Guna.UI.WinForms.GunaComboBox();
            this.cmbCurso = new Guna.UI.WinForms.GunaComboBox();
            this.dgvMostrarNEstudiantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAsignaturaF = new Guna.UI.WinForms.GunaComboBox();
            this.cmbCursoF = new Guna.UI.WinForms.GunaComboBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.dgvEstudianteNotas = new System.Windows.Forms.DataGridView();
            this.btnActualizarDB = new Guna.UI.WinForms.GunaButton();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.grpActualizarNota = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpCrearNota = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFiltroAsignatura = new System.Windows.Forms.GroupBox();
            this.btnActualizarNota = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportarAN = new Guna.UI.WinForms.GunaButton();
            this.btnCrear = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.grpEliminarNota = new System.Windows.Forms.GroupBox();
            this.btnMostarNotas = new Guna.UI.WinForms.GunaButton();
            this.cmbNotaEliminar = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarNota = new Guna.UI.WinForms.GunaButton();
            this.cmbEliminarA = new Guna.UI.WinForms.GunaComboBox();
            this.cmbEliminarC = new Guna.UI.WinForms.GunaComboBox();
            this.btnModificar = new Guna.UI.WinForms.GunaButton();
            this.grpModificarNota = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new Guna.UI.WinForms.GunaTextBox();
            this.cmbEstado = new Guna.UI.WinForms.GunaComboBox();
            this.btnSeleccionarM = new Guna.UI.WinForms.GunaButton();
            this.cmbNotaModificar = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.cmbModificarA = new Guna.UI.WinForms.GunaComboBox();
            this.cmbModificarC = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteNotas)).BeginInit();
            this.grpActualizarNota.SuspendLayout();
            this.grpCrearNota.SuspendLayout();
            this.grpFiltroAsignatura.SuspendLayout();
            this.grpEliminarNota.SuspendLayout();
            this.grpModificarNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreNota
            // 
            this.txtNombreNota.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreNota.BaseColor = System.Drawing.Color.White;
            this.txtNombreNota.BorderColor = System.Drawing.Color.Silver;
            this.txtNombreNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreNota.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreNota.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombreNota.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreNota.Location = new System.Drawing.Point(120, 19);
            this.txtNombreNota.Name = "txtNombreNota";
            this.txtNombreNota.PasswordChar = '\0';
            this.txtNombreNota.Radius = 10;
            this.txtNombreNota.SelectedText = "";
            this.txtNombreNota.Size = new System.Drawing.Size(134, 26);
            this.txtNombreNota.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(58, 126);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.Size = new System.Drawing.Size(110, 26);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Crear Nota";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.cmbAsignatura.Location = new System.Drawing.Point(120, 83);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAsignatura.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAsignatura.Radius = 10;
            this.cmbAsignatura.Size = new System.Drawing.Size(131, 26);
            this.cmbAsignatura.TabIndex = 2;
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
            this.cmbCurso.Location = new System.Drawing.Point(120, 51);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Radius = 10;
            this.cmbCurso.Size = new System.Drawing.Size(83, 26);
            this.cmbCurso.TabIndex = 3;
            // 
            // dgvMostrarNEstudiantes
            // 
            this.dgvMostrarNEstudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrarNEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarNEstudiantes.Location = new System.Drawing.Point(22, 149);
            this.dgvMostrarNEstudiantes.Name = "dgvMostrarNEstudiantes";
            this.dgvMostrarNEstudiantes.Size = new System.Drawing.Size(626, 359);
            this.dgvMostrarNEstudiantes.TabIndex = 4;
            this.dgvMostrarNEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarNEstudiantes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estudiante:";
            // 
            // cmbAsignaturaF
            // 
            this.cmbAsignaturaF.BackColor = System.Drawing.Color.Transparent;
            this.cmbAsignaturaF.BaseColor = System.Drawing.Color.White;
            this.cmbAsignaturaF.BorderColor = System.Drawing.Color.Silver;
            this.cmbAsignaturaF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAsignaturaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignaturaF.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAsignaturaF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAsignaturaF.ForeColor = System.Drawing.Color.Black;
            this.cmbAsignaturaF.FormattingEnabled = true;
            this.cmbAsignaturaF.Location = new System.Drawing.Point(260, 121);
            this.cmbAsignaturaF.Name = "cmbAsignaturaF";
            this.cmbAsignaturaF.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAsignaturaF.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAsignaturaF.Radius = 10;
            this.cmbAsignaturaF.Size = new System.Drawing.Size(114, 26);
            this.cmbAsignaturaF.TabIndex = 7;
            // 
            // cmbCursoF
            // 
            this.cmbCursoF.BackColor = System.Drawing.Color.Transparent;
            this.cmbCursoF.BaseColor = System.Drawing.Color.White;
            this.cmbCursoF.BorderColor = System.Drawing.Color.Silver;
            this.cmbCursoF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCursoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoF.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCursoF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCursoF.ForeColor = System.Drawing.Color.Black;
            this.cmbCursoF.FormattingEnabled = true;
            this.cmbCursoF.IntegralHeight = false;
            this.cmbCursoF.ItemHeight = 20;
            this.cmbCursoF.Location = new System.Drawing.Point(123, 121);
            this.cmbCursoF.Name = "cmbCursoF";
            this.cmbCursoF.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCursoF.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCursoF.Radius = 10;
            this.cmbCursoF.Size = new System.Drawing.Size(131, 26);
            this.cmbCursoF.TabIndex = 6;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(134, 107);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(90, 20);
            this.lblEstudiante.TabIndex = 8;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // dgvEstudianteNotas
            // 
            this.dgvEstudianteNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudianteNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudianteNotas.Location = new System.Drawing.Point(39, 149);
            this.dgvEstudianteNotas.Name = "dgvEstudianteNotas";
            this.dgvEstudianteNotas.Size = new System.Drawing.Size(334, 359);
            this.dgvEstudianteNotas.TabIndex = 9;
            this.dgvEstudianteNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudianteNotas_CellContentClick);
            // 
            // btnActualizarDB
            // 
            this.btnActualizarDB.AnimationHoverSpeed = 0.07F;
            this.btnActualizarDB.AnimationSpeed = 0.03F;
            this.btnActualizarDB.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarDB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnActualizarDB.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarDB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizarDB.FocusedColor = System.Drawing.Color.Empty;
            this.btnActualizarDB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDB.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDB.Image = null;
            this.btnActualizarDB.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizarDB.Location = new System.Drawing.Point(138, 540);
            this.btnActualizarDB.Name = "btnActualizarDB";
            this.btnActualizarDB.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnActualizarDB.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActualizarDB.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActualizarDB.OnHoverImage = null;
            this.btnActualizarDB.OnPressedColor = System.Drawing.Color.Black;
            this.btnActualizarDB.Radius = 10;
            this.btnActualizarDB.Size = new System.Drawing.Size(167, 36);
            this.btnActualizarDB.TabIndex = 13;
            this.btnActualizarDB.Text = "Actualizar Calificacion";
            this.btnActualizarDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizarDB.Click += new System.EventHandler(this.btnActualizarDB_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(380, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 10;
            this.btnBuscar.Size = new System.Drawing.Size(110, 26);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpActualizarNota
            // 
            this.grpActualizarNota.Controls.Add(this.label9);
            this.grpActualizarNota.Controls.Add(this.label1);
            this.grpActualizarNota.Controls.Add(this.lblEstudiante);
            this.grpActualizarNota.Controls.Add(this.btnActualizarDB);
            this.grpActualizarNota.Controls.Add(this.dgvEstudianteNotas);
            this.grpActualizarNota.Location = new System.Drawing.Point(1090, 44);
            this.grpActualizarNota.Name = "grpActualizarNota";
            this.grpActualizarNota.Size = new System.Drawing.Size(396, 649);
            this.grpActualizarNota.TabIndex = 15;
            this.grpActualizarNota.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Asignar  Nota";
            // 
            // grpCrearNota
            // 
            this.grpCrearNota.Controls.Add(this.label4);
            this.grpCrearNota.Controls.Add(this.label3);
            this.grpCrearNota.Controls.Add(this.label2);
            this.grpCrearNota.Controls.Add(this.txtNombreNota);
            this.grpCrearNota.Controls.Add(this.btnRegistrar);
            this.grpCrearNota.Controls.Add(this.cmbAsignatura);
            this.grpCrearNota.Controls.Add(this.cmbCurso);
            this.grpCrearNota.Location = new System.Drawing.Point(12, 44);
            this.grpCrearNota.Name = "grpCrearNota";
            this.grpCrearNota.Size = new System.Drawing.Size(311, 169);
            this.grpCrearNota.TabIndex = 16;
            this.grpCrearNota.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Nota";
            // 
            // grpFiltroAsignatura
            // 
            this.grpFiltroAsignatura.Controls.Add(this.btnActualizarNota);
            this.grpFiltroAsignatura.Controls.Add(this.label5);
            this.grpFiltroAsignatura.Controls.Add(this.btnExportarAN);
            this.grpFiltroAsignatura.Controls.Add(this.cmbAsignaturaF);
            this.grpFiltroAsignatura.Controls.Add(this.dgvMostrarNEstudiantes);
            this.grpFiltroAsignatura.Controls.Add(this.cmbCursoF);
            this.grpFiltroAsignatura.Controls.Add(this.btnBuscar);
            this.grpFiltroAsignatura.Location = new System.Drawing.Point(399, 44);
            this.grpFiltroAsignatura.Name = "grpFiltroAsignatura";
            this.grpFiltroAsignatura.Size = new System.Drawing.Size(685, 649);
            this.grpFiltroAsignatura.TabIndex = 17;
            this.grpFiltroAsignatura.TabStop = false;
            // 
            // btnActualizarNota
            // 
            this.btnActualizarNota.AnimationHoverSpeed = 0.07F;
            this.btnActualizarNota.AnimationSpeed = 0.03F;
            this.btnActualizarNota.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarNota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnActualizarNota.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarNota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizarNota.FocusedColor = System.Drawing.Color.Empty;
            this.btnActualizarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarNota.ForeColor = System.Drawing.Color.White;
            this.btnActualizarNota.Image = null;
            this.btnActualizarNota.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizarNota.Location = new System.Drawing.Point(159, 514);
            this.btnActualizarNota.Name = "btnActualizarNota";
            this.btnActualizarNota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnActualizarNota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActualizarNota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActualizarNota.OnHoverImage = null;
            this.btnActualizarNota.OnPressedColor = System.Drawing.Color.Black;
            this.btnActualizarNota.Radius = 10;
            this.btnActualizarNota.Size = new System.Drawing.Size(127, 41);
            this.btnActualizarNota.TabIndex = 17;
            this.btnActualizarNota.Text = "Actualizar Notas";
            this.btnActualizarNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActualizarNota.Click += new System.EventHandler(this.btnActualizarNota_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fiiltro Asignatura Nota";
            // 
            // btnExportarAN
            // 
            this.btnExportarAN.AnimationHoverSpeed = 0.07F;
            this.btnExportarAN.AnimationSpeed = 0.03F;
            this.btnExportarAN.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarAN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnExportarAN.BorderColor = System.Drawing.Color.Black;
            this.btnExportarAN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarAN.FocusedColor = System.Drawing.Color.Empty;
            this.btnExportarAN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportarAN.ForeColor = System.Drawing.Color.White;
            this.btnExportarAN.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarAN.Image")));
            this.btnExportarAN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExportarAN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExportarAN.Location = new System.Drawing.Point(322, 514);
            this.btnExportarAN.Name = "btnExportarAN";
            this.btnExportarAN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExportarAN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportarAN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportarAN.OnHoverImage = null;
            this.btnExportarAN.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportarAN.Radius = 10;
            this.btnExportarAN.Size = new System.Drawing.Size(157, 41);
            this.btnExportarAN.TabIndex = 15;
            this.btnExportarAN.Text = "Exportar a Excel";
            this.btnExportarAN.Click += new System.EventHandler(this.btnExportarAN_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.AnimationHoverSpeed = 0.07F;
            this.btnCrear.AnimationSpeed = 0.03F;
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCrear.BorderColor = System.Drawing.Color.Black;
            this.btnCrear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCrear.FocusedColor = System.Drawing.Color.Empty;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Image = null;
            this.btnCrear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCrear.Location = new System.Drawing.Point(14, 21);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCrear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCrear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCrear.OnHoverImage = null;
            this.btnCrear.OnPressedColor = System.Drawing.Color.Black;
            this.btnCrear.Radius = 10;
            this.btnCrear.Size = new System.Drawing.Size(110, 26);
            this.btnCrear.TabIndex = 18;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(7, 219);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(110, 26);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar Nota";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grpEliminarNota
            // 
            this.grpEliminarNota.Controls.Add(this.btnMostarNotas);
            this.grpEliminarNota.Controls.Add(this.cmbNotaEliminar);
            this.grpEliminarNota.Controls.Add(this.label6);
            this.grpEliminarNota.Controls.Add(this.label7);
            this.grpEliminarNota.Controls.Add(this.label8);
            this.grpEliminarNota.Controls.Add(this.btnEliminarNota);
            this.grpEliminarNota.Controls.Add(this.cmbEliminarA);
            this.grpEliminarNota.Controls.Add(this.cmbEliminarC);
            this.grpEliminarNota.Location = new System.Drawing.Point(9, 251);
            this.grpEliminarNota.Name = "grpEliminarNota";
            this.grpEliminarNota.Size = new System.Drawing.Size(338, 169);
            this.grpEliminarNota.TabIndex = 20;
            this.grpEliminarNota.TabStop = false;
            // 
            // btnMostarNotas
            // 
            this.btnMostarNotas.AnimationHoverSpeed = 0.07F;
            this.btnMostarNotas.AnimationSpeed = 0.03F;
            this.btnMostarNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnMostarNotas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMostarNotas.BorderColor = System.Drawing.Color.Black;
            this.btnMostarNotas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostarNotas.FocusedColor = System.Drawing.Color.Empty;
            this.btnMostarNotas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostarNotas.ForeColor = System.Drawing.Color.White;
            this.btnMostarNotas.Image = null;
            this.btnMostarNotas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMostarNotas.Location = new System.Drawing.Point(221, 51);
            this.btnMostarNotas.Name = "btnMostarNotas";
            this.btnMostarNotas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMostarNotas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMostarNotas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMostarNotas.OnHoverImage = null;
            this.btnMostarNotas.OnPressedColor = System.Drawing.Color.Black;
            this.btnMostarNotas.Radius = 10;
            this.btnMostarNotas.Size = new System.Drawing.Size(110, 26);
            this.btnMostarNotas.TabIndex = 15;
            this.btnMostarNotas.Text = "Seleccionar";
            this.btnMostarNotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostarNotas.Click += new System.EventHandler(this.btnMostarNotas_Click);
            // 
            // cmbNotaEliminar
            // 
            this.cmbNotaEliminar.BackColor = System.Drawing.Color.Transparent;
            this.cmbNotaEliminar.BaseColor = System.Drawing.Color.White;
            this.cmbNotaEliminar.BorderColor = System.Drawing.Color.Silver;
            this.cmbNotaEliminar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNotaEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotaEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNotaEliminar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNotaEliminar.ForeColor = System.Drawing.Color.Black;
            this.cmbNotaEliminar.FormattingEnabled = true;
            this.cmbNotaEliminar.Location = new System.Drawing.Point(84, 89);
            this.cmbNotaEliminar.Name = "cmbNotaEliminar";
            this.cmbNotaEliminar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNotaEliminar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbNotaEliminar.Radius = 10;
            this.cmbNotaEliminar.Size = new System.Drawing.Size(131, 26);
            this.cmbNotaEliminar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Asignatura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Eliminar Nota";
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.AnimationHoverSpeed = 0.07F;
            this.btnEliminarNota.AnimationSpeed = 0.03F;
            this.btnEliminarNota.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarNota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminarNota.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarNota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarNota.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNota.ForeColor = System.Drawing.Color.White;
            this.btnEliminarNota.Image = null;
            this.btnEliminarNota.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarNota.Location = new System.Drawing.Point(84, 131);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarNota.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarNota.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarNota.OnHoverImage = null;
            this.btnEliminarNota.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarNota.Radius = 10;
            this.btnEliminarNota.Size = new System.Drawing.Size(110, 26);
            this.btnEliminarNota.TabIndex = 1;
            this.btnEliminarNota.Text = "Eliminar Nota";
            this.btnEliminarNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // cmbEliminarA
            // 
            this.cmbEliminarA.BackColor = System.Drawing.Color.Transparent;
            this.cmbEliminarA.BaseColor = System.Drawing.Color.White;
            this.cmbEliminarA.BorderColor = System.Drawing.Color.Silver;
            this.cmbEliminarA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEliminarA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarA.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEliminarA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEliminarA.ForeColor = System.Drawing.Color.Black;
            this.cmbEliminarA.FormattingEnabled = true;
            this.cmbEliminarA.Location = new System.Drawing.Point(84, 51);
            this.cmbEliminarA.Name = "cmbEliminarA";
            this.cmbEliminarA.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEliminarA.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEliminarA.Radius = 10;
            this.cmbEliminarA.Size = new System.Drawing.Size(131, 26);
            this.cmbEliminarA.TabIndex = 2;
            // 
            // cmbEliminarC
            // 
            this.cmbEliminarC.BackColor = System.Drawing.Color.Transparent;
            this.cmbEliminarC.BaseColor = System.Drawing.Color.White;
            this.cmbEliminarC.BorderColor = System.Drawing.Color.Silver;
            this.cmbEliminarC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEliminarC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarC.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEliminarC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEliminarC.ForeColor = System.Drawing.Color.Black;
            this.cmbEliminarC.FormattingEnabled = true;
            this.cmbEliminarC.Location = new System.Drawing.Point(84, 19);
            this.cmbEliminarC.Name = "cmbEliminarC";
            this.cmbEliminarC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEliminarC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEliminarC.Radius = 10;
            this.cmbEliminarC.Size = new System.Drawing.Size(83, 26);
            this.cmbEliminarC.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.AnimationHoverSpeed = 0.07F;
            this.btnModificar.AnimationSpeed = 0.03F;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificar.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(7, 426);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Radius = 10;
            this.btnModificar.Size = new System.Drawing.Size(110, 26);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar Nota";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grpModificarNota
            // 
            this.grpModificarNota.Controls.Add(this.label14);
            this.grpModificarNota.Controls.Add(this.label13);
            this.grpModificarNota.Controls.Add(this.txtNuevoNombre);
            this.grpModificarNota.Controls.Add(this.cmbEstado);
            this.grpModificarNota.Controls.Add(this.btnSeleccionarM);
            this.grpModificarNota.Controls.Add(this.cmbNotaModificar);
            this.grpModificarNota.Controls.Add(this.label10);
            this.grpModificarNota.Controls.Add(this.label11);
            this.grpModificarNota.Controls.Add(this.label12);
            this.grpModificarNota.Controls.Add(this.gunaButton4);
            this.grpModificarNota.Controls.Add(this.cmbModificarA);
            this.grpModificarNota.Controls.Add(this.cmbModificarC);
            this.grpModificarNota.Location = new System.Drawing.Point(5, 449);
            this.grpModificarNota.Name = "grpModificarNota";
            this.grpModificarNota.Size = new System.Drawing.Size(359, 244);
            this.grpModificarNota.TabIndex = 21;
            this.grpModificarNota.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nuevo Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Estado";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNuevoNombre.BaseColor = System.Drawing.Color.White;
            this.txtNuevoNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNuevoNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevoNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNuevoNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNuevoNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNuevoNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNuevoNombre.Location = new System.Drawing.Point(99, 124);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.PasswordChar = '\0';
            this.txtNuevoNombre.Radius = 10;
            this.txtNuevoNombre.SelectedText = "";
            this.txtNuevoNombre.Size = new System.Drawing.Size(134, 26);
            this.txtNuevoNombre.TabIndex = 25;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BaseColor = System.Drawing.Color.White;
            this.cmbEstado.BorderColor = System.Drawing.Color.Silver;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(96, 156);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEstado.Radius = 10;
            this.cmbEstado.Size = new System.Drawing.Size(137, 26);
            this.cmbEstado.TabIndex = 24;
            // 
            // btnSeleccionarM
            // 
            this.btnSeleccionarM.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionarM.AnimationSpeed = 0.03F;
            this.btnSeleccionarM.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSeleccionarM.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionarM.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionarM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarM.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarM.Image = null;
            this.btnSeleccionarM.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionarM.Location = new System.Drawing.Point(236, 60);
            this.btnSeleccionarM.Name = "btnSeleccionarM";
            this.btnSeleccionarM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSeleccionarM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarM.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionarM.OnHoverImage = null;
            this.btnSeleccionarM.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionarM.Radius = 10;
            this.btnSeleccionarM.Size = new System.Drawing.Size(110, 26);
            this.btnSeleccionarM.TabIndex = 23;
            this.btnSeleccionarM.Text = "Seleccionar";
            this.btnSeleccionarM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionarM.Click += new System.EventHandler(this.btnSeleccionarM_Click);
            // 
            // cmbNotaModificar
            // 
            this.cmbNotaModificar.BackColor = System.Drawing.Color.Transparent;
            this.cmbNotaModificar.BaseColor = System.Drawing.Color.White;
            this.cmbNotaModificar.BorderColor = System.Drawing.Color.Silver;
            this.cmbNotaModificar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNotaModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotaModificar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNotaModificar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNotaModificar.ForeColor = System.Drawing.Color.Black;
            this.cmbNotaModificar.FormattingEnabled = true;
            this.cmbNotaModificar.Location = new System.Drawing.Point(99, 92);
            this.cmbNotaModificar.Name = "cmbNotaModificar";
            this.cmbNotaModificar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNotaModificar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbNotaModificar.Radius = 10;
            this.cmbNotaModificar.Size = new System.Drawing.Size(134, 26);
            this.cmbNotaModificar.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Asignatura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Curso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nota ";
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
            this.gunaButton4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = null;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(117, 197);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(161, 26);
            this.gunaButton4.TabIndex = 16;
            this.gunaButton4.Text = "Modificar Nota";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // cmbModificarA
            // 
            this.cmbModificarA.BackColor = System.Drawing.Color.Transparent;
            this.cmbModificarA.BaseColor = System.Drawing.Color.White;
            this.cmbModificarA.BorderColor = System.Drawing.Color.Silver;
            this.cmbModificarA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModificarA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarA.FocusedColor = System.Drawing.Color.Empty;
            this.cmbModificarA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModificarA.ForeColor = System.Drawing.Color.Black;
            this.cmbModificarA.FormattingEnabled = true;
            this.cmbModificarA.Location = new System.Drawing.Point(99, 60);
            this.cmbModificarA.Name = "cmbModificarA";
            this.cmbModificarA.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbModificarA.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbModificarA.Radius = 10;
            this.cmbModificarA.Size = new System.Drawing.Size(131, 26);
            this.cmbModificarA.TabIndex = 17;
            // 
            // cmbModificarC
            // 
            this.cmbModificarC.BackColor = System.Drawing.Color.Transparent;
            this.cmbModificarC.BaseColor = System.Drawing.Color.White;
            this.cmbModificarC.BorderColor = System.Drawing.Color.Silver;
            this.cmbModificarC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModificarC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarC.FocusedColor = System.Drawing.Color.Empty;
            this.cmbModificarC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModificarC.ForeColor = System.Drawing.Color.Black;
            this.cmbModificarC.FormattingEnabled = true;
            this.cmbModificarC.Location = new System.Drawing.Point(99, 19);
            this.cmbModificarC.Name = "cmbModificarC";
            this.cmbModificarC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbModificarC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbModificarC.Radius = 10;
            this.cmbModificarC.Size = new System.Drawing.Size(131, 26);
            this.cmbModificarC.TabIndex = 18;
            // 
            // frmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1781, 801);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grpModificarNota);
            this.Controls.Add(this.grpEliminarNota);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grpFiltroAsignatura);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.grpActualizarNota);
            this.Controls.Add(this.grpCrearNota);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNota";
            this.Text = "frmNota";
            this.Load += new System.EventHandler(this.frmNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteNotas)).EndInit();
            this.grpActualizarNota.ResumeLayout(false);
            this.grpActualizarNota.PerformLayout();
            this.grpCrearNota.ResumeLayout(false);
            this.grpCrearNota.PerformLayout();
            this.grpFiltroAsignatura.ResumeLayout(false);
            this.grpFiltroAsignatura.PerformLayout();
            this.grpEliminarNota.ResumeLayout(false);
            this.grpEliminarNota.PerformLayout();
            this.grpModificarNota.ResumeLayout(false);
            this.grpModificarNota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtNombreNota;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaComboBox cmbAsignatura;
        private Guna.UI.WinForms.GunaComboBox cmbCurso;
        private System.Windows.Forms.DataGridView dgvMostrarNEstudiantes;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbAsignaturaF;
        private Guna.UI.WinForms.GunaComboBox cmbCursoF;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudianteNotas;
        private Guna.UI.WinForms.GunaButton btnActualizarDB;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private System.Windows.Forms.GroupBox grpActualizarNota;
        private System.Windows.Forms.GroupBox grpCrearNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpFiltroAsignatura;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btnExportarAN;
        private Guna.UI.WinForms.GunaButton btnActualizarNota;
        private Guna.UI.WinForms.GunaButton btnCrear;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private System.Windows.Forms.GroupBox grpEliminarNota;
        private Guna.UI.WinForms.GunaButton btnMostarNotas;
        private Guna.UI.WinForms.GunaComboBox cmbNotaEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btnEliminarNota;
        private Guna.UI.WinForms.GunaComboBox cmbEliminarA;
        private Guna.UI.WinForms.GunaComboBox cmbEliminarC;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btnModificar;
        private System.Windows.Forms.GroupBox grpModificarNota;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaTextBox txtNuevoNombre;
        private Guna.UI.WinForms.GunaComboBox cmbEstado;
        private Guna.UI.WinForms.GunaButton btnSeleccionarM;
        private Guna.UI.WinForms.GunaComboBox cmbNotaModificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaComboBox cmbModificarA;
        private Guna.UI.WinForms.GunaComboBox cmbModificarC;
        private System.Windows.Forms.Label label14;
    }
}