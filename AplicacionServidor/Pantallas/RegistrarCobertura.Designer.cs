﻿namespace WindowsFormsApp1
{
    partial class RegistrarCobertura
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxDesc = new System.Windows.Forms.TextBox();
            this.TextBoxMon = new System.Windows.Forms.TextBox();
            this.ComboBoxEst = new System.Windows.Forms.ComboBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.Aviso = new System.Windows.Forms.Label();
            this.ComboBoxIDTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar cobertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID tipo del vehículo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(78, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto:";
            // 
            // TextBoxDesc
            // 
            this.TextBoxDesc.Location = new System.Drawing.Point(287, 171);
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.Size = new System.Drawing.Size(219, 26);
            this.TextBoxDesc.TabIndex = 10;
            // 
            // TextBoxMon
            // 
            this.TextBoxMon.Location = new System.Drawing.Point(287, 317);
            this.TextBoxMon.Name = "TextBoxMon";
            this.TextBoxMon.Size = new System.Drawing.Size(219, 26);
            this.TextBoxMon.TabIndex = 12;
            this.TextBoxMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMon_KeyPress);
            // 
            // ComboBoxEst
            // 
            this.ComboBoxEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEst.FormattingEnabled = true;
            this.ComboBoxEst.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.ComboBoxEst.Location = new System.Drawing.Point(287, 266);
            this.ComboBoxEst.Name = "ComboBoxEst";
            this.ComboBoxEst.Size = new System.Drawing.Size(219, 28);
            this.ComboBoxEst.TabIndex = 13;
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registrar.Location = new System.Drawing.Point(204, 379);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(220, 51);
            this.Registrar.TabIndex = 14;
            this.Registrar.Text = "Registrar cobertura";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.White;
            this.Aviso.Location = new System.Drawing.Point(182, 73);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(259, 25);
            this.Aviso.TabIndex = 16;
            this.Aviso.Text = "Ingrese los siguientes datos:\r\n";
            // 
            // ComboBoxIDTipo
            // 
            this.ComboBoxIDTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIDTipo.FormattingEnabled = true;
            this.ComboBoxIDTipo.Location = new System.Drawing.Point(287, 216);
            this.ComboBoxIDTipo.Name = "ComboBoxIDTipo";
            this.ComboBoxIDTipo.Size = new System.Drawing.Size(219, 28);
            this.ComboBoxIDTipo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(287, 125);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(219, 26);
            this.TextBoxID.TabIndex = 9;
            this.TextBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // RegistrarCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(606, 467);
            this.Controls.Add(this.ComboBoxIDTipo);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.ComboBoxEst);
            this.Controls.Add(this.TextBoxMon);
            this.Controls.Add(this.TextBoxDesc);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCobertura";
            this.Text = "RegistrarCobertura";
            this.Load += new System.EventHandler(this.RegistrarCobertura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxDesc;
        private System.Windows.Forms.TextBox TextBoxMon;
        private System.Windows.Forms.ComboBox ComboBoxEst;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.ComboBox ComboBoxIDTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxID;
    }
}