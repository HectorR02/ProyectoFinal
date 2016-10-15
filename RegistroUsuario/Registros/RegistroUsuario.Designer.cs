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
            this.components = new System.ComponentModel.Container();
            this.Nombre = new System.Windows.Forms.Label();
            this.TBnombreTextBox = new System.Windows.Forms.TextBox();
            this.TBUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.TBPassTextBox = new System.Windows.Forms.TextBox();
            this.TBConfPassTextBox = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.ConfPass = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.CBVerPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.TiposUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nombre.Location = new System.Drawing.Point(68, 145);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(109, 31);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // TBnombreTextBox
            // 
            this.TBnombreTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBnombreTextBox.Enabled = false;
            this.TBnombreTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombreTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TBnombreTextBox.Location = new System.Drawing.Point(72, 181);
            this.TBnombreTextBox.Name = "TBnombreTextBox";
            this.TBnombreTextBox.Size = new System.Drawing.Size(582, 35);
            this.TBnombreTextBox.TabIndex = 2;
            this.TBnombreTextBox.Text = "Ejemplo: Juan Perez";
            // 
            // TBUsuarioTextBox
            // 
            this.TBUsuarioTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBUsuarioTextBox.Enabled = false;
            this.TBUsuarioTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuarioTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TBUsuarioTextBox.Location = new System.Drawing.Point(72, 261);
            this.TBUsuarioTextBox.MaxLength = 12;
            this.TBUsuarioTextBox.Name = "TBUsuarioTextBox";
            this.TBUsuarioTextBox.Size = new System.Drawing.Size(582, 35);
            this.TBUsuarioTextBox.TabIndex = 3;
            this.TBUsuarioTextBox.Text = "Ejemplo: juan02";
            // 
            // TBPassTextBox
            // 
            this.TBPassTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBPassTextBox.Enabled = false;
            this.TBPassTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TBPassTextBox.Location = new System.Drawing.Point(72, 341);
            this.TBPassTextBox.MaxLength = 10;
            this.TBPassTextBox.Name = "TBPassTextBox";
            this.TBPassTextBox.Size = new System.Drawing.Size(582, 35);
            this.TBPassTextBox.TabIndex = 4;
            this.TBPassTextBox.Text = "Contraseña";
            // 
            // TBConfPassTextBox
            // 
            this.TBConfPassTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBConfPassTextBox.Enabled = false;
            this.TBConfPassTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBConfPassTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TBConfPassTextBox.Location = new System.Drawing.Point(72, 421);
            this.TBConfPassTextBox.MaxLength = 10;
            this.TBConfPassTextBox.Name = "TBConfPassTextBox";
            this.TBConfPassTextBox.Size = new System.Drawing.Size(582, 35);
            this.TBConfPassTextBox.TabIndex = 5;
            this.TBConfPassTextBox.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Usuario.Location = new System.Drawing.Point(68, 224);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(108, 31);
            this.Usuario.TabIndex = 6;
            this.Usuario.Text = "Usuario";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Gainsboro;
            this.Pass.Location = new System.Drawing.Point(68, 304);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(150, 31);
            this.Pass.TabIndex = 7;
            this.Pass.Text = "Contraseña";
            // 
            // ConfPass
            // 
            this.ConfPass.AutoSize = true;
            this.ConfPass.BackColor = System.Drawing.Color.Transparent;
            this.ConfPass.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.ConfPass.Location = new System.Drawing.Point(68, 384);
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.Size = new System.Drawing.Size(283, 31);
            this.ConfPass.TabIndex = 8;
            this.ConfPass.Text = "Confirmar Contraseña";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo.Location = new System.Drawing.Point(179, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(356, 49);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "Crear una Cuenta";
            // 
            // CBVerPass
            // 
            this.CBVerPass.AutoSize = true;
            this.CBVerPass.Enabled = false;
            this.CBVerPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBVerPass.Location = new System.Drawing.Point(489, 384);
            this.CBVerPass.Name = "CBVerPass";
            this.CBVerPass.Size = new System.Drawing.Size(165, 23);
            this.CBVerPass.TabIndex = 11;
            this.CBVerPass.Text = "Mostrar Contraseña";
            this.CBVerPass.UseVisualStyleBackColor = true;
            this.CBVerPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(68, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Usuario";
            // 
            // IdUsuarioTextBox
            // 
            this.IdUsuarioTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IdUsuarioTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuarioTextBox.ForeColor = System.Drawing.Color.Silver;
            this.IdUsuarioTextBox.Location = new System.Drawing.Point(72, 103);
            this.IdUsuarioTextBox.Name = "IdUsuarioTextBox";
            this.IdUsuarioTextBox.Size = new System.Drawing.Size(408, 35);
            this.IdUsuarioTextBox.TabIndex = 13;
            this.IdUsuarioTextBox.Text = "Ejemplo: 0001";
            this.IdUsuarioTextBox.TextChanged += new System.EventHandler(this.IdUsuario_TextChanged);
            // 
            // TiposUsuarioComboBox
            // 
            this.TiposUsuarioComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TiposUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TiposUsuarioComboBox.Enabled = false;
            this.TiposUsuarioComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiposUsuarioComboBox.FormattingEnabled = true;
            this.TiposUsuarioComboBox.Location = new System.Drawing.Point(72, 495);
            this.TiposUsuarioComboBox.Name = "TiposUsuarioComboBox";
            this.TiposUsuarioComboBox.Size = new System.Drawing.Size(582, 34);
            this.TiposUsuarioComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(68, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de Usuario";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::RegistroUsuario.Properties.Resources.BotonAñadir;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(72, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "Nuevo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.LightGray;
            this.Eliminar.Enabled = false;
            this.Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Image = global::RegistroUsuario.Properties.Resources.BotonCancelar;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(500, 562);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(154, 49);
            this.Eliminar.TabIndex = 17;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Buscar
            // 
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Image = global::RegistroUsuario.Properties.Resources.BotonBusqueda;
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar.Location = new System.Drawing.Point(507, 93);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(147, 52);
            this.Buscar.TabIndex = 14;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.LightGray;
            this.Guardar.Enabled = false;
            this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Image = global::RegistroUsuario.Properties.Resources.BotonGuardar1;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(283, 562);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(155, 49);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.CrearCuenta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::RegistroUsuario.Properties.Resources.IMG_7130;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 627);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TiposUsuarioComboBox);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.IdUsuarioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBVerPass);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.ConfPass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TBConfPassTextBox);
            this.Controls.Add(this.TBPassTextBox);
            this.Controls.Add(this.TBUsuarioTextBox);
            this.Controls.Add(this.TBnombreTextBox);
            this.Controls.Add(this.Nombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 666);
            this.MinimumSize = new System.Drawing.Size(636, 666);
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TBnombreTextBox;
        private System.Windows.Forms.TextBox TBUsuarioTextBox;
        private System.Windows.Forms.TextBox TBPassTextBox;
        private System.Windows.Forms.TextBox TBConfPassTextBox;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label ConfPass;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.CheckBox CBVerPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdUsuarioTextBox;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.ComboBox TiposUsuarioComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

