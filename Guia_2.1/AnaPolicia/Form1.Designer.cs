namespace AnaPolicia.Guia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarIncidente = new System.Windows.Forms.Button();
            this.btnCrearComisaria = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNumPlaca = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxMotivo = new System.Windows.Forms.TextBox();
            this.tbxDniSujeto = new System.Windows.Forms.TextBox();
            this.tbxSujeto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nupdMinuto = new System.Windows.Forms.NumericUpDown();
            this.nupdHora = new System.Windows.Forms.NumericUpDown();
            this.cbxTipoIncidente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAsignacionGuardias = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nupdDuracionM = new System.Windows.Forms.NumericUpDown();
            this.nupdMinutoDesde = new System.Windows.Forms.NumericUpDown();
            this.nupdHoraDesde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupdNumGuardia = new System.Windows.Forms.NumericUpDown();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistrarInci = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdHora)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDuracionM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMinutoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdHoraDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdNumGuardia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarIncidente);
            this.groupBox1.Controls.Add(this.btnCrearComisaria);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion Comisaria";
            // 
            // btnListarIncidente
            // 
            this.btnListarIncidente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnListarIncidente.Location = new System.Drawing.Point(524, 10);
            this.btnListarIncidente.Name = "btnListarIncidente";
            this.btnListarIncidente.Size = new System.Drawing.Size(104, 39);
            this.btnListarIncidente.TabIndex = 1;
            this.btnListarIncidente.Text = "Listar Incidentes";
            this.btnListarIncidente.UseVisualStyleBackColor = true;
            this.btnListarIncidente.Click += new System.EventHandler(this.btnListarIncidente_Click);
            // 
            // btnCrearComisaria
            // 
            this.btnCrearComisaria.Location = new System.Drawing.Point(414, 10);
            this.btnCrearComisaria.Name = "btnCrearComisaria";
            this.btnCrearComisaria.Size = new System.Drawing.Size(104, 39);
            this.btnCrearComisaria.TabIndex = 0;
            this.btnCrearComisaria.Text = "Creacion Comisaria";
            this.btnCrearComisaria.UseVisualStyleBackColor = true;
            this.btnCrearComisaria.Click += new System.EventHandler(this.btnCrearComisaria_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxNumPlaca);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones sobre el agente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de placa";
            // 
            // cbxNumPlaca
            // 
            this.cbxNumPlaca.FormattingEnabled = true;
            this.cbxNumPlaca.Location = new System.Drawing.Point(127, 19);
            this.cbxNumPlaca.Name = "cbxNumPlaca";
            this.cbxNumPlaca.Size = new System.Drawing.Size(121, 21);
            this.cbxNumPlaca.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRegistrarInci);
            this.groupBox4.Controls.Add(this.tbxMotivo);
            this.groupBox4.Controls.Add(this.tbxDniSujeto);
            this.groupBox4.Controls.Add(this.tbxSujeto);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nupdMinuto);
            this.groupBox4.Controls.Add(this.nupdHora);
            this.groupBox4.Controls.Add(this.cbxTipoIncidente);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 227);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administracion de incidente";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tbxMotivo
            // 
            this.tbxMotivo.Location = new System.Drawing.Point(121, 153);
            this.tbxMotivo.Multiline = true;
            this.tbxMotivo.Name = "tbxMotivo";
            this.tbxMotivo.Size = new System.Drawing.Size(254, 62);
            this.tbxMotivo.TabIndex = 20;
            // 
            // tbxDniSujeto
            // 
            this.tbxDniSujeto.Location = new System.Drawing.Point(275, 115);
            this.tbxDniSujeto.Name = "tbxDniSujeto";
            this.tbxDniSujeto.Size = new System.Drawing.Size(100, 20);
            this.tbxDniSujeto.TabIndex = 19;
            // 
            // tbxSujeto
            // 
            this.tbxSujeto.Location = new System.Drawing.Point(121, 115);
            this.tbxSujeto.Name = "tbxSujeto";
            this.tbxSujeto.Size = new System.Drawing.Size(120, 20);
            this.tbxSujeto.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "DNI:";
            // 
            // nupdMinuto
            // 
            this.nupdMinuto.Location = new System.Drawing.Point(185, 78);
            this.nupdMinuto.Name = "nupdMinuto";
            this.nupdMinuto.Size = new System.Drawing.Size(57, 20);
            this.nupdMinuto.TabIndex = 16;
            // 
            // nupdHora
            // 
            this.nupdHora.Location = new System.Drawing.Point(121, 78);
            this.nupdHora.Name = "nupdHora";
            this.nupdHora.Size = new System.Drawing.Size(57, 20);
            this.nupdHora.TabIndex = 12;
            // 
            // cbxTipoIncidente
            // 
            this.cbxTipoIncidente.FormattingEnabled = true;
            this.cbxTipoIncidente.Items.AddRange(new object[] {
            "Arresto",
            "Denuncia"});
            this.cbxTipoIncidente.Location = new System.Drawing.Point(122, 38);
            this.cbxTipoIncidente.Name = "cbxTipoIncidente";
            this.cbxTipoIncidente.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoIncidente.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Motivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Persona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de incidente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAsignacionGuardias);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nupdDuracionM);
            this.groupBox3.Controls.Add(this.nupdMinutoDesde);
            this.groupBox3.Controls.Add(this.nupdHoraDesde);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nupdNumGuardia);
            this.groupBox3.Location = new System.Drawing.Point(6, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 99);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administracion de guardias";
            // 
            // btnAsignacionGuardias
            // 
            this.btnAsignacionGuardias.Location = new System.Drawing.Point(512, 31);
            this.btnAsignacionGuardias.Name = "btnAsignacionGuardias";
            this.btnAsignacionGuardias.Size = new System.Drawing.Size(104, 39);
            this.btnAsignacionGuardias.TabIndex = 2;
            this.btnAsignacionGuardias.Text = "Asignacion de guardias";
            this.btnAsignacionGuardias.UseVisualStyleBackColor = true;
            this.btnAsignacionGuardias.Click += new System.EventHandler(this.btnAsignacionGuardias_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Duracion en M";
            // 
            // nupdDuracionM
            // 
            this.nupdDuracionM.Location = new System.Drawing.Point(121, 68);
            this.nupdDuracionM.Name = "nupdDuracionM";
            this.nupdDuracionM.Size = new System.Drawing.Size(120, 20);
            this.nupdDuracionM.TabIndex = 10;
            // 
            // nupdMinutoDesde
            // 
            this.nupdMinutoDesde.Location = new System.Drawing.Point(184, 42);
            this.nupdMinutoDesde.Name = "nupdMinutoDesde";
            this.nupdMinutoDesde.Size = new System.Drawing.Size(57, 20);
            this.nupdMinutoDesde.TabIndex = 9;
            // 
            // nupdHoraDesde
            // 
            this.nupdHoraDesde.Location = new System.Drawing.Point(121, 42);
            this.nupdHoraDesde.Name = "nupdHoraDesde";
            this.nupdHoraDesde.Size = new System.Drawing.Size(57, 20);
            this.nupdHoraDesde.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de guardia";
            // 
            // nupdNumGuardia
            // 
            this.nupdNumGuardia.Location = new System.Drawing.Point(122, 19);
            this.nupdNumGuardia.Name = "nupdNumGuardia";
            this.nupdNumGuardia.Size = new System.Drawing.Size(120, 20);
            this.nupdNumGuardia.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(251, 468);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 24);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarInci
            // 
            this.btnRegistrarInci.Location = new System.Drawing.Point(518, 118);
            this.btnRegistrarInci.Name = "btnRegistrarInci";
            this.btnRegistrarInci.Size = new System.Drawing.Size(98, 37);
            this.btnRegistrarInci.TabIndex = 21;
            this.btnRegistrarInci.Text = "Registrar incidente";
            this.btnRegistrarInci.UseVisualStyleBackColor = true;
            this.btnRegistrarInci.Click += new System.EventHandler(this.btnRegistrarInci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 504);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdHora)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDuracionM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMinutoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdHoraDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdNumGuardia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearComisaria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnListarIncidente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNumPlaca;
        private System.Windows.Forms.NumericUpDown nupdDuracionM;
        private System.Windows.Forms.NumericUpDown nupdMinutoDesde;
        private System.Windows.Forms.NumericUpDown nupdHoraDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupdNumGuardia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupdMinuto;
        private System.Windows.Forms.NumericUpDown nupdHora;
        private System.Windows.Forms.ComboBox cbxTipoIncidente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsignacionGuardias;
        private System.Windows.Forms.TextBox tbxDniSujeto;
        private System.Windows.Forms.TextBox tbxSujeto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMotivo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrarInci;
    }
}

