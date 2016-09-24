namespace RegistroUsuario
{
    partial class RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.PBFondo = new System.Windows.Forms.PictureBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBConfPass = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.ConfPass = new System.Windows.Forms.Label();
            this.CrearCuenta = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.CBVerPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // PBFondo
            // 
            this.PBFondo.Image = ((System.Drawing.Image)(resources.GetObject("PBFondo.Image")));
            this.PBFondo.Location = new System.Drawing.Point(1, 1);
            this.PBFondo.Name = "PBFondo";
            this.PBFondo.Size = new System.Drawing.Size(585, 526);
            this.PBFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFondo.TabIndex = 0;
            this.PBFondo.TabStop = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(103, 97);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(76, 22);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // TBnombre
            // 
            this.TBnombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBnombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.ForeColor = System.Drawing.Color.Silver;
            this.TBnombre.Location = new System.Drawing.Point(107, 133);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(369, 29);
            this.TBnombre.TabIndex = 2;
            this.TBnombre.Text = "Ejemplo: Juan Perez";
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnombre_KeyPress);
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.Silver;
            this.TBUsuario.Location = new System.Drawing.Point(107, 213);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(369, 29);
            this.TBUsuario.TabIndex = 3;
            this.TBUsuario.Text = "Ejemplo: juan02";
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // TBPass
            // 
            this.TBPass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPass.ForeColor = System.Drawing.Color.Silver;
            this.TBPass.Location = new System.Drawing.Point(107, 293);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(369, 29);
            this.TBPass.TabIndex = 4;
            this.TBPass.Text = "Contraseña";
            this.TBPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // TBConfPass
            // 
            this.TBConfPass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBConfPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBConfPass.ForeColor = System.Drawing.Color.Silver;
            this.TBConfPass.Location = new System.Drawing.Point(107, 373);
            this.TBConfPass.Name = "TBConfPass";
            this.TBConfPass.Size = new System.Drawing.Size(369, 29);
            this.TBConfPass.TabIndex = 5;
            this.TBConfPass.Text = "Contraseña";
            this.TBConfPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(103, 176);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(74, 22);
            this.Usuario.TabIndex = 6;
            this.Usuario.Text = "Usuario";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(103, 256);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(105, 22);
            this.Pass.TabIndex = 7;
            this.Pass.Text = "Contraseña";
            // 
            // ConfPass
            // 
            this.ConfPass.AutoSize = true;
            this.ConfPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfPass.Location = new System.Drawing.Point(103, 336);
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.Size = new System.Drawing.Size(196, 22);
            this.ConfPass.TabIndex = 8;
            this.ConfPass.Text = "Confirmar Contraseña";
            // 
            // CrearCuenta
            // 
            this.CrearCuenta.BackColor = System.Drawing.Color.LightGray;
            this.CrearCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.CrearCuenta.FlatAppearance.BorderSize = 0;
            this.CrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearCuenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCuenta.Location = new System.Drawing.Point(107, 466);
            this.CrearCuenta.Name = "CrearCuenta";
            this.CrearCuenta.Size = new System.Drawing.Size(369, 29);
            this.CrearCuenta.TabIndex = 9;
            this.CrearCuenta.Text = "Crear Cuenta";
            this.CrearCuenta.UseVisualStyleBackColor = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(167, 39);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(262, 36);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "Crear una Cuenta";
            // 
            // CBVerPass
            // 
            this.CBVerPass.AutoSize = true;
            this.CBVerPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBVerPass.Location = new System.Drawing.Point(226, 425);
            this.CBVerPass.Name = "CBVerPass";
            this.CBVerPass.Size = new System.Drawing.Size(137, 19);
            this.CBVerPass.TabIndex = 11;
            this.CBVerPass.Text = "Mostrar Contraseña";
            this.CBVerPass.UseVisualStyleBackColor = true;
            this.CBVerPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 527);
            this.Controls.Add(this.CBVerPass);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.CrearCuenta);
            this.Controls.Add(this.ConfPass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TBConfPass);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.PBFondo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(603, 566);
            this.MinimumSize = new System.Drawing.Size(603, 566);
            this.Name = "RegistroUsuario";
            this.Text = "Registro de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.PBFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBFondo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBConfPass;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label ConfPass;
        private System.Windows.Forms.Button CrearCuenta;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.CheckBox CBVerPass;
    }
}

