namespace UD1_EJEMPLO02_QUIZ
{
    partial class Quiz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblHoras = new System.Windows.Forms.Label();
            this.NudHours = new System.Windows.Forms.NumericUpDown();
            this.BtnInforme = new System.Windows.Forms.Button();
            this.GbxOS = new System.Windows.Forms.GroupBox();
            this.GbxEspecialidad = new System.Windows.Forms.GroupBox();
            this.RbtnWin = new System.Windows.Forms.RadioButton();
            this.RbtnLinux = new System.Windows.Forms.RadioButton();
            this.RbtnMacos = new System.Windows.Forms.RadioButton();
            this.ChkbProgram = new System.Windows.Forms.CheckBox();
            this.ChkbDesign = new System.Windows.Forms.CheckBox();
            this.ChkbNetwork = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHours)).BeginInit();
            this.GbxOS.SuspendLayout();
            this.GbxEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 64);
            this.panel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LblTitulo.Location = new System.Drawing.Point(12, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(256, 24);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Mini Encuesta de  informatica";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.BtnInforme);
            this.panel2.Controls.Add(this.NudHours);
            this.panel2.Controls.Add(this.LblHoras);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 104);
            this.panel2.TabIndex = 1;
            // 
            // LblHoras
            // 
            this.LblHoras.AutoSize = true;
            this.LblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblHoras.Location = new System.Drawing.Point(25, 11);
            this.LblHoras.Name = "LblHoras";
            this.LblHoras.Size = new System.Drawing.Size(219, 20);
            this.LblHoras.TabIndex = 0;
            this.LblHoras.Text = "Horas que dedicas al PC";
            // 
            // NudHours
            // 
            this.NudHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NudHours.Location = new System.Drawing.Point(29, 40);
            this.NudHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NudHours.Name = "NudHours";
            this.NudHours.Size = new System.Drawing.Size(215, 23);
            this.NudHours.TabIndex = 1;
            // 
            // BtnInforme
            // 
            this.BtnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BtnInforme.Location = new System.Drawing.Point(29, 69);
            this.BtnInforme.Name = "BtnInforme";
            this.BtnInforme.Size = new System.Drawing.Size(215, 25);
            this.BtnInforme.TabIndex = 2;
            this.BtnInforme.Text = "Generar Informe";
            this.BtnInforme.UseVisualStyleBackColor = true;
            this.BtnInforme.Click += new System.EventHandler(this.BtnInforme_Click);
            // 
            // GbxOS
            // 
            this.GbxOS.Controls.Add(this.RbtnMacos);
            this.GbxOS.Controls.Add(this.RbtnLinux);
            this.GbxOS.Controls.Add(this.RbtnWin);
            this.GbxOS.Location = new System.Drawing.Point(29, 89);
            this.GbxOS.Name = "GbxOS";
            this.GbxOS.Size = new System.Drawing.Size(200, 105);
            this.GbxOS.TabIndex = 2;
            this.GbxOS.TabStop = false;
            this.GbxOS.Text = "Elige sistema operativo";
            this.GbxOS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GbxEspecialidad
            // 
            this.GbxEspecialidad.Controls.Add(this.ChkbNetwork);
            this.GbxEspecialidad.Controls.Add(this.ChkbDesign);
            this.GbxEspecialidad.Controls.Add(this.ChkbProgram);
            this.GbxEspecialidad.Location = new System.Drawing.Point(29, 213);
            this.GbxEspecialidad.Name = "GbxEspecialidad";
            this.GbxEspecialidad.Size = new System.Drawing.Size(200, 108);
            this.GbxEspecialidad.TabIndex = 3;
            this.GbxEspecialidad.TabStop = false;
            this.GbxEspecialidad.Text = "Especialidad";
            this.GbxEspecialidad.Enter += new System.EventHandler(this.GbxEspecialidad_Enter);
            // 
            // RbtnWin
            // 
            this.RbtnWin.AutoSize = true;
            this.RbtnWin.Location = new System.Drawing.Point(7, 22);
            this.RbtnWin.Name = "RbtnWin";
            this.RbtnWin.Size = new System.Drawing.Size(83, 20);
            this.RbtnWin.TabIndex = 0;
            this.RbtnWin.TabStop = true;
            this.RbtnWin.Text = "Windows";
            this.RbtnWin.UseVisualStyleBackColor = true;
            // 
            // RbtnLinux
            // 
            this.RbtnLinux.AutoSize = true;
            this.RbtnLinux.Location = new System.Drawing.Point(7, 49);
            this.RbtnLinux.Name = "RbtnLinux";
            this.RbtnLinux.Size = new System.Drawing.Size(58, 20);
            this.RbtnLinux.TabIndex = 1;
            this.RbtnLinux.TabStop = true;
            this.RbtnLinux.Text = "Linux";
            this.RbtnLinux.UseVisualStyleBackColor = true;
            // 
            // RbtnMacos
            // 
            this.RbtnMacos.AutoSize = true;
            this.RbtnMacos.Location = new System.Drawing.Point(7, 75);
            this.RbtnMacos.Name = "RbtnMacos";
            this.RbtnMacos.Size = new System.Drawing.Size(76, 20);
            this.RbtnMacos.TabIndex = 2;
            this.RbtnMacos.TabStop = true;
            this.RbtnMacos.Text = "Mac OS";
            this.RbtnMacos.UseVisualStyleBackColor = true;
            // 
            // ChkbProgram
            // 
            this.ChkbProgram.AutoSize = true;
            this.ChkbProgram.Location = new System.Drawing.Point(7, 22);
            this.ChkbProgram.Name = "ChkbProgram";
            this.ChkbProgram.Size = new System.Drawing.Size(114, 20);
            this.ChkbProgram.TabIndex = 0;
            this.ChkbProgram.Text = "Programacion";
            this.ChkbProgram.UseVisualStyleBackColor = true;
            // 
            // ChkbDesign
            // 
            this.ChkbDesign.AutoSize = true;
            this.ChkbDesign.Location = new System.Drawing.Point(7, 49);
            this.ChkbDesign.Name = "ChkbDesign";
            this.ChkbDesign.Size = new System.Drawing.Size(116, 20);
            this.ChkbDesign.TabIndex = 1;
            this.ChkbDesign.Text = "Diseño grafico";
            this.ChkbDesign.UseVisualStyleBackColor = true;
            // 
            // ChkbNetwork
            // 
            this.ChkbNetwork.AutoSize = true;
            this.ChkbNetwork.Location = new System.Drawing.Point(7, 76);
            this.ChkbNetwork.Name = "ChkbNetwork";
            this.ChkbNetwork.Size = new System.Drawing.Size(174, 20);
            this.ChkbNetwork.TabIndex = 2;
            this.ChkbNetwork.Text = "Administracion de redes";
            this.ChkbNetwork.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 453);
            this.Controls.Add(this.GbxEspecialidad);
            this.Controls.Add(this.GbxOS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Quiz";
            this.ShowIcon = false;
            this.Text = "Mini Encuesta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHours)).EndInit();
            this.GbxOS.ResumeLayout(false);
            this.GbxOS.PerformLayout();
            this.GbxEspecialidad.ResumeLayout(false);
            this.GbxEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown NudHours;
        private System.Windows.Forms.Label LblHoras;
        private System.Windows.Forms.Button BtnInforme;
        private System.Windows.Forms.GroupBox GbxOS;
        private System.Windows.Forms.GroupBox GbxEspecialidad;
        private System.Windows.Forms.RadioButton RbtnMacos;
        private System.Windows.Forms.RadioButton RbtnLinux;
        private System.Windows.Forms.RadioButton RbtnWin;
        private System.Windows.Forms.CheckBox ChkbNetwork;
        private System.Windows.Forms.CheckBox ChkbDesign;
        private System.Windows.Forms.CheckBox ChkbProgram;
    }
}

