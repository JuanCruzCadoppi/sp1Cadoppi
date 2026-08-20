namespace sp1Cadoppi
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
            lblUser = new Label();
            lblPassword = new Label();
            lblModulo = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cmbModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(59, 57);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(59, 98);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(59, 139);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo";
            // 
            // txtUser
            // 
            txtUser.ForeColor = SystemColors.WindowText;
            txtUser.Location = new Point(149, 54);
            txtUser.MaxLength = 10;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(121, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 95);
            txtPassword.MaxLength = 10;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(121, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(319, 54);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(319, 95);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.ImeMode = ImeMode.NoControl;
            cmbModulo.Items.AddRange(new object[] { "ADM\t", "COM", "SIST", "VTA" });
            cmbModulo.Location = new Point(149, 136);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.RightToLeft = RightToLeft.No;
            cmbModulo.Size = new Size(121, 23);
            cmbModulo.Sorted = true;
            cmbModulo.TabIndex = 7;
            cmbModulo.UseWaitCursor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 211);
            Controls.Add(cmbModulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblModulo);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPassword;
        private Label lblModulo;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cmbModulo;
    }
}