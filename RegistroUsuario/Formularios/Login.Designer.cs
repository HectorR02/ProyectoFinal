namespace RegistroUsuario.Formularios
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
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.BIniciarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UsuarioTextBox.CausesValidation = false;
            this.UsuarioTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.Silver;
            this.UsuarioTextBox.Location = new System.Drawing.Point(96, 97);
            this.UsuarioTextBox.MaxLength = 15;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(219, 32);
            this.UsuarioTextBox.TabIndex = 6;
            this.UsuarioTextBox.Text = "Usuario";
            this.UsuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.ContraseñaTextBox.Location = new System.Drawing.Point(96, 163);
            this.ContraseñaTextBox.MaxLength = 12;
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(219, 32);
            this.ContraseñaTextBox.TabIndex = 7;
            this.ContraseñaTextBox.Text = "Contraseña";
            this.ContraseñaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContraseñaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // BIniciarSesion
            // 
            this.BIniciarSesion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BIniciarSesion.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIniciarSesion.Location = new System.Drawing.Point(96, 256);
            this.BIniciarSesion.Name = "BIniciarSesion";
            this.BIniciarSesion.Size = new System.Drawing.Size(219, 32);
            this.BIniciarSesion.TabIndex = 8;
            this.BIniciarSesion.Text = "Iniciar Sesion";
            this.BIniciarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BIniciarSesion.UseVisualStyleBackColor = false;
            this.BIniciarSesion.Click += new System.EventHandler(this.BIniciarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Iniciar Sesión";
            // 
            // CBMostrarContraseña
            // 
            this.CBMostrarContraseña.AutoSize = true;
            this.CBMostrarContraseña.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMostrarContraseña.ForeColor = System.Drawing.Color.Silver;
            this.CBMostrarContraseña.Location = new System.Drawing.Point(134, 213);
            this.CBMostrarContraseña.Name = "CBMostrarContraseña";
            this.CBMostrarContraseña.Size = new System.Drawing.Size(137, 19);
            this.CBMostrarContraseña.TabIndex = 10;
            this.CBMostrarContraseña.Text = "Mostrar Contraseña";
            this.CBMostrarContraseña.UseVisualStyleBackColor = true;
            this.CBMostrarContraseña.CheckedChanged += new System.EventHandler(this.CBMostrarContraseña_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroUsuario.Properties.Resources.IMG_7130;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 329);
            this.Controls.Add(this.CBMostrarContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BIniciarSesion);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(433, 368);
            this.MinimumSize = new System.Drawing.Size(433, 368);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button BIniciarSesion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.CheckBox CBMostrarContraseña;
    }
}

