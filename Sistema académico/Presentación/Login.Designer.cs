namespace Sistema_académico.Presentación
{
    partial class Login
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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.txtContraseña = new Telerik.WinControls.UI.RadTextBox();
            this.btnAcepta = new Telerik.WinControls.UI.RadButton();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.labelRegistrarNuevoUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcepta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(45, 198);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "USUARIO:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(45, 253);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(80, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "CONTRASEÑA:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(45, 222);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(289, 22);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.ThemeName = "Breeze";
            this.txtUsuario.UseGenericBorderPaint = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(45, 277);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(289, 22);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.ThemeName = "Breeze";
            this.txtContraseña.UseGenericBorderPaint = true;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnAcepta
            // 
            this.btnAcepta.Location = new System.Drawing.Point(45, 317);
            this.btnAcepta.Name = "btnAcepta";
            this.btnAcepta.Size = new System.Drawing.Size(289, 31);
            this.btnAcepta.TabIndex = 9;
            this.btnAcepta.Text = "Aceptar";
            this.btnAcepta.ThemeName = "Breeze";
            this.btnAcepta.Click += new System.EventHandler(this.btnAcepta_Click);
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radLabelElement1.Text = "Para acceder al sistema es necesario ingresar el usuario y contraseña.";
            this.radLabelElement1.TextWrap = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(106, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(144, 30);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_académico.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(116, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelRegistrarNuevoUsuario
            // 
            this.labelRegistrarNuevoUsuario.AutoSize = true;
            this.labelRegistrarNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistrarNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarNuevoUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRegistrarNuevoUsuario.Location = new System.Drawing.Point(203, 387);
            this.labelRegistrarNuevoUsuario.Name = "labelRegistrarNuevoUsuario";
            this.labelRegistrarNuevoUsuario.Size = new System.Drawing.Size(131, 15);
            this.labelRegistrarNuevoUsuario.TabIndex = 12;
            this.labelRegistrarNuevoUsuario.Text = "Registrar nuevo usuario";
            this.labelRegistrarNuevoUsuario.MouseLeave += new System.EventHandler(this.labelRegistrarNuevoUsuario_MouseLeave);
            this.labelRegistrarNuevoUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRegistrarNuevoUsuario_MouseMove);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 427);
            this.Controls.Add(this.labelRegistrarNuevoUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnAcepta);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.ThemeName = "Office2013Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcepta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtUsuario;
        private Telerik.WinControls.UI.RadTextBox txtContraseña;
        private Telerik.WinControls.UI.RadButton btnAcepta;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private System.Windows.Forms.Label labelRegistrarNuevoUsuario;
    }
}
