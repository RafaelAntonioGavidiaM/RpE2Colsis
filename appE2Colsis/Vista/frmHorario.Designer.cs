﻿
namespace appE2Colsis.Vista
{
    partial class frmHorario
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
            this.btnOpcionEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnOpcionModificar = new Guna.UI.WinForms.GunaButton();
            this.btnOpcionCrear = new Guna.UI.WinForms.GunaButton();
            this.grpHorario = new System.Windows.Forms.GroupBox();
            this.cmbAsignatura = new Guna.UI.WinForms.GunaComboBox();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.cmbCurso = new Guna.UI.WinForms.GunaComboBox();
            this.lbCurso = new Guna.UI.WinForms.GunaLabel();
            this.cmbModificarDia = new Guna.UI.WinForms.GunaComboBox();
            this.lblAsignatura = new Guna.UI.WinForms.GunaLabel();
            this.btnModificar = new Guna.UI.WinForms.GunaButton();
            this.cmbDia = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txthInicio = new Guna.UI.WinForms.GunaTextBox();
            this.txthFinal = new Guna.UI.WinForms.GunaTextBox();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cmbCursoFiltrar = new Guna.UI.WinForms.GunaComboBox();
            this.lbHorario = new Guna.UI.WinForms.GunaLabel();
            this.grpHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpcionEliminar
            // 
            this.btnOpcionEliminar.AnimationHoverSpeed = 0.07F;
            this.btnOpcionEliminar.AnimationSpeed = 0.03F;
            this.btnOpcionEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOpcionEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnOpcionEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpcionEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpcionEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpcionEliminar.ForeColor = System.Drawing.Color.White;
            this.btnOpcionEliminar.Image = null;
            this.btnOpcionEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpcionEliminar.Location = new System.Drawing.Point(225, 88);
            this.btnOpcionEliminar.Name = "btnOpcionEliminar";
            this.btnOpcionEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOpcionEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpcionEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpcionEliminar.OnHoverImage = null;
            this.btnOpcionEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpcionEliminar.Size = new System.Drawing.Size(69, 32);
            this.btnOpcionEliminar.TabIndex = 32;
            this.btnOpcionEliminar.Text = "Eliminar";
            this.btnOpcionEliminar.Click += new System.EventHandler(this.btnOpcionEliminar_Click);
            // 
            // btnOpcionModificar
            // 
            this.btnOpcionModificar.AnimationHoverSpeed = 0.07F;
            this.btnOpcionModificar.AnimationSpeed = 0.03F;
            this.btnOpcionModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOpcionModificar.BorderColor = System.Drawing.Color.Black;
            this.btnOpcionModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpcionModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpcionModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpcionModificar.ForeColor = System.Drawing.Color.White;
            this.btnOpcionModificar.Image = null;
            this.btnOpcionModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpcionModificar.Location = new System.Drawing.Point(130, 88);
            this.btnOpcionModificar.Name = "btnOpcionModificar";
            this.btnOpcionModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOpcionModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpcionModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpcionModificar.OnHoverImage = null;
            this.btnOpcionModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpcionModificar.Size = new System.Drawing.Size(69, 32);
            this.btnOpcionModificar.TabIndex = 31;
            this.btnOpcionModificar.Text = "Modificar";
            this.btnOpcionModificar.Click += new System.EventHandler(this.btnOpcionModificar_Click);
            // 
            // btnOpcionCrear
            // 
            this.btnOpcionCrear.AnimationHoverSpeed = 0.07F;
            this.btnOpcionCrear.AnimationSpeed = 0.03F;
            this.btnOpcionCrear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOpcionCrear.BorderColor = System.Drawing.Color.Black;
            this.btnOpcionCrear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpcionCrear.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpcionCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpcionCrear.ForeColor = System.Drawing.Color.White;
            this.btnOpcionCrear.Image = null;
            this.btnOpcionCrear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpcionCrear.Location = new System.Drawing.Point(38, 88);
            this.btnOpcionCrear.Name = "btnOpcionCrear";
            this.btnOpcionCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOpcionCrear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpcionCrear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpcionCrear.OnHoverImage = null;
            this.btnOpcionCrear.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpcionCrear.Size = new System.Drawing.Size(69, 32);
            this.btnOpcionCrear.TabIndex = 30;
            this.btnOpcionCrear.Text = "Registrar";
            this.btnOpcionCrear.Click += new System.EventHandler(this.btnOpcionCrear_Click);
            // 
            // grpHorario
            // 
            this.grpHorario.Controls.Add(this.cmbAsignatura);
            this.grpHorario.Controls.Add(this.btnEliminar);
            this.grpHorario.Controls.Add(this.cmbCurso);
            this.grpHorario.Controls.Add(this.lbCurso);
            this.grpHorario.Controls.Add(this.cmbModificarDia);
            this.grpHorario.Controls.Add(this.lblAsignatura);
            this.grpHorario.Controls.Add(this.btnModificar);
            this.grpHorario.Controls.Add(this.cmbDia);
            this.grpHorario.Controls.Add(this.gunaLabel2);
            this.grpHorario.Controls.Add(this.txthInicio);
            this.grpHorario.Controls.Add(this.txthFinal);
            this.grpHorario.Controls.Add(this.btnRegistrar);
            this.grpHorario.Controls.Add(this.gunaLabel1);
            this.grpHorario.Controls.Add(this.gunaLabel3);
            this.grpHorario.Location = new System.Drawing.Point(27, 126);
            this.grpHorario.Name = "grpHorario";
            this.grpHorario.Size = new System.Drawing.Size(267, 335);
            this.grpHorario.TabIndex = 29;
            this.grpHorario.TabStop = false;
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
            this.cmbAsignatura.Location = new System.Drawing.Point(103, 82);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAsignatura.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAsignatura.Size = new System.Drawing.Size(121, 26);
            this.cmbAsignatura.TabIndex = 4;
            this.cmbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cmbAsignatura_SelectedIndexChanged_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(86, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Size = new System.Drawing.Size(86, 32);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            this.cmbCurso.Location = new System.Drawing.Point(103, 50);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Size = new System.Drawing.Size(121, 26);
            this.cmbCurso.TabIndex = 2;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged_1);
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCurso.Location = new System.Drawing.Point(53, 55);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(41, 15);
            this.lbCurso.TabIndex = 3;
            this.lbCurso.Text = "Curso:";
            // 
            // cmbModificarDia
            // 
            this.cmbModificarDia.BackColor = System.Drawing.Color.Transparent;
            this.cmbModificarDia.BaseColor = System.Drawing.Color.White;
            this.cmbModificarDia.BorderColor = System.Drawing.Color.Silver;
            this.cmbModificarDia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModificarDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarDia.FocusedColor = System.Drawing.Color.Empty;
            this.cmbModificarDia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModificarDia.ForeColor = System.Drawing.Color.Black;
            this.cmbModificarDia.FormattingEnabled = true;
            this.cmbModificarDia.Location = new System.Drawing.Point(103, 133);
            this.cmbModificarDia.Name = "cmbModificarDia";
            this.cmbModificarDia.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbModificarDia.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbModificarDia.Size = new System.Drawing.Size(121, 26);
            this.cmbModificarDia.TabIndex = 18;
            this.cmbModificarDia.SelectedIndexChanged += new System.EventHandler(this.cmbModificarDia_SelectedIndexChanged_1);
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAsignatura.Location = new System.Drawing.Point(33, 87);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(64, 15);
            this.lblAsignatura.TabIndex = 5;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // btnModificar
            // 
            this.btnModificar.AnimationHoverSpeed = 0.07F;
            this.btnModificar.AnimationSpeed = 0.03F;
            this.btnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificar.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(175, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(86, 32);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // cmbDia
            // 
            this.cmbDia.BackColor = System.Drawing.Color.Transparent;
            this.cmbDia.BaseColor = System.Drawing.Color.White;
            this.cmbDia.BorderColor = System.Drawing.Color.Silver;
            this.cmbDia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDia.ForeColor = System.Drawing.Color.Black;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(103, 114);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDia.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDia.Size = new System.Drawing.Size(121, 26);
            this.cmbDia.TabIndex = 6;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(56, 119);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(24, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Dia";
            // 
            // txthInicio
            // 
            this.txthInicio.BaseColor = System.Drawing.Color.White;
            this.txthInicio.BorderColor = System.Drawing.Color.Silver;
            this.txthInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthInicio.FocusedBaseColor = System.Drawing.Color.White;
            this.txthInicio.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txthInicio.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txthInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthInicio.Location = new System.Drawing.Point(103, 155);
            this.txthInicio.Name = "txthInicio";
            this.txthInicio.PasswordChar = '\0';
            this.txthInicio.SelectedText = "";
            this.txthInicio.Size = new System.Drawing.Size(121, 30);
            this.txthInicio.TabIndex = 8;
            // 
            // txthFinal
            // 
            this.txthFinal.BaseColor = System.Drawing.Color.White;
            this.txthFinal.BorderColor = System.Drawing.Color.Silver;
            this.txthFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthFinal.FocusedBaseColor = System.Drawing.Color.White;
            this.txthFinal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txthFinal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txthFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthFinal.Location = new System.Drawing.Point(103, 191);
            this.txthFinal.Name = "txthFinal";
            this.txthFinal.PasswordChar = '\0';
            this.txthFinal.SelectedText = "";
            this.txthFinal.Size = new System.Drawing.Size(121, 30);
            this.txthFinal.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(86, 253);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Size = new System.Drawing.Size(86, 32);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(33, 170);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(65, 15);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Hora Inicio";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(36, 206);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "Hora Final";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes});
            this.dgvResultado.Location = new System.Drawing.Point(300, 126);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(653, 335);
            this.dgvResultado.TabIndex = 28;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            // 
            // Miercoles
            // 
            this.Miercoles.HeaderText = "Miercoles";
            this.Miercoles.Name = "Miercoles";
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(524, 99);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel4.TabIndex = 27;
            this.gunaLabel4.Text = "Curso:";
            // 
            // cmbCursoFiltrar
            // 
            this.cmbCursoFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.cmbCursoFiltrar.BaseColor = System.Drawing.Color.White;
            this.cmbCursoFiltrar.BorderColor = System.Drawing.Color.Silver;
            this.cmbCursoFiltrar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCursoFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursoFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCursoFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCursoFiltrar.ForeColor = System.Drawing.Color.Black;
            this.cmbCursoFiltrar.FormattingEnabled = true;
            this.cmbCursoFiltrar.Location = new System.Drawing.Point(574, 94);
            this.cmbCursoFiltrar.Name = "cmbCursoFiltrar";
            this.cmbCursoFiltrar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCursoFiltrar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCursoFiltrar.Size = new System.Drawing.Size(121, 26);
            this.cmbCursoFiltrar.TabIndex = 26;
            this.cmbCursoFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbCursoFiltrar_SelectedIndexChanged_1);
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(350, 25);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(135, 39);
            this.lbHorario.TabIndex = 25;
            this.lbHorario.Text = "Horario";
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 501);
            this.Controls.Add(this.btnOpcionEliminar);
            this.Controls.Add(this.btnOpcionModificar);
            this.Controls.Add(this.btnOpcionCrear);
            this.Controls.Add(this.grpHorario);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cmbCursoFiltrar);
            this.Controls.Add(this.lbHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorario";
            this.Text = "frmHorario";
            this.Load += new System.EventHandler(this.frmHorario_Load);
            this.grpHorario.ResumeLayout(false);
            this.grpHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnOpcionEliminar;
        private Guna.UI.WinForms.GunaButton btnOpcionModificar;
        private Guna.UI.WinForms.GunaButton btnOpcionCrear;
        private System.Windows.Forms.GroupBox grpHorario;
        private Guna.UI.WinForms.GunaComboBox cmbAsignatura;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaComboBox cmbCurso;
        private Guna.UI.WinForms.GunaLabel lbCurso;
        private Guna.UI.WinForms.GunaComboBox cmbModificarDia;
        private Guna.UI.WinForms.GunaLabel lblAsignatura;
        private Guna.UI.WinForms.GunaButton btnModificar;
        private Guna.UI.WinForms.GunaComboBox cmbDia;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txthInicio;
        private Guna.UI.WinForms.GunaTextBox txthFinal;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cmbCursoFiltrar;
        private Guna.UI.WinForms.GunaLabel lbHorario;
    }
}