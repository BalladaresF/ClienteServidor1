namespace WindowsFormsApp1
{
    partial class ConsultarClientes
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
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.PrimerAp,
            this.SegundoAp,
            this.FechaNacimiento,
            this.Género});
            this.ListaClientes.Location = new System.Drawing.Point(52, 89);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.RowHeadersWidth = 62;
            this.ListaClientes.RowTemplate.Height = 28;
            this.ListaClientes.Size = new System.Drawing.Size(964, 279);
            this.ListaClientes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de clientes";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // PrimerAp
            // 
            this.PrimerAp.DataPropertyName = "ApellidoUno";
            this.PrimerAp.HeaderText = "1er apellido";
            this.PrimerAp.MinimumWidth = 8;
            this.PrimerAp.Name = "PrimerAp";
            this.PrimerAp.ReadOnly = true;
            this.PrimerAp.Width = 150;
            // 
            // SegundoAp
            // 
            this.SegundoAp.DataPropertyName = "ApellidoDos";
            this.SegundoAp.HeaderText = "2do apellido";
            this.SegundoAp.MinimumWidth = 8;
            this.SegundoAp.Name = "SegundoAp";
            this.SegundoAp.ReadOnly = true;
            this.SegundoAp.Width = 150;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha nacimiento";
            this.FechaNacimiento.MinimumWidth = 8;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 150;
            // 
            // Género
            // 
            this.Género.DataPropertyName = "Genero";
            this.Género.HeaderText = "Género";
            this.Género.MinimumWidth = 8;
            this.Género.Name = "Género";
            this.Género.ReadOnly = true;
            this.Género.Width = 150;
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1078, 421);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarClientes";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
    }
}