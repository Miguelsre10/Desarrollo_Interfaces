namespace UD1_EJ_WF_01
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
            this.panelJ1 = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NudJ1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelJ2 = new System.Windows.Forms.Panel();
            this.LblIntentos = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.BtnAdivinar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudAdiv = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelJ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudJ1)).BeginInit();
            this.panelJ2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdiv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJ1
            // 
            this.panelJ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelJ1.Controls.Add(this.BtnStart);
            this.panelJ1.Controls.Add(this.label5);
            this.panelJ1.Controls.Add(this.NudJ1);
            this.panelJ1.Controls.Add(this.label1);
            this.panelJ1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJ1.Location = new System.Drawing.Point(0, 0);
            this.panelJ1.Name = "panelJ1";
            this.panelJ1.Size = new System.Drawing.Size(507, 165);
            this.panelJ1.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(54, 95);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(112, 31);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Iniciar Juego";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero Secreto 0 - 100";
            // 
            // NudJ1
            // 
            this.NudJ1.Location = new System.Drawing.Point(211, 64);
            this.NudJ1.Name = "NudJ1";
            this.NudJ1.Size = new System.Drawing.Size(232, 22);
            this.NudJ1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador 1";
            // 
            // panelJ2
            // 
            this.panelJ2.Controls.Add(this.LblIntentos);
            this.panelJ2.Controls.Add(this.LblFin);
            this.panelJ2.Controls.Add(this.BtnAdivinar);
            this.panelJ2.Controls.Add(this.label6);
            this.panelJ2.Controls.Add(this.label4);
            this.panelJ2.Controls.Add(this.NudAdiv);
            this.panelJ2.Controls.Add(this.label3);
            this.panelJ2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJ2.Location = new System.Drawing.Point(0, 165);
            this.panelJ2.Name = "panelJ2";
            this.panelJ2.Size = new System.Drawing.Size(507, 215);
            this.panelJ2.TabIndex = 2;
            this.panelJ2.Visible = false;
            // 
            // LblIntentos
            // 
            this.LblIntentos.AutoSize = true;
            this.LblIntentos.Location = new System.Drawing.Point(254, 71);
            this.LblIntentos.Name = "LblIntentos";
            this.LblIntentos.Size = new System.Drawing.Size(14, 16);
            this.LblIntentos.TabIndex = 6;
            this.LblIntentos.Text = "5";
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblFin.Location = new System.Drawing.Point(75, 162);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(0, 25);
            this.LblFin.TabIndex = 5;
            // 
            // BtnAdivinar
            // 
            this.BtnAdivinar.Location = new System.Drawing.Point(368, 103);
            this.BtnAdivinar.Name = "BtnAdivinar";
            this.BtnAdivinar.Size = new System.Drawing.Size(75, 30);
            this.BtnAdivinar.TabIndex = 4;
            this.BtnAdivinar.Text = "Adivinar";
            this.BtnAdivinar.UseVisualStyleBackColor = true;
            this.BtnAdivinar.Click += new System.EventHandler(this.BtnAdivinar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Numero de intentos restantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Escribe numero secreto";
            // 
            // NudAdiv
            // 
            this.NudAdiv.Location = new System.Drawing.Point(211, 108);
            this.NudAdiv.Name = "NudAdiv";
            this.NudAdiv.Size = new System.Drawing.Size(135, 22);
            this.NudAdiv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(46, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jugador 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 380);
            this.Controls.Add(this.panelJ2);
            this.Controls.Add(this.panelJ1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelJ1.ResumeLayout(false);
            this.panelJ1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudJ1)).EndInit();
            this.panelJ2.ResumeLayout(false);
            this.panelJ2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudJ1;
        private System.Windows.Forms.Panel panelJ2;
        private System.Windows.Forms.NumericUpDown NudAdiv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnAdivinar;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblIntentos;
    }
}

