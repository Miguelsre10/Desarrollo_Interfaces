namespace UD1_PRACTICA_EXAMEN
{
    partial class Resumen
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.Label();
            this.TxtSocio = new System.Windows.Forms.Label();
            this.TxtTalla = new System.Windows.Forms.Label();
            this.TxtDistancia = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.Label();
            this.TxtCorredor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumen de la aplicacion";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(50, 370);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(151, 50);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.AutoSize = true;
            this.TxtPrecio.Location = new System.Drawing.Point(47, 307);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(49, 16);
            this.TxtPrecio.TabIndex = 16;
            this.TxtPrecio.Text = "Precio:";
            // 
            // TxtSocio
            // 
            this.TxtSocio.AutoSize = true;
            this.TxtSocio.Location = new System.Drawing.Point(47, 271);
            this.TxtSocio.Name = "TxtSocio";
            this.TxtSocio.Size = new System.Drawing.Size(95, 16);
            this.TxtSocio.TabIndex = 15;
            this.TxtSocio.Text = "Socio del club:";
            // 
            // TxtTalla
            // 
            this.TxtTalla.AutoSize = true;
            this.TxtTalla.Location = new System.Drawing.Point(47, 237);
            this.TxtTalla.Name = "TxtTalla";
            this.TxtTalla.Size = new System.Drawing.Size(118, 16);
            this.TxtTalla.TabIndex = 14;
            this.TxtTalla.Text = "Talla de camiseta:";
            // 
            // TxtDistancia
            // 
            this.TxtDistancia.AutoSize = true;
            this.TxtDistancia.Location = new System.Drawing.Point(47, 202);
            this.TxtDistancia.Name = "TxtDistancia";
            this.TxtDistancia.Size = new System.Drawing.Size(66, 16);
            this.TxtDistancia.TabIndex = 13;
            this.TxtDistancia.Text = "Distancia:";
            // 
            // TxtEdad
            // 
            this.TxtEdad.AutoSize = true;
            this.TxtEdad.Location = new System.Drawing.Point(47, 168);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(43, 16);
            this.TxtEdad.TabIndex = 12;
            this.TxtEdad.Text = "Edad:";
            // 
            // TxtCorredor
            // 
            this.TxtCorredor.AutoSize = true;
            this.TxtCorredor.Location = new System.Drawing.Point(47, 134);
            this.TxtCorredor.Name = "TxtCorredor";
            this.TxtCorredor.Size = new System.Drawing.Size(63, 16);
            this.TxtCorredor.TabIndex = 11;
            this.TxtCorredor.Text = "Corredor:";
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 441);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtSocio);
            this.Controls.Add(this.TxtTalla);
            this.Controls.Add(this.TxtDistancia);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtCorredor);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Resumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.Resumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label TxtPrecio;
        private System.Windows.Forms.Label TxtSocio;
        private System.Windows.Forms.Label TxtTalla;
        private System.Windows.Forms.Label TxtDistancia;
        private System.Windows.Forms.Label TxtEdad;
        private System.Windows.Forms.Label TxtCorredor;
    }
}