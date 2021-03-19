
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
            this.lblNota = new System.Windows.Forms.Label();
            this.txtCalificacion = new Guna.UI.WinForms.GunaTextBox();
            this.btnCambiarN = new Guna.UI.WinForms.GunaButton();
            this.btnActualizarDB = new Guna.UI.WinForms.GunaButton();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.grpActualizarNota = new System.Windows.Forms.GroupBox();
            this.grpCrearNota = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFiltroAsignatura = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportarAN = new Guna.UI.WinForms.GunaButton();
            this.grpImportar = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteNotas)).BeginInit();
            this.grpActualizarNota.SuspendLayout();
            this.grpCrearNota.SuspendLayout();
            this.grpFiltroAsignatura.SuspendLayout();
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
            this.dgvMostrarNEstudiantes.Location = new System.Drawing.Point(12, 149);
            this.dgvMostrarNEstudiantes.Name = "dgvMostrarNEstudiantes";
            this.dgvMostrarNEstudiantes.Size = new System.Drawing.Size(495, 230);
            this.dgvMostrarNEstudiantes.TabIndex = 4;
            this.dgvMostrarNEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarNEstudiantes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
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
            this.cmbAsignaturaF.Location = new System.Drawing.Point(196, 117);
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
            this.cmbCursoF.Location = new System.Drawing.Point(59, 117);
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
            this.lblEstudiante.Location = new System.Drawing.Point(104, 48);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(60, 13);
            this.lblEstudiante.TabIndex = 8;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // dgvEstudianteNotas
            // 
            this.dgvEstudianteNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudianteNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudianteNotas.Location = new System.Drawing.Point(6, 64);
            this.dgvEstudianteNotas.Name = "dgvEstudianteNotas";
            this.dgvEstudianteNotas.Size = new System.Drawing.Size(246, 141);
            this.dgvEstudianteNotas.TabIndex = 9;
            this.dgvEstudianteNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudianteNotas_CellContentClick);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(104, 224);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 10;
            this.lblNota.Text = "Nota";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.BackColor = System.Drawing.Color.Transparent;
            this.txtCalificacion.BaseColor = System.Drawing.Color.White;
            this.txtCalificacion.BorderColor = System.Drawing.Color.Silver;
            this.txtCalificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalificacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCalificacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCalificacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCalificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCalificacion.Location = new System.Drawing.Point(61, 252);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.PasswordChar = '\0';
            this.txtCalificacion.Radius = 10;
            this.txtCalificacion.SelectedText = "";
            this.txtCalificacion.Size = new System.Drawing.Size(90, 26);
            this.txtCalificacion.TabIndex = 11;
            // 
            // btnCambiarN
            // 
            this.btnCambiarN.AnimationHoverSpeed = 0.07F;
            this.btnCambiarN.AnimationSpeed = 0.03F;
            this.btnCambiarN.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCambiarN.BorderColor = System.Drawing.Color.Black;
            this.btnCambiarN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambiarN.FocusedColor = System.Drawing.Color.Empty;
            this.btnCambiarN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarN.ForeColor = System.Drawing.Color.White;
            this.btnCambiarN.Image = null;
            this.btnCambiarN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCambiarN.Location = new System.Drawing.Point(157, 252);
            this.btnCambiarN.Name = "btnCambiarN";
            this.btnCambiarN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCambiarN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCambiarN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCambiarN.OnHoverImage = null;
            this.btnCambiarN.OnPressedColor = System.Drawing.Color.Black;
            this.btnCambiarN.Radius = 10;
            this.btnCambiarN.Size = new System.Drawing.Size(70, 26);
            this.btnCambiarN.TabIndex = 12;
            this.btnCambiarN.Text = "Cambiar";
            this.btnCambiarN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCambiarN.Click += new System.EventHandler(this.btnCambiarN_Click);
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
            this.btnActualizarDB.Location = new System.Drawing.Point(6, 284);
            this.btnActualizarDB.Name = "btnActualizarDB";
            this.btnActualizarDB.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnActualizarDB.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActualizarDB.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActualizarDB.OnHoverImage = null;
            this.btnActualizarDB.OnPressedColor = System.Drawing.Color.Black;
            this.btnActualizarDB.Radius = 10;
            this.btnActualizarDB.Size = new System.Drawing.Size(145, 26);
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
            this.btnBuscar.Location = new System.Drawing.Point(316, 117);
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
            this.grpActualizarNota.Controls.Add(this.grpImportar);
            this.grpActualizarNota.Controls.Add(this.label1);
            this.grpActualizarNota.Controls.Add(this.lblEstudiante);
            this.grpActualizarNota.Controls.Add(this.btnActualizarDB);
            this.grpActualizarNota.Controls.Add(this.dgvEstudianteNotas);
            this.grpActualizarNota.Controls.Add(this.btnCambiarN);
            this.grpActualizarNota.Controls.Add(this.lblNota);
            this.grpActualizarNota.Controls.Add(this.txtCalificacion);
            this.grpActualizarNota.Location = new System.Drawing.Point(21, 199);
            this.grpActualizarNota.Name = "grpActualizarNota";
            this.grpActualizarNota.Size = new System.Drawing.Size(322, 344);
            this.grpActualizarNota.TabIndex = 15;
            this.grpActualizarNota.TabStop = false;
            this.grpActualizarNota.Text = "Actualizar Nota";
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
            this.grpCrearNota.Location = new System.Drawing.Point(32, 24);
            this.grpCrearNota.Name = "grpCrearNota";
            this.grpCrearNota.Size = new System.Drawing.Size(311, 169);
            this.grpCrearNota.TabIndex = 16;
            this.grpCrearNota.TabStop = false;
            this.grpCrearNota.Text = "Crear Nota";
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
            this.grpFiltroAsignatura.Controls.Add(this.label5);
            this.grpFiltroAsignatura.Controls.Add(this.btnExportarAN);
            this.grpFiltroAsignatura.Controls.Add(this.cmbAsignaturaF);
            this.grpFiltroAsignatura.Controls.Add(this.dgvMostrarNEstudiantes);
            this.grpFiltroAsignatura.Controls.Add(this.cmbCursoF);
            this.grpFiltroAsignatura.Controls.Add(this.btnBuscar);
            this.grpFiltroAsignatura.Location = new System.Drawing.Point(349, 34);
            this.grpFiltroAsignatura.Name = "grpFiltroAsignatura";
            this.grpFiltroAsignatura.Size = new System.Drawing.Size(534, 509);
            this.grpFiltroAsignatura.TabIndex = 17;
            this.grpFiltroAsignatura.TabStop = false;
            this.grpFiltroAsignatura.Text = "Filtro Asigntura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 60);
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
            this.btnExportarAN.Location = new System.Drawing.Point(196, 399);
            this.btnExportarAN.Name = "btnExportarAN";
            this.btnExportarAN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExportarAN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportarAN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportarAN.OnHoverImage = null;
            this.btnExportarAN.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportarAN.Radius = 10;
            this.btnExportarAN.Size = new System.Drawing.Size(140, 26);
            this.btnExportarAN.TabIndex = 15;
            this.btnExportarAN.Text = "Exportar a Excel";
            this.btnExportarAN.Click += new System.EventHandler(this.btnExportarAN_Click);
            // 
            // grpImportar
            // 
            this.grpImportar.AnimationHoverSpeed = 0.07F;
            this.grpImportar.AnimationSpeed = 0.03F;
            this.grpImportar.BackColor = System.Drawing.Color.Transparent;
            this.grpImportar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grpImportar.BorderColor = System.Drawing.Color.Black;
            this.grpImportar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.grpImportar.FocusedColor = System.Drawing.Color.Empty;
            this.grpImportar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpImportar.ForeColor = System.Drawing.Color.White;
            this.grpImportar.Image = ((System.Drawing.Image)(resources.GetObject("grpImportar.Image")));
            this.grpImportar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.grpImportar.ImageSize = new System.Drawing.Size(20, 20);
            this.grpImportar.Location = new System.Drawing.Point(157, 284);
            this.grpImportar.Name = "grpImportar";
            this.grpImportar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.grpImportar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.grpImportar.OnHoverForeColor = System.Drawing.Color.White;
            this.grpImportar.OnHoverImage = null;
            this.grpImportar.OnPressedColor = System.Drawing.Color.Black;
            this.grpImportar.Radius = 10;
            this.grpImportar.Size = new System.Drawing.Size(140, 26);
            this.grpImportar.TabIndex = 17;
            this.grpImportar.Text = "Importar  Excel";
            this.grpImportar.Click += new System.EventHandler(this.grpImportar_Click);
            // 
            // frmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 675);
            this.Controls.Add(this.grpFiltroAsignatura);
            this.Controls.Add(this.grpCrearNota);
            this.Controls.Add(this.grpActualizarNota);
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
        private System.Windows.Forms.Label lblNota;
        private Guna.UI.WinForms.GunaTextBox txtCalificacion;
        private Guna.UI.WinForms.GunaButton btnCambiarN;
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
        private Guna.UI.WinForms.GunaButton grpImportar;
    }
}