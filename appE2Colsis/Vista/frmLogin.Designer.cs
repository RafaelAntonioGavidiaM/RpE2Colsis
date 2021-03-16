
namespace appE2Colsis.Vista
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtUser = new Guna.UI.WinForms.GunaTextBox();
            this.txtPswd = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.pSettings = new Guna.UI.WinForms.GunaPictureBox();
            this.grpSetting = new Guna.UI.WinForms.GunaGroupBox();
            this.txtDataBaseDB = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordDB = new Guna.UI.WinForms.GunaTextBox();
            this.txtUserDB = new Guna.UI.WinForms.GunaTextBox();
            this.txtPortDB = new Guna.UI.WinForms.GunaTextBox();
            this.txtServerDB = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSettings)).BeginInit();
            this.grpSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(95, 234);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(110, 41);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Login";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(31, 106);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(40, 19);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "User";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(9, 182);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 19);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BaseColor = System.Drawing.Color.White;
            this.txtUser.BorderColor = System.Drawing.Color.Silver;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.Location = new System.Drawing.Point(95, 95);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.Radius = 17;
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(129, 41);
            this.txtUser.TabIndex = 3;
            // 
            // txtPswd
            // 
            this.txtPswd.BackColor = System.Drawing.Color.Transparent;
            this.txtPswd.BaseColor = System.Drawing.Color.White;
            this.txtPswd.BorderColor = System.Drawing.Color.Silver;
            this.txtPswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPswd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPswd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPswd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPswd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPswd.Location = new System.Drawing.Point(95, 168);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '●';
            this.txtPswd.Radius = 18;
            this.txtPswd.SelectedText = "";
            this.txtPswd.Size = new System.Drawing.Size(129, 43);
            this.txtPswd.TabIndex = 4;
            this.txtPswd.UseSystemPasswordChar = true;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(117, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(71, 65);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.Color.Transparent;
            this.pSettings.BaseColor = System.Drawing.Color.Transparent;
            this.pSettings.Image = ((System.Drawing.Image)(resources.GetObject("pSettings.Image")));
            this.pSettings.Location = new System.Drawing.Point(257, 245);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(42, 30);
            this.pSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSettings.TabIndex = 6;
            this.pSettings.TabStop = false;
            this.pSettings.Click += new System.EventHandler(this.pSettings_Click);
            // 
            // grpSetting
            // 
            this.grpSetting.BackColor = System.Drawing.Color.White;
            this.grpSetting.BaseColor = System.Drawing.Color.Transparent;
            this.grpSetting.BorderColor = System.Drawing.Color.Transparent;
            this.grpSetting.Controls.Add(this.txtDataBaseDB);
            this.grpSetting.Controls.Add(this.label5);
            this.grpSetting.Controls.Add(this.txtPasswordDB);
            this.grpSetting.Controls.Add(this.txtUserDB);
            this.grpSetting.Controls.Add(this.txtPortDB);
            this.grpSetting.Controls.Add(this.txtServerDB);
            this.grpSetting.Controls.Add(this.gunaButton2);
            this.grpSetting.Controls.Add(this.label4);
            this.grpSetting.Controls.Add(this.label3);
            this.grpSetting.Controls.Add(this.label2);
            this.grpSetting.Controls.Add(this.label1);
            this.grpSetting.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSetting.ForeColor = System.Drawing.Color.Black;
            this.grpSetting.LineColor = System.Drawing.Color.Transparent;
            this.grpSetting.Location = new System.Drawing.Point(35, 14);
            this.grpSetting.Name = "grpSetting";
            this.grpSetting.Size = new System.Drawing.Size(239, 214);
            this.grpSetting.TabIndex = 7;
            this.grpSetting.Text = "Settings";
            this.grpSetting.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtDataBaseDB
            // 
            this.txtDataBaseDB.BaseColor = System.Drawing.Color.White;
            this.txtDataBaseDB.BorderColor = System.Drawing.Color.Silver;
            this.txtDataBaseDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataBaseDB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDataBaseDB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDataBaseDB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDataBaseDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDataBaseDB.Location = new System.Drawing.Point(88, 75);
            this.txtDataBaseDB.Name = "txtDataBaseDB";
            this.txtDataBaseDB.PasswordChar = '\0';
            this.txtDataBaseDB.SelectedText = "";
            this.txtDataBaseDB.Size = new System.Drawing.Size(116, 26);
            this.txtDataBaseDB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "DataBase:";
            // 
            // txtPasswordDB
            // 
            this.txtPasswordDB.BaseColor = System.Drawing.Color.White;
            this.txtPasswordDB.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordDB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasswordDB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPasswordDB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordDB.Location = new System.Drawing.Point(160, 144);
            this.txtPasswordDB.Name = "txtPasswordDB";
            this.txtPasswordDB.PasswordChar = '*';
            this.txtPasswordDB.SelectedText = "";
            this.txtPasswordDB.Size = new System.Drawing.Size(66, 26);
            this.txtPasswordDB.TabIndex = 8;
            // 
            // txtUserDB
            // 
            this.txtUserDB.BaseColor = System.Drawing.Color.White;
            this.txtUserDB.BorderColor = System.Drawing.Color.Silver;
            this.txtUserDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserDB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserDB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserDB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserDB.Location = new System.Drawing.Point(43, 144);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.PasswordChar = '\0';
            this.txtUserDB.SelectedText = "";
            this.txtUserDB.Size = new System.Drawing.Size(65, 26);
            this.txtUserDB.TabIndex = 7;
            // 
            // txtPortDB
            // 
            this.txtPortDB.BaseColor = System.Drawing.Color.White;
            this.txtPortDB.BorderColor = System.Drawing.Color.Silver;
            this.txtPortDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPortDB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPortDB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPortDB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPortDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPortDB.Location = new System.Drawing.Point(53, 112);
            this.txtPortDB.Name = "txtPortDB";
            this.txtPortDB.PasswordChar = '\0';
            this.txtPortDB.SelectedText = "";
            this.txtPortDB.Size = new System.Drawing.Size(93, 26);
            this.txtPortDB.TabIndex = 6;
            // 
            // txtServerDB
            // 
            this.txtServerDB.BaseColor = System.Drawing.Color.White;
            this.txtServerDB.BorderColor = System.Drawing.Color.Silver;
            this.txtServerDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerDB.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServerDB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtServerDB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServerDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServerDB.Location = new System.Drawing.Point(61, 33);
            this.txtServerDB.Name = "txtServerDB";
            this.txtServerDB.PasswordChar = '\0';
            this.txtServerDB.SelectedText = "";
            this.txtServerDB.Size = new System.Drawing.Size(120, 26);
            this.txtServerDB.TabIndex = 5;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(93, 182);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 20;
            this.gunaButton2.Size = new System.Drawing.Size(64, 29);
            this.gunaButton2.TabIndex = 4;
            this.gunaButton2.Text = "Save";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(114, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pswd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(312, 323);
            this.Controls.Add(this.grpSetting);
            this.Controls.Add(this.pSettings);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSettings)).EndInit();
            this.grpSetting.ResumeLayout(false);
            this.grpSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox txtPswd;
        private Guna.UI.WinForms.GunaTextBox txtUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox pSettings;
        private Guna.UI.WinForms.GunaGroupBox grpSetting;
        private Guna.UI.WinForms.GunaTextBox txtPasswordDB;
        private Guna.UI.WinForms.GunaTextBox txtUserDB;
        private Guna.UI.WinForms.GunaTextBox txtPortDB;
        private Guna.UI.WinForms.GunaTextBox txtServerDB;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtDataBaseDB;
        private System.Windows.Forms.Label label5;
    }
}