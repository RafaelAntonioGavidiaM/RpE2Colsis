﻿namespace appE2Colsis.Vista
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
            this.components = new System.ComponentModel.Container();
            this.lblRol = new Guna.UI.WinForms.GunaLabel();
            this.txtRol = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.grpCrear = new System.Windows.Forms.GroupBox();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.btnOk = new Guna.UI.WinForms.GunaButton();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.cmbDecision = new System.Windows.Forms.ComboBox();
            this.btnPermisos = new Guna.UI.WinForms.GunaButton();
            this.grpEliminarRol = new System.Windows.Forms.GroupBox();
            this.dgvSeleccionar = new System.Windows.Forms.GroupBox();
            this.dgvContenidoRol = new System.Windows.Forms.DataGridView();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.btnSeleccionar = new Guna.UI.WinForms.GunaButton();
            this.cmbRol = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.grpSeccionMod = new System.Windows.Forms.GroupBox();
            this.txtModificar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.cmbMod = new System.Windows.Forms.ComboBox();
            this.lblMrol = new Guna.UI.WinForms.GunaLabel();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.lblFrmModificar = new System.Windows.Forms.Label();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnModifica = new Guna.UI.WinForms.GunaButton();
            this.btnModificarRegistros = new Guna.UI.WinForms.GunaButton();
            this.btnSeleccionMod = new Guna.UI.WinForms.GunaButton();
            this.cmbModificar = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbFiltrar = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dgvDatosPersona = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crear = new Guna.UI.WinForms.GunaButton();
            this.Modificar = new Guna.UI.WinForms.GunaButton();
            this.Eliminar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.grpCrear.SuspendLayout();
            this.grpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.grpEliminarRol.SuspendLayout();
            this.dgvSeleccionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoRol)).BeginInit();
            this.grpModificar.SuspendLayout();
            this.grpSeccionMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(16, 71);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(106, 21);
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
            this.txtRol.Location = new System.Drawing.Point(137, 71);
            this.txtRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.Radius = 10;
            this.txtRol.SelectedText = "";
            this.txtRol.Size = new System.Drawing.Size(164, 37);
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
            this.gunaButton1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(80, 112);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(92, 38);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Crear Rol";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // grpCrear
            // 
            this.grpCrear.Controls.Add(this.grpPermisos);
            this.grpCrear.Controls.Add(this.btnPermisos);
            this.grpCrear.Controls.Add(this.gunaButton1);
            this.grpCrear.Controls.Add(this.lblRol);
            this.grpCrear.Controls.Add(this.txtRol);
            this.grpCrear.Location = new System.Drawing.Point(16, 212);
            this.grpCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCrear.Name = "grpCrear";
            this.grpCrear.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCrear.Size = new System.Drawing.Size(416, 549);
            this.grpCrear.TabIndex = 3;
            this.grpCrear.TabStop = false;
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.btnOk);
            this.grpPermisos.Controls.Add(this.dgvMostrar);
            this.grpPermisos.Controls.Add(this.gunaButton2);
            this.grpPermisos.Controls.Add(this.lblFormulario);
            this.grpPermisos.Controls.Add(this.cmbDecision);
            this.grpPermisos.Location = new System.Drawing.Point(12, 158);
            this.grpPermisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPermisos.Size = new System.Drawing.Size(363, 337);
            this.grpPermisos.TabIndex = 20;
            this.grpPermisos.TabStop = false;
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
            this.btnOk.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = null;
            this.btnOk.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOk.Location = new System.Drawing.Point(271, 188);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOk.OnHoverImage = null;
            this.btnOk.OnPressedColor = System.Drawing.Color.Black;
            this.btnOk.Radius = 10;
            this.btnOk.Size = new System.Drawing.Size(84, 36);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "Definir";
            this.btnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 22);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.Size = new System.Drawing.Size(327, 145);
            this.dgvMostrar.TabIndex = 18;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
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
            this.gunaButton2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(89, 267);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(143, 36);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Text = "Asignar Permisos";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click_1);
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Location = new System.Drawing.Point(8, 194);
            this.lblFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(46, 17);
            this.lblFormulario.TabIndex = 9;
            this.lblFormulario.Text = "label1";
            // 
            // cmbDecision
            // 
            this.cmbDecision.FormattingEnabled = true;
            this.cmbDecision.Location = new System.Drawing.Point(101, 194);
            this.cmbDecision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDecision.Name = "cmbDecision";
            this.cmbDecision.Size = new System.Drawing.Size(160, 24);
            this.cmbDecision.TabIndex = 10;
            // 
            // btnPermisos
            // 
            this.btnPermisos.AnimationHoverSpeed = 0.07F;
            this.btnPermisos.AnimationSpeed = 0.03F;
            this.btnPermisos.BackColor = System.Drawing.Color.Transparent;
            this.btnPermisos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPermisos.BorderColor = System.Drawing.Color.Black;
            this.btnPermisos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPermisos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPermisos.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.ForeColor = System.Drawing.Color.White;
            this.btnPermisos.Image = null;
            this.btnPermisos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPermisos.Location = new System.Drawing.Point(180, 114);
            this.btnPermisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPermisos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPermisos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPermisos.OnHoverImage = null;
            this.btnPermisos.OnPressedColor = System.Drawing.Color.Black;
            this.btnPermisos.Radius = 10;
            this.btnPermisos.Size = new System.Drawing.Size(143, 36);
            this.btnPermisos.TabIndex = 8;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPermisos.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // grpEliminarRol
            // 
            this.grpEliminarRol.Controls.Add(this.dgvSeleccionar);
            this.grpEliminarRol.Controls.Add(this.btnSeleccionar);
            this.grpEliminarRol.Controls.Add(this.cmbRol);
            this.grpEliminarRol.Controls.Add(this.gunaLabel1);
            this.grpEliminarRol.Location = new System.Drawing.Point(1347, 212);
            this.grpEliminarRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEliminarRol.Name = "grpEliminarRol";
            this.grpEliminarRol.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEliminarRol.Size = new System.Drawing.Size(415, 549);
            this.grpEliminarRol.TabIndex = 4;
            this.grpEliminarRol.TabStop = false;
            // 
            // dgvSeleccionar
            // 
            this.dgvSeleccionar.Controls.Add(this.dgvContenidoRol);
            this.dgvSeleccionar.Controls.Add(this.gunaLabel2);
            this.dgvSeleccionar.Controls.Add(this.gunaButton4);
            this.dgvSeleccionar.Location = new System.Drawing.Point(8, 180);
            this.dgvSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSeleccionar.Name = "dgvSeleccionar";
            this.dgvSeleccionar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSeleccionar.Size = new System.Drawing.Size(353, 302);
            this.dgvSeleccionar.TabIndex = 8;
            this.dgvSeleccionar.TabStop = false;
            // 
            // dgvContenidoRol
            // 
            this.dgvContenidoRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContenidoRol.Location = new System.Drawing.Point(25, 43);
            this.dgvContenidoRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvContenidoRol.Name = "dgvContenidoRol";
            this.dgvContenidoRol.RowHeadersWidth = 51;
            this.dgvContenidoRol.Size = new System.Drawing.Size(320, 159);
            this.dgvContenidoRol.TabIndex = 20;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(8, 14);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(268, 20);
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
            this.gunaButton4.Location = new System.Drawing.Point(105, 242);
            this.gunaButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 10;
            this.gunaButton4.Size = new System.Drawing.Size(92, 38);
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
            this.btnSeleccionar.Location = new System.Drawing.Point(33, 134);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnHoverImage = null;
            this.btnSeleccionar.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Radius = 10;
            this.btnSeleccionar.Size = new System.Drawing.Size(92, 38);
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
            this.cmbRol.Location = new System.Drawing.Point(33, 95);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRol.Size = new System.Drawing.Size(199, 31);
            this.cmbRol.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(29, 60);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(195, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Seleccione el Rol a eliminar:";
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.grpSeccionMod);
            this.grpModificar.Controls.Add(this.btnSeleccionMod);
            this.grpModificar.Controls.Add(this.cmbModificar);
            this.grpModificar.Controls.Add(this.gunaLabel3);
            this.grpModificar.Location = new System.Drawing.Point(1347, 212);
            this.grpModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModificar.Size = new System.Drawing.Size(415, 549);
            this.grpModificar.TabIndex = 5;
            this.grpModificar.TabStop = false;
            this.grpModificar.Enter += new System.EventHandler(this.grpModificar_Enter);
            // 
            // grpSeccionMod
            // 
            this.grpSeccionMod.Controls.Add(this.txtModificar);
            this.grpSeccionMod.Controls.Add(this.gunaLabel7);
            this.grpSeccionMod.Controls.Add(this.cmbMod);
            this.grpSeccionMod.Controls.Add(this.lblMrol);
            this.grpSeccionMod.Controls.Add(this.dgvModificar);
            this.grpSeccionMod.Controls.Add(this.gunaButton5);
            this.grpSeccionMod.Controls.Add(this.lblFrmModificar);
            this.grpSeccionMod.Controls.Add(this.gunaLabel4);
            this.grpSeccionMod.Controls.Add(this.btnModifica);
            this.grpSeccionMod.Controls.Add(this.btnModificarRegistros);
            this.grpSeccionMod.Location = new System.Drawing.Point(8, 103);
            this.grpSeccionMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSeccionMod.Name = "grpSeccionMod";
            this.grpSeccionMod.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSeccionMod.Size = new System.Drawing.Size(399, 431);
            this.grpSeccionMod.TabIndex = 30;
            this.grpSeccionMod.TabStop = false;
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
            this.txtModificar.Location = new System.Drawing.Point(132, 54);
            this.txtModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.PasswordChar = '\0';
            this.txtModificar.Radius = 10;
            this.txtModificar.SelectedText = "";
            this.txtModificar.Size = new System.Drawing.Size(164, 37);
            this.txtModificar.TabIndex = 25;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(67, 20);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(140, 21);
            this.gunaLabel7.TabIndex = 28;
            this.gunaLabel7.Text = " Rol a Modificar";
            // 
            // cmbMod
            // 
            this.cmbMod.FormattingEnabled = true;
            this.cmbMod.Location = new System.Drawing.Point(137, 306);
            this.cmbMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMod.Name = "cmbMod";
            this.cmbMod.Size = new System.Drawing.Size(160, 24);
            this.cmbMod.TabIndex = 21;
            // 
            // lblMrol
            // 
            this.lblMrol.AutoSize = true;
            this.lblMrol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMrol.Location = new System.Drawing.Point(261, 20);
            this.lblMrol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMrol.Name = "lblMrol";
            this.lblMrol.Size = new System.Drawing.Size(34, 21);
            this.lblMrol.TabIndex = 27;
            this.lblMrol.Text = "Rol";
            // 
            // dgvModificar
            // 
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(43, 119);
            this.dgvModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.RowHeadersWidth = 51;
            this.dgvModificar.Size = new System.Drawing.Size(325, 145);
            this.dgvModificar.TabIndex = 19;
            this.dgvModificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.gunaButton5.Location = new System.Drawing.Point(304, 50);
            this.gunaButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 10;
            this.gunaButton5.Size = new System.Drawing.Size(97, 36);
            this.gunaButton5.TabIndex = 26;
            this.gunaButton5.Text = "Renombrar";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // lblFrmModificar
            // 
            this.lblFrmModificar.AutoSize = true;
            this.lblFrmModificar.Location = new System.Drawing.Point(27, 316);
            this.lblFrmModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmModificar.Name = "lblFrmModificar";
            this.lblFrmModificar.Size = new System.Drawing.Size(46, 17);
            this.lblFrmModificar.TabIndex = 20;
            this.lblFrmModificar.Text = "label1";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(11, 65);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(106, 21);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Nombre Rol";
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
            this.btnModifica.Location = new System.Drawing.Point(307, 300);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModifica.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifica.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifica.OnHoverImage = null;
            this.btnModifica.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifica.Radius = 10;
            this.btnModifica.Size = new System.Drawing.Size(84, 36);
            this.btnModifica.TabIndex = 22;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
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
            this.btnModificarRegistros.Location = new System.Drawing.Point(116, 386);
            this.btnModificarRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificarRegistros.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarRegistros.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarRegistros.OnHoverImage = null;
            this.btnModificarRegistros.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarRegistros.Radius = 10;
            this.btnModificarRegistros.Size = new System.Drawing.Size(143, 36);
            this.btnModificarRegistros.TabIndex = 23;
            this.btnModificarRegistros.Text = "Modificar Rol";
            this.btnModificarRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarRegistros.Click += new System.EventHandler(this.btnModificarRegistros_Click);
            // 
            // btnSeleccionMod
            // 
            this.btnSeleccionMod.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionMod.AnimationSpeed = 0.03F;
            this.btnSeleccionMod.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionMod.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSeleccionMod.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionMod.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionMod.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionMod.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionMod.Image = null;
            this.btnSeleccionMod.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionMod.Location = new System.Drawing.Point(245, 60);
            this.btnSeleccionMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionMod.Name = "btnSeleccionMod";
            this.btnSeleccionMod.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSeleccionMod.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionMod.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionMod.OnHoverImage = null;
            this.btnSeleccionMod.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionMod.Radius = 10;
            this.btnSeleccionMod.Size = new System.Drawing.Size(97, 36);
            this.btnSeleccionMod.TabIndex = 29;
            this.btnSeleccionMod.Text = "Modificar";
            this.btnSeleccionMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionMod.Click += new System.EventHandler(this.btnSeleccionMod_Click);
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
            this.cmbModificar.Location = new System.Drawing.Point(27, 64);
            this.cmbModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbModificar.Name = "cmbModificar";
            this.cmbModificar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbModificar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbModificar.Size = new System.Drawing.Size(209, 31);
            this.cmbModificar.TabIndex = 2;
            this.cmbModificar.SelectedIndexChanged += new System.EventHandler(this.cmbModificar_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(23, 42);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(205, 20);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Seleccione el Rol a modificar:";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltrar.BaseColor = System.Drawing.Color.White;
            this.cmbFiltrar.BorderColor = System.Drawing.Color.Silver;
            this.cmbFiltrar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltrar.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(771, 102);
            this.cmbFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFiltrar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFiltrar.Size = new System.Drawing.Size(191, 31);
            this.cmbFiltrar.TabIndex = 6;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(614, 97);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(149, 36);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Filtrar por Rol:";
            // 
            // dgvDatosPersona
            // 
            this.dgvDatosPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.documento,
            this.telefono,
            this.ciudad,
            this.estado});
            this.dgvDatosPersona.Location = new System.Drawing.Point(451, 212);
            this.dgvDatosPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatosPersona.Name = "dgvDatosPersona";
            this.dgvDatosPersona.RowHeadersWidth = 51;
            this.dgvDatosPersona.Size = new System.Drawing.Size(856, 549);
            this.dgvDatosPersona.TabIndex = 8;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.Width = 125;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 125;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.MinimumWidth = 6;
            this.ciudad.Name = "ciudad";
            this.ciudad.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado Persona";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // Crear
            // 
            this.Crear.AnimationHoverSpeed = 0.07F;
            this.Crear.AnimationSpeed = 0.03F;
            this.Crear.BackColor = System.Drawing.Color.Transparent;
            this.Crear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Crear.BorderColor = System.Drawing.Color.Black;
            this.Crear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Crear.FocusedColor = System.Drawing.Color.Empty;
            this.Crear.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear.ForeColor = System.Drawing.Color.White;
            this.Crear.Image = null;
            this.Crear.ImageSize = new System.Drawing.Size(20, 20);
            this.Crear.Location = new System.Drawing.Point(222, 150);
            this.Crear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Crear.Name = "Crear";
            this.Crear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Crear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Crear.OnHoverForeColor = System.Drawing.Color.White;
            this.Crear.OnHoverImage = null;
            this.Crear.OnPressedColor = System.Drawing.Color.Black;
            this.Crear.Radius = 10;
            this.Crear.Size = new System.Drawing.Size(102, 30);
            this.Crear.TabIndex = 9;
            this.Crear.Text = "Crear Rol";
            this.Crear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Modificar
            // 
            this.Modificar.AnimationHoverSpeed = 0.07F;
            this.Modificar.AnimationSpeed = 0.03F;
            this.Modificar.BackColor = System.Drawing.Color.Transparent;
            this.Modificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Modificar.BorderColor = System.Drawing.Color.Black;
            this.Modificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Modificar.FocusedColor = System.Drawing.Color.Empty;
            this.Modificar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.White;
            this.Modificar.Image = null;
            this.Modificar.ImageSize = new System.Drawing.Size(20, 20);
            this.Modificar.Location = new System.Drawing.Point(332, 150);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Modificar.Name = "Modificar";
            this.Modificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Modificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Modificar.OnHoverForeColor = System.Drawing.Color.White;
            this.Modificar.OnHoverImage = null;
            this.Modificar.OnPressedColor = System.Drawing.Color.Black;
            this.Modificar.Radius = 10;
            this.Modificar.Size = new System.Drawing.Size(158, 30);
            this.Modificar.TabIndex = 24;
            this.Modificar.Text = "Modificar Rol";
            this.Modificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.AnimationHoverSpeed = 0.07F;
            this.Eliminar.AnimationSpeed = 0.03F;
            this.Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Eliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Eliminar.BorderColor = System.Drawing.Color.Black;
            this.Eliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Eliminar.FocusedColor = System.Drawing.Color.Empty;
            this.Eliminar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.Image = null;
            this.Eliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.Eliminar.Location = new System.Drawing.Point(513, 150);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.Eliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Eliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.Eliminar.OnHoverImage = null;
            this.Eliminar.OnPressedColor = System.Drawing.Color.Black;
            this.Eliminar.Radius = 10;
            this.Eliminar.Size = new System.Drawing.Size(116, 30);
            this.Eliminar.TabIndex = 25;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(84, 144);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(104, 36);
            this.gunaLabel6.TabIndex = 26;
            this.gunaLabel6.Text = "Opciones:";
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1847, 927);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpEliminarRol);
            this.Controls.Add(this.dgvDatosPersona);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.grpCrear);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRol";
            this.Text = "frmRol";
            this.Load += new System.EventHandler(this.frmRol_Load_1);
            this.grpCrear.ResumeLayout(false);
            this.grpCrear.PerformLayout();
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.grpEliminarRol.ResumeLayout(false);
            this.grpEliminarRol.PerformLayout();
            this.dgvSeleccionar.ResumeLayout(false);
            this.dgvSeleccionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoRol)).EndInit();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            this.grpSeccionMod.ResumeLayout(false);
            this.grpSeccionMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblRol;
        private Guna.UI.WinForms.GunaTextBox txtRol;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.GroupBox grpCrear;
        private Guna.UI.WinForms.GunaButton btnPermisos;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.GroupBox grpEliminarRol;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnSeleccionar;
        private Guna.UI.WinForms.GunaComboBox cmbRol;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private System.Windows.Forms.DataGridView dgvModificar;
        private System.Windows.Forms.ComboBox cmbMod;
        private Guna.UI.WinForms.GunaComboBox cmbModificar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaComboBox cmbFiltrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.DataGridView dgvDatosPersona;
        private Guna.UI.WinForms.GunaButton Crear;
        private Guna.UI.WinForms.GunaButton Modificar;
        private Guna.UI.WinForms.GunaButton Eliminar;
        private Guna.UI.WinForms.GunaLabel lblMrol;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private System.Windows.Forms.DataGridView dgvContenidoRol;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.GroupBox grpSeccionMod;
        private Guna.UI.WinForms.GunaButton btnSeleccionMod;
    }
}