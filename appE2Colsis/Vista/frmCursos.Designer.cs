
namespace appE2Colsis.Vista
{
    partial class frmCurso
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
            this.lbCursos = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDocente = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarDocente = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lbNombreC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNivelEducativo = new Guna.UI.WinForms.GunaComboBox();
            this.lbNivelE = new Guna.UI.WinForms.GunaLabel();
            this.dvgCursos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.btnModificar = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCursos
            // 
            this.lbCursos.AutoSize = true;
            this.lbCursos.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursos.Location = new System.Drawing.Point(353, 5);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(76, 34);
            this.lbCursos.TabIndex = 19;
            this.lbCursos.Text = "Cursos";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.groupBox3);
            this.gunaGroupBox1.Controls.Add(this.groupBox1);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnRegistrar);
            this.gunaGroupBox1.Controls.Add(this.btnModificar);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(11, 41);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(778, 404);
            this.gunaGroupBox1.TabIndex = 20;
            this.gunaGroupBox1.Text = "Complete los campos ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDocente);
            this.groupBox3.Controls.Add(this.btnBuscarDocente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbNombre);
            this.groupBox3.Controls.Add(this.txtNombreC);
            this.groupBox3.Controls.Add(this.txtAño);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCurso);
            this.groupBox3.Controls.Add(this.lbNombreC);
            this.groupBox3.Location = new System.Drawing.Point(25, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 281);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "---------";
            // 
            // txtDocente
            // 
            this.txtDocente.BaseColor = System.Drawing.Color.White;
            this.txtDocente.BorderColor = System.Drawing.Color.Silver;
            this.txtDocente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDocente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDocente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDocente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocente.Location = new System.Drawing.Point(133, 154);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.PasswordChar = '\0';
            this.txtDocente.SelectedText = "";
            this.txtDocente.Size = new System.Drawing.Size(145, 30);
            this.txtDocente.TabIndex = 29;
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.AnimationHoverSpeed = 0.07F;
            this.btnBuscarDocente.AnimationSpeed = 0.03F;
            this.btnBuscarDocente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscarDocente.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarDocente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarDocente.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarDocente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarDocente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDocente.Image = null;
            this.btnBuscarDocente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarDocente.Location = new System.Drawing.Point(272, 154);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscarDocente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarDocente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarDocente.OnHoverImage = null;
            this.btnBuscarDocente.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarDocente.Size = new System.Drawing.Size(54, 30);
            this.btnBuscarDocente.TabIndex = 28;
            this.btnBuscarDocente.Text = "Buscar";
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = " Nombre del Curso:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(61, 154);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(60, 24);
            this.lbNombre.TabIndex = 24;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(133, 29);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(136, 30);
            this.txtNombreC.TabIndex = 25;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(133, 107);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(136, 30);
            this.txtAño.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Año:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(133, 71);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(136, 30);
            this.txtCurso.TabIndex = 5;
            // 
            // lbNombreC
            // 
            this.lbNombreC.AutoSize = true;
            this.lbNombreC.BackColor = System.Drawing.Color.White;
            this.lbNombreC.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreC.Location = new System.Drawing.Point(79, 71);
            this.lbNombreC.Name = "lbNombreC";
            this.lbNombreC.Size = new System.Drawing.Size(42, 18);
            this.lbNombreC.TabIndex = 3;
            this.lbNombreC.Text = "Curso:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNivelEducativo);
            this.groupBox1.Controls.Add(this.lbNivelE);
            this.groupBox1.Controls.Add(this.dvgCursos);
            this.groupBox1.Location = new System.Drawing.Point(401, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 370);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Cursos";
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
            this.cmbNivelEducativo.Location = new System.Drawing.Point(127, 38);
            this.cmbNivelEducativo.Name = "cmbNivelEducativo";
            this.cmbNivelEducativo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbNivelEducativo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbNivelEducativo.Size = new System.Drawing.Size(121, 26);
            this.cmbNivelEducativo.TabIndex = 2;
            this.cmbNivelEducativo.SelectionChangeCommitted += new System.EventHandler(this.cmbNivelEducativo_SelectionChangeCommitted);
            // 
            // lbNivelE
            // 
            this.lbNivelE.AutoSize = true;
            this.lbNivelE.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivelE.Location = new System.Drawing.Point(29, 43);
            this.lbNivelE.Name = "lbNivelE";
            this.lbNivelE.Size = new System.Drawing.Size(87, 17);
            this.lbNivelE.TabIndex = 1;
            this.lbNivelE.Text = "Nivel Educativo:";
            // 
            // dvgCursos
            // 
            this.dvgCursos.AllowUserToAddRows = false;
            this.dvgCursos.AllowUserToDeleteRows = false;
            this.dvgCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgCursos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dvgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCursos.Location = new System.Drawing.Point(6, 84);
            this.dvgCursos.Name = "dvgCursos";
            this.dvgCursos.ReadOnly = true;
            this.dvgCursos.Size = new System.Drawing.Size(348, 279);
            this.dvgCursos.TabIndex = 0;
            this.dvgCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCursos_CellClick);
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
            this.btnEliminar.Location = new System.Drawing.Point(286, 343);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Size = new System.Drawing.Size(65, 41);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnRegistrar.Location = new System.Drawing.Point(34, 343);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Size = new System.Drawing.Size(72, 41);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AnimationHoverSpeed = 0.07F;
            this.btnModificar.AnimationSpeed = 0.03F;
            this.btnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnModificar.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar.Location = new System.Drawing.Point(158, 343);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar.OnHoverImage = null;
            this.btnModificar.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar.Size = new System.Drawing.Size(73, 41);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbCursos);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurso";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCursos;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lbNombreC;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgCursos;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaButton btnModificar;
        private Guna.UI.WinForms.GunaTextBox txtDocente;
        private Guna.UI.WinForms.GunaButton btnBuscarDocente;
        private Guna.UI.WinForms.GunaComboBox cmbNivelEducativo;
        private Guna.UI.WinForms.GunaLabel lbNivelE;
    }
}