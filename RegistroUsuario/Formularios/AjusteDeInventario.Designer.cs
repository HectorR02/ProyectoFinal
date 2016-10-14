namespace RegistroUsuario.Formularios
{
    partial class AjusteDeInventario
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
            this.TipoDeHuevoComboBox = new System.Windows.Forms.ComboBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.DisminuirButton = new System.Windows.Forms.Button();
            this.AumentarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TipoDeHuevoComboBox
            // 
            this.TipoDeHuevoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeHuevoComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoDeHuevoComboBox.FormattingEnabled = true;
            this.TipoDeHuevoComboBox.Location = new System.Drawing.Point(27, 73);
            this.TipoDeHuevoComboBox.Name = "TipoDeHuevoComboBox";
            this.TipoDeHuevoComboBox.Size = new System.Drawing.Size(237, 32);
            this.TipoDeHuevoComboBox.TabIndex = 1;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTextBox.Location = new System.Drawing.Point(317, 73);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(237, 32);
            this.CantidadTextBox.TabIndex = 3;
            // 
            // DisminuirButton
            // 
            this.DisminuirButton.FlatAppearance.BorderSize = 0;
            this.DisminuirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisminuirButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisminuirButton.Image = global::RegistroUsuario.Properties.Resources.Disminuir;
            this.DisminuirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisminuirButton.Location = new System.Drawing.Point(317, 146);
            this.DisminuirButton.Name = "DisminuirButton";
            this.DisminuirButton.Size = new System.Drawing.Size(154, 47);
            this.DisminuirButton.TabIndex = 4;
            this.DisminuirButton.Text = "Disminuir";
            this.DisminuirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisminuirButton.UseVisualStyleBackColor = true;
            this.DisminuirButton.Click += new System.EventHandler(this.DisminuirButton_Click);
            // 
            // AumentarButton
            // 
            this.AumentarButton.FlatAppearance.BorderSize = 0;
            this.AumentarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AumentarButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AumentarButton.Image = global::RegistroUsuario.Properties.Resources.Aumentar;
            this.AumentarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AumentarButton.Location = new System.Drawing.Point(116, 146);
            this.AumentarButton.Name = "AumentarButton";
            this.AumentarButton.Size = new System.Drawing.Size(148, 47);
            this.AumentarButton.TabIndex = 0;
            this.AumentarButton.Text = "Aumentar";
            this.AumentarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AumentarButton.UseVisualStyleBackColor = true;
            this.AumentarButton.Click += new System.EventHandler(this.AumentarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo De Huevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad ";
            // 
            // AjusteDeInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisminuirButton);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.TipoDeHuevoComboBox);
            this.Controls.Add(this.AumentarButton);
            this.Name = "AjusteDeInventario";
            this.Text = "Ajuste de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AumentarButton;
        private System.Windows.Forms.ComboBox TipoDeHuevoComboBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Button DisminuirButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}