
namespace appE2Colsis.Vista
{
    partial class frmAsignaturaCurso
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
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnModificar = new Guna.UI.WinForms.GunaButton();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnOpcionCrear = new Guna.UI.WinForms.GunaButton();
            this.cmbDocente = new Guna.UI.WinForms.GunaComboBox();
            this.cmbAsignatura = new Guna.UI.WinForms.GunaComboBox();
            this.cmbCurso = new Guna.UI.WinForms.GunaComboBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cmbCursoBuscar = new Guna.UI.WinForms.GunaComboBox();
            this.btnOpcionModificar = new Guna.UI.WinForms.GunaButton();
            this.btnOpcionEliminar = new Guna.UI.WinForms.GunaButton();
            this.grpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.btnEliminar);
            this.grpOpciones.Controls.Add(this.btnModificar);
            this.grpOpciones.Controls.Add(this.btnRegistrar);
            this.grpOpciones.Controls.Add(this.gunaLabel3);
            this.grpOpciones.Controls.Add(this.gunaLabel2);
            this.grpOpciones.Controls.Add(this.gunaLabel1);
            this.grpOpciones.Controls.Add(this.cmbDocente);
            this.grpOpciones.Controls.Add(this.cmbAsignatura);
            this.grpOpciones.Controls.Add(this.cmbCurso);
            this.grpOpciones.Location = new System.Drawing.Point(23, 77);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(367, 247);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
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
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(120, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(121, 26);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(120, 152);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Radius = 10;
            this.btnModificar.Size = new System.Drawing.Size(121, 26);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(120, 152);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.Size = new System.Drawing.Size(121, 26);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar Asignacion";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(63, 101);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Docente";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(47, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Asignatura:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(56, 37);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Curso:";
            // 
            // btnOpcionCrear
            // 
            this.btnOpcionCrear.AnimationHoverSpeed = 0.07F;
            this.btnOpcionCrear.AnimationSpeed = 0.03F;
            this.btnOpcionCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionCrear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOpcionCrear.BorderColor = System.Drawing.Color.Black;
            this.btnOpcionCrear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpcionCrear.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpcionCrear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpcionCrear.ForeColor = System.Drawing.Color.White;
            this.btnOpcionCrear.Image = null;
            this.btnOpcionCrear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpcionCrear.Location = new System.Drawing.Point(46, 45);
            this.btnOpcionCrear.Name = "btnOpcionCrear";
            this.btnOpcionCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOpcionCrear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpcionCrear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpcionCrear.OnHoverImage = null;
            this.btnOpcionCrear.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpcionCrear.Radius = 10;
            this.btnOpcionCrear.Size = new System.Drawing.Size(91, 26);
            this.btnOpcionCrear.TabIndex = 3;
            this.btnOpcionCrear.Text = "Crear";
            this.btnOpcionCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOpcionCrear.Click += new System.EventHandler(this.btnOpcionCrear_Click);
            // 
            // cmbDocente
            // 
            this.cmbDocente.BackColor = System.Drawing.Color.Transparent;
            this.cmbDocente.BaseColor = System.Drawing.Color.White;
            this.cmbDocente.BorderColor = System.Drawing.Color.Silver;
            this.cmbDocente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocente.FocusedColor = System.Drawing.Color.Empty;
            this.cmbDocente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDocente.ForeColor = System.Drawing.Color.Black;
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.Location = new System.Drawing.Point(120, 96);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDocente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDocente.Size = new System.Drawing.Size(121, 26);
            this.cmbDocente.TabIndex = 2;
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
            this.cmbAsignatura.Location = new System.Drawing.Point(120, 64);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAsignatura.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAsignatura.Size = new System.Drawing.Size(121, 26);
            this.cmbAsignatura.TabIndex = 1;
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
            this.cmbCurso.Location = new System.Drawing.Point(120, 32);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCurso.Size = new System.Drawing.Size(121, 26);
            this.cmbCurso.TabIndex = 0;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Location = new System.Drawing.Point(416, 82);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.Size = new System.Drawing.Size(517, 244);
            this.dgvAsignaturas.TabIndex = 7;
            this.dgvAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaturas_CellContentClick);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(559, 50);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Curso:";
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
            this.cmbCursoBuscar.Location = new System.Drawing.Point(623, 45);
            this.cmbCursoBuscar.Name = "cmbCursoBuscar";
            this.cmbCursoBuscar.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCursoBuscar.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCursoBuscar.Size = new System.Drawing.Size(145, 26);
            this.cmbCursoBuscar.TabIndex = 5;
            this.cmbCursoBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbCursoBuscar_SelectedIndexChanged);
            // 
            // btnOpcionModificar
            // 
            this.btnOpcionModificar.AnimationHoverSpeed = 0.07F;
            this.btnOpcionModificar.AnimationSpeed = 0.03F;
            this.btnOpcionModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOpcionModificar.BorderColor = System.Drawing.Color.Black;
            this.btnOpcionModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpcionModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpcionModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpcionModificar.ForeColor = System.Drawing.Color.White;
            this.btnOpcionModificar.Image = null;
            this.btnOpcionModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpcionModificar.Location = new System.Drawing.Point(143, 45);
            this.btnOpcionModificar.Name = "btnOpcionModificar";
            this.btnOpcionModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOpcionModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpcionModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpcionModificar.OnHoverImage = null;
            this.btnOpcionModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpcionModificar.Radius = 10;
            this.btnOpcionModificar.Size = new System.Drawing.Size(91, 26);
            this.btnOpcionModificar.TabIndex = 8;
            this.btnOpcionModificar.Text = "Modificar";
            this.btnOpcionModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOpcionModificar.Click += new System.EventHandler(this.btnOpcionModificar_Click);
            // 
            // btnOpcionEliminar
            // 
            this.btnOpcionEliminar.AnimationHoverSpeed = 0.07F;
            this.btnOpcionEliminar.AnimationSpeed = 0.03F;
            this.btnOpcionEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcionEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOpcionEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnOpcionEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpcionEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpcionEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpcionEliminar.ForeColor = System.Drawing.Color.White;
            this.btnOpcionEliminar.Image = null;
            this.btnOpcionEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOpcionEliminar.Location = new System.Drawing.Point(240, 45);
            this.btnOpcionEliminar.Name = "btnOpcionEliminar";
            this.btnOpcionEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOpcionEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpcionEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpcionEliminar.OnHoverImage = null;
            this.btnOpcionEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpcionEliminar.Radius = 10;
            this.btnOpcionEliminar.Size = new System.Drawing.Size(91, 26);
            this.btnOpcionEliminar.TabIndex = 9;
            this.btnOpcionEliminar.Text = "Eliminar";
            this.btnOpcionEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOpcionEliminar.Click += new System.EventHandler(this.btnOpcionEliminar_Click);
            // 
            // frmAsignaturaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 519);
            this.Controls.Add(this.btnOpcionEliminar);
            this.Controls.Add(this.btnOpcionModificar);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.cmbCursoBuscar);
            this.Controls.Add(this.btnOpcionCrear);
            this.Name = "frmAsignaturaCurso";
            this.Text = "frmAsignaturaCurso";
            this.Load += new System.EventHandler(this.cmbCurso_Load);
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOpciones;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnOpcionCrear;
        private Guna.UI.WinForms.GunaComboBox cmbDocente;
        private Guna.UI.WinForms.GunaComboBox cmbAsignatura;
        private Guna.UI.WinForms.GunaComboBox cmbCurso;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cmbCursoBuscar;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private Guna.UI.WinForms.GunaButton btnModificar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnOpcionModificar;
        private Guna.UI.WinForms.GunaButton btnOpcionEliminar;
    }
}