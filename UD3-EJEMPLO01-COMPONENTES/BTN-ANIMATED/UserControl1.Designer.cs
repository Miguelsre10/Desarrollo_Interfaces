namespace BTN_ANIMATED
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAnimated = new System.Windows.Forms.Button();
            this.LbAnimated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAnimated
            // 
            this.BtnAnimated.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnAnimated.Location = new System.Drawing.Point(10, 10);
            this.BtnAnimated.Name = "BtnAnimated";
            this.BtnAnimated.Size = new System.Drawing.Size(150, 46);
            this.BtnAnimated.TabIndex = 0;
            this.BtnAnimated.Text = "ENVIAR DATOS";
            this.BtnAnimated.UseVisualStyleBackColor = true;
            this.BtnAnimated.Click += new System.EventHandler(this.BtnAnimated_Click);
            this.BtnAnimated.MouseLeave += new System.EventHandler(this.BtnAnimated_MouseLeave);
            this.BtnAnimated.MouseHover += new System.EventHandler(this.BtnAnimated_MouseHover);
            // 
            // LbAnimated
            // 
            this.LbAnimated.AutoSize = true;
            this.LbAnimated.Location = new System.Drawing.Point(10, 59);
            this.LbAnimated.Name = "LbAnimated";
            this.LbAnimated.Size = new System.Drawing.Size(0, 16);
            this.LbAnimated.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbAnimated);
            this.Controls.Add(this.BtnAnimated);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(170, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnimated;
        private System.Windows.Forms.Label LbAnimated;
    }
}
