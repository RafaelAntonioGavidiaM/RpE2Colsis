﻿
namespace appE2Colsis.Vista
{
    partial class frmAsignatura
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
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.btnModificarAsignatura = new Guna.UI.WinForms.GunaButton();
            this.cmbArea = new Guna.UI.WinForms.GunaComboBox();
            this.btnEliminarAsignatura = new Guna.UI.WinForms.GunaButton();
            this.btnRegistarAsignatura = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtAsignatura = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnModificarArea = new Guna.UI.WinForms.GunaButton();
            this.txtIdArea = new Guna.UI.WinForms.GunaTextBox();
            this.btnEliminarArea = new Guna.UI.WinForms.GunaButton();
            this.btnRegistrarArea = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtArea = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dgvAsignatura = new System.Windows.Forms.DataGridView();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnRecargar = new Guna.UI.WinForms.GunaButton();
            this.cmbFiltroArea = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).BeginInit();
            this.gunaGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArea
            // 
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Location = new System.Drawing.Point(55, 209);
            this.dgvArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.RowHeadersWidth = 51;
            this.dgvArea.RowTemplate.Height = 24;
            this.dgvArea.Size = new System.Drawing.Size(399, 236);
            this.dgvArea.TabIndex = 0;
            this.dgvArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellContentClick);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel7);
            this.gunaGroupBox1.Controls.Add(this.txtId);
            this.gunaGroupBox1.Controls.Add(this.btnModificarAsignatura);
            this.gunaGroupBox1.Controls.Add(this.cmbArea);
            this.gunaGroupBox1.Controls.Add(this.btnEliminarAsignatura);
            this.gunaGroupBox1.Controls.Add(this.btnRegistarAsignatura);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtAsignatura);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 78);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(484, 289);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Registro De Asignatura";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(11, 58);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(99, 20);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "ID Asignatura";
            // 
            // txtId
            // 
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.Silver;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(112, 46);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(323, 37);
            this.txtId.TabIndex = 12;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnModificarAsignatura
            // 
            this.btnModificarAsignatura.AnimationHoverSpeed = 0.07F;
            this.btnModificarAsignatura.AnimationSpeed = 0.03F;
            this.btnModificarAsignatura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificarAsignatura.BorderColor = System.Drawing.Color.Black;
            this.btnModificarAsignatura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarAsignatura.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarAsignatura.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnModificarAsignatura.Image = null;
            this.btnModificarAsignatura.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificarAsignatura.Location = new System.Drawing.Point(355, 213);
            this.btnModificarAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarAsignatura.Name = "btnModificarAsignatura";
            this.btnModificarAsignatura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificarAsignatura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarAsignatura.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarAsignatura.OnHoverImage = null;
            this.btnModificarAsignatura.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarAsignatura.Size = new System.Drawing.Size(99, 36);
            this.btnModificarAsignatura.TabIndex = 11;
            this.btnModificarAsignatura.Text = "Modificar";
            this.btnModificarAsignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarAsignatura.Click += new System.EventHandler(this.btnModificarAsignatura_Click);
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BaseColor = System.Drawing.Color.White;
            this.cmbArea.BorderColor = System.Drawing.Color.Silver;
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FocusedColor = System.Drawing.Color.Empty;
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArea.ForeColor = System.Drawing.Color.Black;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(112, 150);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbArea.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbArea.Size = new System.Drawing.Size(323, 31);
            this.cmbArea.TabIndex = 4;
            // 
            // btnEliminarAsignatura
            // 
            this.btnEliminarAsignatura.AnimationHoverSpeed = 0.07F;
            this.btnEliminarAsignatura.AnimationSpeed = 0.03F;
            this.btnEliminarAsignatura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminarAsignatura.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarAsignatura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarAsignatura.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarAsignatura.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAsignatura.Image = null;
            this.btnEliminarAsignatura.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarAsignatura.Location = new System.Drawing.Point(204, 213);
            this.btnEliminarAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            this.btnEliminarAsignatura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarAsignatura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarAsignatura.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarAsignatura.OnHoverImage = null;
            this.btnEliminarAsignatura.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarAsignatura.Size = new System.Drawing.Size(99, 36);
            this.btnEliminarAsignatura.TabIndex = 10;
            this.btnEliminarAsignatura.Text = "Eliminar";
            this.btnEliminarAsignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarAsignatura.Click += new System.EventHandler(this.btnEliminarAsignatura_Click);
            // 
            // btnRegistarAsignatura
            // 
            this.btnRegistarAsignatura.AnimationHoverSpeed = 0.07F;
            this.btnRegistarAsignatura.AnimationSpeed = 0.03F;
            this.btnRegistarAsignatura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistarAsignatura.BorderColor = System.Drawing.Color.Black;
            this.btnRegistarAsignatura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistarAsignatura.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistarAsignatura.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnRegistarAsignatura.Image = null;
            this.btnRegistarAsignatura.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistarAsignatura.Location = new System.Drawing.Point(55, 213);
            this.btnRegistarAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistarAsignatura.Name = "btnRegistarAsignatura";
            this.btnRegistarAsignatura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistarAsignatura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistarAsignatura.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistarAsignatura.OnHoverImage = null;
            this.btnRegistarAsignatura.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistarAsignatura.Size = new System.Drawing.Size(99, 36);
            this.btnRegistarAsignatura.TabIndex = 9;
            this.btnRegistarAsignatura.Text = "Registrar";
            this.btnRegistarAsignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistarAsignatura.Click += new System.EventHandler(this.btnRegistarAsignatura_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(28, 155);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Area";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(26, 112);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Asignatura";
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.BaseColor = System.Drawing.Color.White;
            this.txtAsignatura.BorderColor = System.Drawing.Color.Silver;
            this.txtAsignatura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsignatura.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAsignatura.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAsignatura.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAsignatura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAsignatura.Location = new System.Drawing.Point(112, 95);
            this.txtAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.PasswordChar = '\0';
            this.txtAsignatura.SelectedText = "";
            this.txtAsignatura.Size = new System.Drawing.Size(323, 37);
            this.txtAsignatura.TabIndex = 0;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox2.Controls.Add(this.btnModificarArea);
            this.gunaGroupBox2.Controls.Add(this.txtIdArea);
            this.gunaGroupBox2.Controls.Add(this.btnEliminarArea);
            this.gunaGroupBox2.Controls.Add(this.btnRegistrarArea);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox2.Controls.Add(this.txtArea);
            this.gunaGroupBox2.Controls.Add(this.dgvArea);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox2.Location = new System.Drawing.Point(12, 411);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(484, 447);
            this.gunaGroupBox2.TabIndex = 2;
            this.gunaGroupBox2.Text = "Registro De Area";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(28, 50);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(59, 20);
            this.gunaLabel8.TabIndex = 15;
            this.gunaLabel8.Text = "ID Area";
            // 
            // btnModificarArea
            // 
            this.btnModificarArea.AnimationHoverSpeed = 0.07F;
            this.btnModificarArea.AnimationSpeed = 0.03F;
            this.btnModificarArea.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificarArea.BorderColor = System.Drawing.Color.Black;
            this.btnModificarArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarArea.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarArea.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArea.ForeColor = System.Drawing.Color.White;
            this.btnModificarArea.Image = null;
            this.btnModificarArea.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificarArea.Location = new System.Drawing.Point(355, 139);
            this.btnModificarArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarArea.Name = "btnModificarArea";
            this.btnModificarArea.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificarArea.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarArea.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarArea.OnHoverImage = null;
            this.btnModificarArea.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarArea.Size = new System.Drawing.Size(99, 36);
            this.btnModificarArea.TabIndex = 8;
            this.btnModificarArea.Text = "Modificar";
            this.btnModificarArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarArea.Click += new System.EventHandler(this.btnModificarArea_Click);
            // 
            // txtIdArea
            // 
            this.txtIdArea.BaseColor = System.Drawing.Color.White;
            this.txtIdArea.BorderColor = System.Drawing.Color.Silver;
            this.txtIdArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdArea.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdArea.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdArea.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdArea.Location = new System.Drawing.Point(112, 38);
            this.txtIdArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdArea.Name = "txtIdArea";
            this.txtIdArea.PasswordChar = '\0';
            this.txtIdArea.SelectedText = "";
            this.txtIdArea.Size = new System.Drawing.Size(323, 37);
            this.txtIdArea.TabIndex = 14;
            // 
            // btnEliminarArea
            // 
            this.btnEliminarArea.AnimationHoverSpeed = 0.07F;
            this.btnEliminarArea.AnimationSpeed = 0.03F;
            this.btnEliminarArea.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminarArea.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarArea.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarArea.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArea.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArea.Image = null;
            this.btnEliminarArea.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarArea.Location = new System.Drawing.Point(204, 139);
            this.btnEliminarArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarArea.Name = "btnEliminarArea";
            this.btnEliminarArea.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarArea.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarArea.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarArea.OnHoverImage = null;
            this.btnEliminarArea.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarArea.Size = new System.Drawing.Size(99, 36);
            this.btnEliminarArea.TabIndex = 7;
            this.btnEliminarArea.Text = "Eliminar";
            this.btnEliminarArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarArea.Click += new System.EventHandler(this.btnEliminarArea_Click);
            // 
            // btnRegistrarArea
            // 
            this.btnRegistrarArea.AnimationHoverSpeed = 0.07F;
            this.btnRegistrarArea.AnimationSpeed = 0.03F;
            this.btnRegistrarArea.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistrarArea.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrarArea.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrarArea.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarArea.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarArea.Image = null;
            this.btnRegistrarArea.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrarArea.Location = new System.Drawing.Point(55, 139);
            this.btnRegistrarArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarArea.Name = "btnRegistrarArea";
            this.btnRegistrarArea.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrarArea.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrarArea.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrarArea.OnHoverImage = null;
            this.btnRegistrarArea.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrarArea.Size = new System.Drawing.Size(99, 36);
            this.btnRegistrarArea.TabIndex = 6;
            this.btnRegistrarArea.Text = "Registrar";
            this.btnRegistrarArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrarArea.Click += new System.EventHandler(this.btnRegistrarArea_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(28, 76);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(43, 20);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Area:";
            // 
            // txtArea
            // 
            this.txtArea.BaseColor = System.Drawing.Color.White;
            this.txtArea.BorderColor = System.Drawing.Color.Silver;
            this.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArea.FocusedBaseColor = System.Drawing.Color.White;
            this.txtArea.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtArea.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArea.Location = new System.Drawing.Point(112, 76);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.SelectedText = "";
            this.txtArea.Size = new System.Drawing.Size(323, 37);
            this.txtArea.TabIndex = 5;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Location = new System.Drawing.Point(-3, 1);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1738, 60);
            this.gunaPanel1.TabIndex = 3;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1388, 10);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(147, 42);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Asignar a Cursos";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(23, 17);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(105, 31);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Asignaturas";
            // 
            // dgvAsignatura
            // 
            this.dgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignatura.Location = new System.Drawing.Point(521, 190);
            this.dgvAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAsignatura.Name = "dgvAsignatura";
            this.dgvAsignatura.RowHeadersWidth = 51;
            this.dgvAsignatura.RowTemplate.Height = 24;
            this.dgvAsignatura.Size = new System.Drawing.Size(1011, 668);
            this.dgvAsignatura.TabIndex = 4;
            this.dgvAsignatura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignatura_CellContentClick);
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaGroupBox3.Controls.Add(this.btnRecargar);
            this.gunaGroupBox3.Controls.Add(this.cmbFiltroArea);
            this.gunaGroupBox3.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox3.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox3.Location = new System.Drawing.Point(521, 78);
            this.gunaGroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(1011, 90);
            this.gunaGroupBox3.TabIndex = 5;
            this.gunaGroupBox3.Text = "Filtro";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnRecargar
            // 
            this.btnRecargar.AnimationHoverSpeed = 0.07F;
            this.btnRecargar.AnimationSpeed = 0.03F;
            this.btnRecargar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRecargar.BorderColor = System.Drawing.Color.Black;
            this.btnRecargar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecargar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRecargar.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.ForeColor = System.Drawing.Color.White;
            this.btnRecargar.Image = null;
            this.btnRecargar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRecargar.Location = new System.Drawing.Point(873, 46);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRecargar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRecargar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRecargar.OnHoverImage = null;
            this.btnRecargar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRecargar.Size = new System.Drawing.Size(99, 36);
            this.btnRecargar.TabIndex = 14;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // cmbFiltroArea
            // 
            this.cmbFiltroArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroArea.BaseColor = System.Drawing.Color.White;
            this.cmbFiltroArea.BorderColor = System.Drawing.Color.Silver;
            this.cmbFiltroArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroArea.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFiltroArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroArea.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroArea.FormattingEnabled = true;
            this.cmbFiltroArea.Location = new System.Drawing.Point(96, 47);
            this.cmbFiltroArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroArea.Name = "cmbFiltroArea";
            this.cmbFiltroArea.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFiltroArea.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFiltroArea.Size = new System.Drawing.Size(761, 31);
            this.cmbFiltroArea.TabIndex = 12;
            this.cmbFiltroArea.SelectionChangeCommitted += new System.EventHandler(this.cmbFiltroArea_SelectionChangeCommitted);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(27, 52);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(40, 20);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Area";
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1561, 886);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.dgvAsignatura);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAsignatura";
            this.Text = "frmAsignatura";
            this.Load += new System.EventHandler(this.frmAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignatura)).EndInit();
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArea;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btnModificarAsignatura;
        private Guna.UI.WinForms.GunaComboBox cmbArea;
        private Guna.UI.WinForms.GunaButton btnEliminarAsignatura;
        private Guna.UI.WinForms.GunaButton btnRegistarAsignatura;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtAsignatura;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnModificarArea;
        private Guna.UI.WinForms.GunaButton btnEliminarArea;
        private Guna.UI.WinForms.GunaButton btnRegistrarArea;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtArea;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridView dgvAsignatura;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaComboBox cmbFiltroArea;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtId;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtIdArea;
        private Guna.UI.WinForms.GunaButton btnRecargar;
    }
}