namespace UD1_EjercicioSubirNota_01
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
            this.LlbClients = new System.Windows.Forms.LinkLabel();
            this.LlbAct = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(110, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gimnasio Olimpia";
            // 
            // LlbClients
            // 
            this.LlbClients.AutoSize = true;
            this.LlbClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LlbClients.Location = new System.Drawing.Point(150, 128);
            this.LlbClients.Name = "LlbClients";
            this.LlbClients.Size = new System.Drawing.Size(190, 18);
            this.LlbClients.TabIndex = 1;
            this.LlbClients.TabStop = true;
            this.LlbClients.Text = "CLIENTES DEL GIMNASIO";
            // 
            // LlbAct
            // 
            this.LlbAct.AutoSize = true;
            this.LlbAct.Location = new System.Drawing.Point(150, 167);
            this.LlbAct.Name = "LlbAct";
            this.LlbAct.Size = new System.Drawing.Size(186, 16);
            this.LlbAct.TabIndex = 2;
            this.LlbAct.TabStop = true;
            this.LlbAct.Text = "ACTIVIDADES DEPORTIVAS";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(150, 206);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(156, 16);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "RESERVAR ACTIVIDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.LlbAct);
            this.Controls.Add(this.LlbClients);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LlbClients;
        private System.Windows.Forms.LinkLabel LlbAct;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

