namespace WindowsFormsApp1
{
    partial class RegistrarCliente
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
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimeNacim = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxApUno = new System.Windows.Forms.TextBox();
            this.TextBoxApDos = new System.Windows.Forms.TextBox();
            this.ComboBoxGen = new System.Windows.Forms.ComboBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.Aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identificación:";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(317, 130);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(231, 26);
            this.TextBoxID.TabIndex = 4;
            this.TextBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primer apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Segundo apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Género:";
            // 
            // DateTimeNacim
            // 
            this.DateTimeNacim.Location = new System.Drawing.Point(317, 300);
            this.DateTimeNacim.Name = "DateTimeNacim";
            this.DateTimeNacim.Size = new System.Drawing.Size(231, 26);
            this.DateTimeNacim.TabIndex = 10;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Location = new System.Drawing.Point(317, 173);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(231, 26);
            this.TextBoxNom.TabIndex = 11;
            // 
            // TextBoxApUno
            // 
            this.TextBoxApUno.Location = new System.Drawing.Point(317, 216);
            this.TextBoxApUno.Name = "TextBoxApUno";
            this.TextBoxApUno.Size = new System.Drawing.Size(231, 26);
            this.TextBoxApUno.TabIndex = 12;
            // 
            // TextBoxApDos
            // 
            this.TextBoxApDos.Location = new System.Drawing.Point(317, 258);
            this.TextBoxApDos.Name = "TextBoxApDos";
            this.TextBoxApDos.Size = new System.Drawing.Size(231, 26);
            this.TextBoxApDos.TabIndex = 13;
            // 
            // ComboBoxGen
            // 
            this.ComboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGen.FormattingEnabled = true;
            this.ComboBoxGen.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.ComboBoxGen.Location = new System.Drawing.Point(317, 343);
            this.ComboBoxGen.Name = "ComboBoxGen";
            this.ComboBoxGen.Size = new System.Drawing.Size(231, 28);
            this.ComboBoxGen.TabIndex = 14;
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registrar.Location = new System.Drawing.Point(214, 404);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(217, 51);
            this.Registrar.TabIndex = 15;
            this.Registrar.Text = "Registrar cliente";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.White;
            this.Aviso.Location = new System.Drawing.Point(205, 71);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(259, 25);
            this.Aviso.TabIndex = 16;
            this.Aviso.Text = "Ingrese los siguientes datos:\r\n";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(637, 485);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.ComboBoxGen);
            this.Controls.Add(this.TextBoxApDos);
            this.Controls.Add(this.TextBoxApUno);
            this.Controls.Add(this.TextBoxNom);
            this.Controls.Add(this.DateTimeNacim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCliente";
            this.Text = "RegistrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimeNacim;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.TextBox TextBoxApUno;
        private System.Windows.Forms.TextBox TextBoxApDos;
        private System.Windows.Forms.ComboBox ComboBoxGen;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label Aviso;
    }
}