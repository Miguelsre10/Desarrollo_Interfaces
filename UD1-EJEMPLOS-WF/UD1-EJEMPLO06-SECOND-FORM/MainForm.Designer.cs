namespace UD1_EJEMPLO06_SECOND_FORM
{
    partial class MainForm
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
            this.GboxF = new System.Windows.Forms.GroupBox();
            this.RbFamily = new System.Windows.Forms.RadioButton();
            this.RbTeachers = new System.Windows.Forms.RadioButton();
            this.RbStudent = new System.Windows.Forms.RadioButton();
            this.BtnNewForm = new System.Windows.Forms.Button();
            this.GboxF.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejemplo de varios formularios";
            // 
            // GboxF
            // 
            this.GboxF.Controls.Add(this.RbFamily);
            this.GboxF.Controls.Add(this.RbTeachers);
            this.GboxF.Controls.Add(this.RbStudent);
            this.GboxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GboxF.Location = new System.Drawing.Point(54, 110);
            this.GboxF.Name = "GboxF";
            this.GboxF.Size = new System.Drawing.Size(246, 145);
            this.GboxF.TabIndex = 1;
            this.GboxF.TabStop = false;
            this.GboxF.Text = "Varios formularios";
            // 
            // RbFamily
            // 
            this.RbFamily.AutoSize = true;
            this.RbFamily.Location = new System.Drawing.Point(6, 100);
            this.RbFamily.Name = "RbFamily";
            this.RbFamily.Size = new System.Drawing.Size(94, 24);
            this.RbFamily.TabIndex = 2;
            this.RbFamily.TabStop = true;
            this.RbFamily.Text = "FAMILIA";
            this.RbFamily.UseVisualStyleBackColor = true;
            // 
            // RbTeachers
            // 
            this.RbTeachers.AutoSize = true;
            this.RbTeachers.Location = new System.Drawing.Point(6, 70);
            this.RbTeachers.Name = "RbTeachers";
            this.RbTeachers.Size = new System.Drawing.Size(160, 24);
            this.RbTeachers.TabIndex = 1;
            this.RbTeachers.TabStop = true;
            this.RbTeachers.Text = "PROFESORADO";
            this.RbTeachers.UseVisualStyleBackColor = true;
            this.RbTeachers.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RbStudent
            // 
            this.RbStudent.AutoSize = true;
            this.RbStudent.Location = new System.Drawing.Point(7, 40);
            this.RbStudent.Name = "RbStudent";
            this.RbStudent.Size = new System.Drawing.Size(126, 24);
            this.RbStudent.TabIndex = 0;
            this.RbStudent.TabStop = true;
            this.RbStudent.Text = "ALUMNADO";
            this.RbStudent.UseVisualStyleBackColor = true;
            // 
            // BtnNewForm
            // 
            this.BtnNewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnNewForm.Location = new System.Drawing.Point(335, 137);
            this.BtnNewForm.Name = "BtnNewForm";
            this.BtnNewForm.Size = new System.Drawing.Size(191, 97);
            this.BtnNewForm.TabIndex = 2;
            this.BtnNewForm.Text = "Crear Nueva Ventana";
            this.BtnNewForm.UseVisualStyleBackColor = true;
            this.BtnNewForm.Click += new System.EventHandler(this.BtnNewForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 396);
            this.Controls.Add(this.BtnNewForm);
            this.Controls.Add(this.GboxF);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Ejemplo final del tema 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GboxF.ResumeLayout(false);
            this.GboxF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GboxF;
        private System.Windows.Forms.RadioButton RbFamily;
        private System.Windows.Forms.RadioButton RbTeachers;
        private System.Windows.Forms.RadioButton RbStudent;
        private System.Windows.Forms.Button BtnNewForm;
    }
}

