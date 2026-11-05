namespace UD1_PRACTICA_EXAMEN
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
            this.NumEdad = new System.Windows.Forms.NumericUpDown();
            this.GbDistancia = new System.Windows.Forms.GroupBox();
            this.RbtnDistanciaMM = new System.Windows.Forms.RadioButton();
            this.RbtnDistancia10 = new System.Windows.Forms.RadioButton();
            this.RbtnDistancia5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CbTallas = new System.Windows.Forms.ComboBox();
            this.ChkSocio = new System.Windows.Forms.CheckBox();
            this.BtnResumen = new System.Windows.Forms.Button();
            this.BtnInscripcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdad)).BeginInit();
            this.GbDistancia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera Popular de Lucena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(203, 118);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(189, 22);
            this.TxtNombre.TabIndex = 3;
            // 
            // NumEdad
            // 
            this.NumEdad.Location = new System.Drawing.Point(203, 163);
            this.NumEdad.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.NumEdad.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.NumEdad.Name = "NumEdad";
            this.NumEdad.Size = new System.Drawing.Size(120, 22);
            this.NumEdad.TabIndex = 4;
            this.NumEdad.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // GbDistancia
            // 
            this.GbDistancia.Controls.Add(this.RbtnDistanciaMM);
            this.GbDistancia.Controls.Add(this.RbtnDistancia10);
            this.GbDistancia.Controls.Add(this.RbtnDistancia5);
            this.GbDistancia.Location = new System.Drawing.Point(55, 227);
            this.GbDistancia.Name = "GbDistancia";
            this.GbDistancia.Size = new System.Drawing.Size(471, 64);
            this.GbDistancia.TabIndex = 5;
            this.GbDistancia.TabStop = false;
            this.GbDistancia.Text = "Distancia";
            // 
            // RbtnDistanciaMM
            // 
            this.RbtnDistanciaMM.AutoSize = true;
            this.RbtnDistanciaMM.Location = new System.Drawing.Point(311, 27);
            this.RbtnDistanciaMM.Name = "RbtnDistanciaMM";
            this.RbtnDistanciaMM.Size = new System.Drawing.Size(153, 20);
            this.RbtnDistanciaMM.TabIndex = 2;
            this.RbtnDistanciaMM.TabStop = true;
            this.RbtnDistanciaMM.Text = "Media Maratón (18 €)";
            this.RbtnDistanciaMM.UseVisualStyleBackColor = true;
            // 
            // RbtnDistancia10
            // 
            this.RbtnDistancia10.AutoSize = true;
            this.RbtnDistancia10.Location = new System.Drawing.Point(166, 26);
            this.RbtnDistancia10.Name = "RbtnDistancia10";
            this.RbtnDistancia10.Size = new System.Drawing.Size(99, 20);
            this.RbtnDistancia10.TabIndex = 1;
            this.RbtnDistancia10.TabStop = true;
            this.RbtnDistancia10.Text = "10 Km (12 €)";
            this.RbtnDistancia10.UseVisualStyleBackColor = true;
            // 
            // RbtnDistancia5
            // 
            this.RbtnDistancia5.AutoSize = true;
            this.RbtnDistancia5.Location = new System.Drawing.Point(18, 27);
            this.RbtnDistancia5.Name = "RbtnDistancia5";
            this.RbtnDistancia5.Size = new System.Drawing.Size(85, 20);
            this.RbtnDistancia5.TabIndex = 0;
            this.RbtnDistancia5.TabStop = true;
            this.RbtnDistancia5.Text = "5 Km (8 €)";
            this.RbtnDistancia5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Talla camiseta:";
            // 
            // CbTallas
            // 
            this.CbTallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTallas.FormattingEnabled = true;
            this.CbTallas.Location = new System.Drawing.Point(191, 322);
            this.CbTallas.Name = "CbTallas";
            this.CbTallas.Size = new System.Drawing.Size(171, 24);
            this.CbTallas.TabIndex = 7;
            // 
            // ChkSocio
            // 
            this.ChkSocio.AutoSize = true;
            this.ChkSocio.Location = new System.Drawing.Point(58, 387);
            this.ChkSocio.Name = "ChkSocio";
            this.ChkSocio.Size = new System.Drawing.Size(203, 20);
            this.ChkSocio.TabIndex = 8;
            this.ChkSocio.Text = "Socio del club atletismo (-3 €)";
            this.ChkSocio.UseVisualStyleBackColor = true;
            // 
            // BtnResumen
            // 
            this.BtnResumen.Location = new System.Drawing.Point(55, 450);
            this.BtnResumen.Name = "BtnResumen";
            this.BtnResumen.Size = new System.Drawing.Size(206, 67);
            this.BtnResumen.TabIndex = 9;
            this.BtnResumen.Text = "Ver resumen";
            this.BtnResumen.UseVisualStyleBackColor = true;
            this.BtnResumen.Click += new System.EventHandler(this.BtnResumen_Click);
            // 
            // BtnInscripcion
            // 
            this.BtnInscripcion.Location = new System.Drawing.Point(289, 450);
            this.BtnInscripcion.Name = "BtnInscripcion";
            this.BtnInscripcion.Size = new System.Drawing.Size(206, 67);
            this.BtnInscripcion.TabIndex = 10;
            this.BtnInscripcion.Text = "Guardar Inscripción";
            this.BtnInscripcion.UseVisualStyleBackColor = true;
            this.BtnInscripcion.Click += new System.EventHandler(this.BtnInscripcion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 582);
            this.Controls.Add(this.BtnInscripcion);
            this.Controls.Add(this.BtnResumen);
            this.Controls.Add(this.ChkSocio);
            this.Controls.Add(this.CbTallas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GbDistancia);
            this.Controls.Add(this.NumEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumEdad)).EndInit();
            this.GbDistancia.ResumeLayout(false);
            this.GbDistancia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.NumericUpDown NumEdad;
        private System.Windows.Forms.GroupBox GbDistancia;
        private System.Windows.Forms.RadioButton RbtnDistancia10;
        private System.Windows.Forms.RadioButton RbtnDistancia5;
        private System.Windows.Forms.RadioButton RbtnDistanciaMM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbTallas;
        private System.Windows.Forms.CheckBox ChkSocio;
        private System.Windows.Forms.Button BtnResumen;
        private System.Windows.Forms.Button BtnInscripcion;
    }
}

