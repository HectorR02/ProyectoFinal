namespace RegistroUsuario.Formularios
{
    partial class InventarioHuevos
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
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.TipoDeHuevoComboBox1 = new System.Windows.Forms.ComboBox();
            this.HuevoIdTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(12, 74);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(423, 150);
            this.ConsultaDataGridView.TabIndex = 0;
            // 
            // TipoDeHuevoComboBox1
            // 
            this.TipoDeHuevoComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeHuevoComboBox1.FormattingEnabled = true;
            this.TipoDeHuevoComboBox1.Location = new System.Drawing.Point(12, 38);
            this.TipoDeHuevoComboBox1.Name = "TipoDeHuevoComboBox1";
            this.TipoDeHuevoComboBox1.Size = new System.Drawing.Size(168, 21);
            this.TipoDeHuevoComboBox1.TabIndex = 2;
            // 
            // HuevoIdTextBox1
            // 
            this.HuevoIdTextBox1.Location = new System.Drawing.Point(197, 39);
            this.HuevoIdTextBox1.Name = "HuevoIdTextBox1";
            this.HuevoIdTextBox1.Size = new System.Drawing.Size(163, 20);
            this.HuevoIdTextBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Huevo Id";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Image = global::RegistroUsuario.Properties.Resources.BotonBusqueda;
            this.button1.Location = new System.Drawing.Point(380, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InventarioHuevos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HuevoIdTextBox1);
            this.Controls.Add(this.TipoDeHuevoComboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConsultaDataGridView);
            this.MaximizeBox = false;
            this.Name = "InventarioHuevos";
            this.Text = "InventarioHuevos";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TipoDeHuevoComboBox1;
        private System.Windows.Forms.TextBox HuevoIdTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}