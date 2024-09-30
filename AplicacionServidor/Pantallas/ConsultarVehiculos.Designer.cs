namespace WindowsFormsApp1
{
    partial class ConsultarVehiculos
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
            this.ListaVehiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaVehiculos
            // 
            this.ListaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPlaca,
            this.Marca,
            this.Modelo,
            this.IDTipo,
            this.CostoAlquiler,
            this.Kilometraje});
            this.ListaVehiculos.Location = new System.Drawing.Point(77, 88);
            this.ListaVehiculos.Name = "ListaVehiculos";
            this.ListaVehiculos.RowHeadersWidth = 62;
            this.ListaVehiculos.RowTemplate.Height = 28;
            this.ListaVehiculos.Size = new System.Drawing.Size(965, 279);
            this.ListaVehiculos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de vehículos\r\n";
            // 
            // IDPlaca
            // 
            this.IDPlaca.DataPropertyName = "Placa";
            this.IDPlaca.HeaderText = "ID de la placa";
            this.IDPlaca.MinimumWidth = 8;
            this.IDPlaca.Name = "IDPlaca";
            this.IDPlaca.ReadOnly = true;
            this.IDPlaca.Width = 150;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 150;
            // 
            // IDTipo
            // 
            this.IDTipo.DataPropertyName = "IDTipo";
            this.IDTipo.HeaderText = "ID del tipo";
            this.IDTipo.MinimumWidth = 8;
            this.IDTipo.Name = "IDTipo";
            this.IDTipo.ReadOnly = true;
            this.IDTipo.Width = 150;
            // 
            // CostoAlquiler
            // 
            this.CostoAlquiler.DataPropertyName = "CostoAlquilerDia";
            this.CostoAlquiler.HeaderText = "Costo del alquiler";
            this.CostoAlquiler.MinimumWidth = 8;
            this.CostoAlquiler.Name = "CostoAlquiler";
            this.CostoAlquiler.ReadOnly = true;
            this.CostoAlquiler.Width = 150;
            // 
            // Kilometraje
            // 
            this.Kilometraje.DataPropertyName = "Kilometraje";
            this.Kilometraje.HeaderText = "Kilometraje";
            this.Kilometraje.MinimumWidth = 8;
            this.Kilometraje.Name = "Kilometraje";
            this.Kilometraje.ReadOnly = true;
            this.Kilometraje.Width = 150;
            // 
            // ConsultarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1122, 420);
            this.Controls.Add(this.ListaVehiculos);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarVehiculos";
            this.Text = "ConsultarVehiculos";
            this.Load += new System.EventHandler(this.ConsultarVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoAlquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometraje;
    }
}