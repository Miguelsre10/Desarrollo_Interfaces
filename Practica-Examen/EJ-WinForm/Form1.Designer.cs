namespace EJ_WinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Distancia = new System.Windows.Forms.GroupBox();
            this.RBtnDistanciaMM = new System.Windows.Forms.RadioButton();
            this.RBtnDistancia10 = new System.Windows.Forms.RadioButton();
            this.RBtnDistancia5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CBTallas = new System.Windows.Forms.ComboBox();
            this.ChkSocio = new System.Windows.Forms.CheckBox();
            this.BtnResumen = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.NubEdad = new System.Windows.Forms.NumericUpDown();
            this.Distancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NubEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARRRERA POPULAR DE LUCENA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 120);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(207, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // Distancia
            // 
            this.Distancia.Controls.Add(this.RBtnDistanciaMM);
            this.Distancia.Controls.Add(this.RBtnDistancia10);
            this.Distancia.Controls.Add(this.RBtnDistancia5);
            this.Distancia.Location = new System.Drawing.Point(56, 187);
            this.Distancia.Name = "Distancia";
            this.Distancia.Size = new System.Drawing.Size(400, 72);
            this.Distancia.TabIndex = 5;
            this.Distancia.TabStop = false;
            this.Distancia.Text = "groupBox1";
            // 
            // RBtnDistanciaMM
            // 
            this.RBtnDistanciaMM.AutoSize = true;
            this.RBtnDistanciaMM.Location = new System.Drawing.Point(227, 33);
            this.RBtnDistanciaMM.Name = "RBtnDistanciaMM";
            this.RBtnDistanciaMM.Size = new System.Drawing.Size(124, 17);
            this.RBtnDistanciaMM.TabIndex = 2;
            this.RBtnDistanciaMM.TabStop = true;
            this.RBtnDistanciaMM.Text = "Meida MAraton (18€)";
            this.RBtnDistanciaMM.UseVisualStyleBackColor = true;
            // 
            // RBtnDistancia10
            // 
            this.RBtnDistancia10.AutoSize = true;
            this.RBtnDistancia10.Location = new System.Drawing.Point(109, 33);
            this.RBtnDistancia10.Name = "RBtnDistancia10";
            this.RBtnDistancia10.Size = new System.Drawing.Size(82, 17);
            this.RBtnDistancia10.TabIndex = 1;
            this.RBtnDistancia10.TabStop = true;
            this.RBtnDistancia10.Text = "10 Km (12€)";
            this.RBtnDistancia10.UseVisualStyleBackColor = true;
            // 
            // RBtnDistancia5
            // 
            this.RBtnDistancia5.AutoSize = true;
            this.RBtnDistancia5.Location = new System.Drawing.Point(7, 33);
            this.RBtnDistancia5.Name = "RBtnDistancia5";
            this.RBtnDistancia5.Size = new System.Drawing.Size(70, 17);
            this.RBtnDistancia5.TabIndex = 0;
            this.RBtnDistancia5.TabStop = true;
            this.RBtnDistancia5.Text = "5 Km (8€)";
            this.RBtnDistancia5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Talla Camiseta";
            // 
            // CBTallas
            // 
            this.CBTallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTallas.FormattingEnabled = true;
            this.CBTallas.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.CBTallas.Location = new System.Drawing.Point(151, 277);
            this.CBTallas.Name = "CBTallas";
            this.CBTallas.Size = new System.Drawing.Size(200, 21);
            this.CBTallas.TabIndex = 7;
            // 
            // ChkSocio
            // 
            this.ChkSocio.AutoSize = true;
            this.ChkSocio.Location = new System.Drawing.Point(59, 312);
            this.ChkSocio.Name = "ChkSocio";
            this.ChkSocio.Size = new System.Drawing.Size(176, 17);
            this.ChkSocio.TabIndex = 8;
            this.ChkSocio.Text = "Socio del club de atletismo (-3€)";
            this.ChkSocio.UseVisualStyleBackColor = true;
            // 
            // BtnResumen
            // 
            this.BtnResumen.Location = new System.Drawing.Point(63, 350);
            this.BtnResumen.Name = "BtnResumen";
            this.BtnResumen.Size = new System.Drawing.Size(184, 67);
            this.BtnResumen.TabIndex = 9;
            this.BtnResumen.Text = "Ver Resumen";
            this.BtnResumen.UseVisualStyleBackColor = true;
            this.BtnResumen.Click += new System.EventHandler(this.BtnResumen_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(300, 350);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(184, 67);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar Inscripcion";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // NubEdad
            // 
            this.NubEdad.Location = new System.Drawing.Point(165, 153);
            this.NubEdad.Name = "NubEdad";
            this.NubEdad.Size = new System.Drawing.Size(120, 20);
            this.NubEdad.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.NubEdad);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnResumen);
            this.Controls.Add(this.ChkSocio);
            this.Controls.Add(this.CBTallas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Distancia);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Distancia.ResumeLayout(false);
            this.Distancia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NubEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox Distancia;
        private System.Windows.Forms.RadioButton RBtnDistanciaMM;
        private System.Windows.Forms.RadioButton RBtnDistancia10;
        private System.Windows.Forms.RadioButton RBtnDistancia5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBTallas;
        private System.Windows.Forms.CheckBox ChkSocio;
        private System.Windows.Forms.Button BtnResumen;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.NumericUpDown NubEdad;
    }
}

