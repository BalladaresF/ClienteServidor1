namespace WindowsFormsApp1
{
    partial class RegistrarVehiculoSucursal
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
            this.Aviso = new System.Windows.Forms.Label();
            this.ComboBoxSucur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Button();
            this.ListaVehiculos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.VehiculosAgregados = new System.Windows.Forms.DataGridView();
            this.SIDPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosAgregados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar vehículos por sucursal";
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.White;
            this.Aviso.Location = new System.Drawing.Point(276, 83);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(259, 25);
            this.Aviso.TabIndex = 16;
            this.Aviso.Text = "Ingrese los siguientes datos:\r\n";
            // 
            // ComboBoxSucur
            // 
            this.ComboBoxSucur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSucur.FormattingEnabled = true;
            this.ComboBoxSucur.Location = new System.Drawing.Point(392, 179);
            this.ComboBoxSucur.Name = "ComboBoxSucur";
            this.ComboBoxSucur.Size = new System.Drawing.Size(274, 28);
            this.ComboBoxSucur.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sucursal:";
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registrar.Location = new System.Drawing.Point(231, 725);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(350, 51);
            this.Registrar.TabIndex = 19;
            this.Registrar.Text = "Registrar vehículos a sucursal";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // ListaVehiculos
            // 
            this.ListaVehiculos.AllowUserToAddRows = false;
            this.ListaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.IDPlaca,
            this.Marca,
            this.Modelo});
            this.ListaVehiculos.Location = new System.Drawing.Point(74, 293);
            this.ListaVehiculos.Name = "ListaVehiculos";
            this.ListaVehiculos.RowHeadersWidth = 62;
            this.ListaVehiculos.RowTemplate.Height = 28;
            this.ListaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaVehiculos.Size = new System.Drawing.Size(665, 175);
            this.ListaVehiculos.TabIndex = 20;
            this.ListaVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaVehiculos_CellClick);
            this.ListaVehiculos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListaVehiculos_MouseClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 150;
            // 
            // IDPlaca
            // 
            this.IDPlaca.HeaderText = "ID placa";
            this.IDPlaca.MinimumWidth = 8;
            this.IDPlaca.Name = "IDPlaca";
            this.IDPlaca.ReadOnly = true;
            this.IDPlaca.Width = 150;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(205, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seleccione el vehículo que desea agregar.";
            // 
            // VehiculosAgregados
            // 
            this.VehiculosAgregados.AllowUserToAddRows = false;
            this.VehiculosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIDPlaca,
            this.SMarca,
            this.SModelo});
            this.VehiculosAgregados.Location = new System.Drawing.Point(152, 536);
            this.VehiculosAgregados.Name = "VehiculosAgregados";
            this.VehiculosAgregados.RowHeadersWidth = 62;
            this.VehiculosAgregados.RowTemplate.Height = 28;
            this.VehiculosAgregados.Size = new System.Drawing.Size(514, 170);
            this.VehiculosAgregados.TabIndex = 22;
            // 
            // SIDPlaca
            // 
            this.SIDPlaca.HeaderText = "ID Placa";
            this.SIDPlaca.MinimumWidth = 8;
            this.SIDPlaca.Name = "SIDPlaca";
            this.SIDPlaca.ReadOnly = true;
            this.SIDPlaca.Width = 150;
            // 
            // SMarca
            // 
            this.SMarca.HeaderText = "Marca";
            this.SMarca.MinimumWidth = 8;
            this.SMarca.Name = "SMarca";
            this.SMarca.ReadOnly = true;
            this.SMarca.Width = 150;
            // 
            // SModelo
            // 
            this.SModelo.HeaderText = "Modelo";
            this.SModelo.MinimumWidth = 8;
            this.SModelo.Name = "SModelo";
            this.SModelo.ReadOnly = true;
            this.SModelo.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(264, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lista de vehículos agregados:";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(392, 142);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(274, 26);
            this.TextBoxID.TabIndex = 25;
            this.TextBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID de asignación:";
            // 
            // RegistrarVehiculoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(814, 799);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VehiculosAgregados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaVehiculos);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxSucur);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarVehiculoSucursal";
            this.Text = "RegistrarVehiculoSucursal";
            this.Load += new System.EventHandler(this.RegistrarVehiculoSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosAgregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.ComboBox ComboBoxSucur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.DataGridView ListaVehiculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView VehiculosAgregados;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIDPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn SModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
    }
}