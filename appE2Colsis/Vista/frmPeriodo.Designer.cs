
namespace appE2Colsis.Vista
{
    partial class frmPeriodo
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
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.dtpInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnModificar = new Guna.UI.WinForms.GunaButton();
            this.cmbFiltrar = new Guna.UI.WinForms.GunaComboBox();
            this.grpPeriodos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.lblPeriodo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnCrearOpcion = new Guna.UI.WinForms.GunaButton();
            this.btnModificarOpcion = new Guna.UI.WinForms.GunaButton();
            this.btnEliminarOpcion = new Guna.UI.WinForms.GunaButton();
            this.grpPeriodos.SuspendLayout();
            this.SuspendLayout();
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
            this.txtNombre.Location = new System.Drawing.Point(168, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(295, 37);
            this.txtNombre.TabIndex = 0;
            // 
            // dtpInicio
            // 
            this.dtpInicio.BaseColor = System.Drawing.Color.White;
            this.dtpInicio.BorderColor = System.Drawing.Color.Silver;
            this.dtpInicio.CustomFormat = null;
            this.dtpInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInicio.ForeColor = System.Drawing.Color.Black;
            this.dtpInicio.Location = new System.Drawing.Point(168, 138);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpInicio.OnPressedColor = System.Drawing.Color.Black;
            this.dtpInicio.Size = new System.Drawing.Size(295, 33);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.Text = "lunes, 29 de marzo de 2021";
            this.dtpInicio.Value = new System.DateTime(2021, 3, 29, 8, 6, 1, 122);
            // 
            // dtpFin
            // 
            this.dtpFin.BaseColor = System.Drawing.Color.White;
            this.dtpFin.BorderColor = System.Drawing.Color.Silver;
            this.dtpFin.CustomFormat = null;
            this.dtpFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFin.ForeColor = System.Drawing.Color.Black;
            this.dtpFin.Location = new System.Drawing.Point(168, 182);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFin.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFin.Size = new System.Drawing.Size(295, 33);
            this.dtpFin.TabIndex = 2;
            this.dtpFin.Text = "lunes, 29 de marzo de 2021";
            this.dtpFin.Value = new System.DateTime(2021, 3, 29, 8, 6, 1, 122);
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
            this.btnRegistrar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(189, 287);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.Size = new System.Drawing.Size(200, 42);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar Periodo";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 111);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(107, 24);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Nombre Periodo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(67, 153);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 24);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Fecha Inicio";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(79, 197);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 24);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Fecha Fin";
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
            this.btnModificar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(189, 287);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Radius = 10;
            this.btnModificar.Size = new System.Drawing.Size(200, 42);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar Periodo";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.cmbFiltrar.Location = new System.Drawing.Point(168, 58);
            this.cmbFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFiltrar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFiltrar.Size = new System.Drawing.Size(293, 31);
            this.cmbFiltrar.TabIndex = 8;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // grpPeriodos
            // 
            this.grpPeriodos.Controls.Add(this.btnEliminar);
            this.grpPeriodos.Controls.Add(this.lblPeriodo);
            this.grpPeriodos.Controls.Add(this.dtpInicio);
            this.grpPeriodos.Controls.Add(this.cmbFiltrar);
            this.grpPeriodos.Controls.Add(this.txtNombre);
            this.grpPeriodos.Controls.Add(this.btnModificar);
            this.grpPeriodos.Controls.Add(this.dtpFin);
            this.grpPeriodos.Controls.Add(this.gunaLabel3);
            this.grpPeriodos.Controls.Add(this.btnRegistrar);
            this.grpPeriodos.Controls.Add(this.gunaLabel2);
            this.grpPeriodos.Controls.Add(this.gunaLabel1);
            this.grpPeriodos.Location = new System.Drawing.Point(67, 129);
            this.grpPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.grpPeriodos.Name = "grpPeriodos";
            this.grpPeriodos.Padding = new System.Windows.Forms.Padding(4);
            this.grpPeriodos.Size = new System.Drawing.Size(568, 350);
            this.grpPeriodos.TabIndex = 9;
            this.grpPeriodos.TabStop = false;
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
            this.btnEliminar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(189, 287);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(200, 42);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(79, 64);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(56, 24);
            this.lblPeriodo.TabIndex = 9;
            this.lblPeriodo.Text = "Periodo";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(249, 11);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(214, 36);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Periodos Academicos";
            // 
            // btnCrearOpcion
            // 
            this.btnCrearOpcion.AnimationHoverSpeed = 0.07F;
            this.btnCrearOpcion.AnimationSpeed = 0.03F;
            this.btnCrearOpcion.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearOpcion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCrearOpcion.BorderColor = System.Drawing.Color.Black;
            this.btnCrearOpcion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCrearOpcion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCrearOpcion.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearOpcion.ForeColor = System.Drawing.Color.White;
            this.btnCrearOpcion.Image = null;
            this.btnCrearOpcion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCrearOpcion.Location = new System.Drawing.Point(178, 90);
            this.btnCrearOpcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearOpcion.Name = "btnCrearOpcion";
            this.btnCrearOpcion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCrearOpcion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCrearOpcion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCrearOpcion.OnHoverImage = null;
            this.btnCrearOpcion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCrearOpcion.Radius = 10;
            this.btnCrearOpcion.Size = new System.Drawing.Size(118, 32);
            this.btnCrearOpcion.TabIndex = 9;
            this.btnCrearOpcion.Text = "Crear";
            this.btnCrearOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCrearOpcion.Click += new System.EventHandler(this.btnCrearOpcion_Click);
            // 
            // btnModificarOpcion
            // 
            this.btnModificarOpcion.AnimationHoverSpeed = 0.07F;
            this.btnModificarOpcion.AnimationSpeed = 0.03F;
            this.btnModificarOpcion.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarOpcion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificarOpcion.BorderColor = System.Drawing.Color.Black;
            this.btnModificarOpcion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarOpcion.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarOpcion.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOpcion.ForeColor = System.Drawing.Color.White;
            this.btnModificarOpcion.Image = null;
            this.btnModificarOpcion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificarOpcion.Location = new System.Drawing.Point(304, 90);
            this.btnModificarOpcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarOpcion.Name = "btnModificarOpcion";
            this.btnModificarOpcion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificarOpcion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarOpcion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarOpcion.OnHoverImage = null;
            this.btnModificarOpcion.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarOpcion.Radius = 10;
            this.btnModificarOpcion.Size = new System.Drawing.Size(118, 32);
            this.btnModificarOpcion.TabIndex = 10;
            this.btnModificarOpcion.Text = "Modificar";
            this.btnModificarOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarOpcion.Click += new System.EventHandler(this.btnModificarOpcion_Click);
            // 
            // btnEliminarOpcion
            // 
            this.btnEliminarOpcion.AnimationHoverSpeed = 0.07F;
            this.btnEliminarOpcion.AnimationSpeed = 0.03F;
            this.btnEliminarOpcion.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarOpcion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminarOpcion.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarOpcion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarOpcion.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarOpcion.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOpcion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarOpcion.Image = null;
            this.btnEliminarOpcion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarOpcion.Location = new System.Drawing.Point(433, 90);
            this.btnEliminarOpcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarOpcion.Name = "btnEliminarOpcion";
            this.btnEliminarOpcion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarOpcion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarOpcion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarOpcion.OnHoverImage = null;
            this.btnEliminarOpcion.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarOpcion.Radius = 10;
            this.btnEliminarOpcion.Size = new System.Drawing.Size(118, 32);
            this.btnEliminarOpcion.TabIndex = 11;
            this.btnEliminarOpcion.Text = "Eliminar";
            this.btnEliminarOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminarOpcion.Click += new System.EventHandler(this.btnEliminarOpcion_Click);
            // 
            // frmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 548);
            this.Controls.Add(this.btnEliminarOpcion);
            this.Controls.Add(this.btnModificarOpcion);
            this.Controls.Add(this.btnCrearOpcion);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.grpPeriodos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPeriodo";
            this.Text = "Seleccion de periodo";
            this.Load += new System.EventHandler(this.frmPeriodo_Load);
            this.grpPeriodos.ResumeLayout(false);
            this.grpPeriodos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaDateTimePicker dtpInicio;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFin;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnModificar;
        private Guna.UI.WinForms.GunaComboBox cmbFiltrar;
        private System.Windows.Forms.GroupBox grpPeriodos;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnCrearOpcion;
        private Guna.UI.WinForms.GunaButton btnModificarOpcion;
        private Guna.UI.WinForms.GunaButton btnEliminarOpcion;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaLabel lblPeriodo;
    }
}