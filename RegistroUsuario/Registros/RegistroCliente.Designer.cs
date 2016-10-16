namespace RegistroUsuario.Registros
{
    partial class RegistroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrganizacionTextBox = new System.Windows.Forms.TextBox();
            this.RepresentanteTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClienteIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(64, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(64, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Representante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(64, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(64, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // OrganizacionTextBox
            // 
            this.OrganizacionTextBox.Enabled = false;
            this.OrganizacionTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrganizacionTextBox.ForeColor = System.Drawing.Color.Silver;
            this.OrganizacionTextBox.Location = new System.Drawing.Point(70, 168);
            this.OrganizacionTextBox.Name = "OrganizacionTextBox";
            this.OrganizacionTextBox.Size = new System.Drawing.Size(483, 35);
            this.OrganizacionTextBox.TabIndex = 4;
            this.OrganizacionTextBox.Text = "Ejemplo: SuperMarket Pa\' Comer";
            this.OrganizacionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrganizacionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RepresentanteTextBox
            // 
            this.RepresentanteTextBox.Enabled = false;
            this.RepresentanteTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepresentanteTextBox.ForeColor = System.Drawing.Color.Silver;
            this.RepresentanteTextBox.Location = new System.Drawing.Point(70, 252);
            this.RepresentanteTextBox.Name = "RepresentanteTextBox";
            this.RepresentanteTextBox.Size = new System.Drawing.Size(483, 35);
            this.RepresentanteTextBox.TabIndex = 5;
            this.RepresentanteTextBox.Text = "Ejemplo: Juan Pérez";
            this.RepresentanteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RepresentanteTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Enabled = false;
            this.DireccionTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextBox.ForeColor = System.Drawing.Color.Silver;
            this.DireccionTextBox.Location = new System.Drawing.Point(70, 329);
            this.DireccionTextBox.Multiline = true;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(483, 40);
            this.DireccionTextBox.TabIndex = 6;
            this.DireccionTextBox.Text = "Ejemplo: Los Ríos #30, Sto. Dgo.";
            this.DireccionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DireccionTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.BackColor = System.Drawing.Color.LightGray;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.FlatAppearance.BorderSize = 0;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::RegistroUsuario.Properties.Resources.BotonGuardar1;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(224, 499);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(153, 54);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = false;
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.Color.LightGray;
            this.NuevoButton.FlatAppearance.BorderSize = 0;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::RegistroUsuario.Properties.Resources.BotonAñadir;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(29, 499);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(130, 54);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.AutoSize = true;
            this.EliminarButton.BackColor = System.Drawing.Color.LightGray;
            this.EliminarButton.Enabled = false;
            this.EliminarButton.FlatAppearance.BorderSize = 0;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::RegistroUsuario.Properties.Resources.BotonCancelar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(446, 499);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(152, 54);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.LightGray;
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::RegistroUsuario.Properties.Resources.BotonBusqueda;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(420, 74);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(133, 50);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = false;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Enabled = false;
            this.TelefonoMaskedTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoMaskedTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(70, 411);
            this.TelefonoMaskedTextBox.Mask = "(999) 999-9999";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(483, 35);
            this.TelefonoMaskedTextBox.TabIndex = 11;
            this.TelefonoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TelefonoMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoMaskedTextBox_KeyPress);
            // 
            // ClienteIdTextBox
            // 
            this.ClienteIdTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteIdTextBox.ForeColor = System.Drawing.Color.Silver;
            this.ClienteIdTextBox.Location = new System.Drawing.Point(70, 82);
            this.ClienteIdTextBox.MaxLength = 4;
            this.ClienteIdTextBox.Name = "ClienteIdTextBox";
            this.ClienteIdTextBox.Size = new System.Drawing.Size(294, 35);
            this.ClienteIdTextBox.TabIndex = 13;
            this.ClienteIdTextBox.Text = "Ejemplo: 0001";
            this.ClienteIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(64, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente Id";
            // 
            // RegistroCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::RegistroUsuario.Properties.Resources.IMG_7130;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 579);
            this.Controls.Add(this.ClienteIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.RepresentanteTextBox);
            this.Controls.Add(this.OrganizacionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(640, 618);
            this.MinimumSize = new System.Drawing.Size(640, 618);
            this.Name = "RegistroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrganizacionTextBox;
        private System.Windows.Forms.TextBox RepresentanteTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.TextBox ClienteIdTextBox;
        private System.Windows.Forms.Label label5;
    }
}