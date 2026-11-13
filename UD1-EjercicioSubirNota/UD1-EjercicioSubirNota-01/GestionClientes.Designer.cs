namespace UD1_EjercicioSubirNota_01
{
    partial class GestionClientes
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
            this.components = new System.ComponentModel.Container();
            this.ClientData = new System.Windows.Forms.GroupBox();
            this.BtnLoadJSON = new System.Windows.Forms.Button();
            this.BtnSaveJSON = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.NudPhone = new System.Windows.Forms.NumericUpDown();
            this.DtpkBirth = new System.Windows.Forms.DateTimePicker();
            this.CBoxCity = new System.Windows.Forms.ComboBox();
            this.TxtbSurname = new System.Windows.Forms.TextBox();
            this.TxtbName = new System.Windows.Forms.TextBox();
            this.TxtbCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientData
            // 
            this.ClientData.Controls.Add(this.BtnLoadJSON);
            this.ClientData.Controls.Add(this.BtnSaveJSON);
            this.ClientData.Controls.Add(this.BtnDelete);
            this.ClientData.Controls.Add(this.BtnAdd);
            this.ClientData.Controls.Add(this.BtnModify);
            this.ClientData.Controls.Add(this.NudPhone);
            this.ClientData.Controls.Add(this.DtpkBirth);
            this.ClientData.Controls.Add(this.CBoxCity);
            this.ClientData.Controls.Add(this.TxtbSurname);
            this.ClientData.Controls.Add(this.TxtbName);
            this.ClientData.Controls.Add(this.TxtbCode);
            this.ClientData.Controls.Add(this.label6);
            this.ClientData.Controls.Add(this.label5);
            this.ClientData.Controls.Add(this.label4);
            this.ClientData.Controls.Add(this.label3);
            this.ClientData.Controls.Add(this.label2);
            this.ClientData.Controls.Add(this.label1);
            this.ClientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ClientData.Location = new System.Drawing.Point(40, 31);
            this.ClientData.Name = "ClientData";
            this.ClientData.Size = new System.Drawing.Size(813, 263);
            this.ClientData.TabIndex = 0;
            this.ClientData.TabStop = false;
            this.ClientData.Text = "Datos de clientes";
            // 
            // BtnLoadJSON
            // 
            this.BtnLoadJSON.Location = new System.Drawing.Point(614, 204);
            this.BtnLoadJSON.Name = "BtnLoadJSON";
            this.BtnLoadJSON.Size = new System.Drawing.Size(155, 29);
            this.BtnLoadJSON.TabIndex = 19;
            this.BtnLoadJSON.Text = "Cargar JSON";
            this.BtnLoadJSON.UseVisualStyleBackColor = true;
            this.BtnLoadJSON.Click += new System.EventHandler(this.BtnLoadJSON_Click);
            // 
            // BtnSaveJSON
            // 
            this.BtnSaveJSON.Location = new System.Drawing.Point(614, 162);
            this.BtnSaveJSON.Name = "BtnSaveJSON";
            this.BtnSaveJSON.Size = new System.Drawing.Size(155, 32);
            this.BtnSaveJSON.TabIndex = 18;
            this.BtnSaveJSON.Text = "Guardar JSON";
            this.BtnSaveJSON.UseVisualStyleBackColor = true;
            this.BtnSaveJSON.Click += new System.EventHandler(this.BtnSaveJSON_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(614, 108);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(155, 33);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(614, 27);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(155, 34);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(614, 69);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(155, 33);
            this.BtnModify.TabIndex = 16;
            this.BtnModify.Text = "Modificar";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // NudPhone
            // 
            this.NudPhone.Location = new System.Drawing.Point(128, 209);
            this.NudPhone.Name = "NudPhone";
            this.NudPhone.Size = new System.Drawing.Size(448, 24);
            this.NudPhone.TabIndex = 14;
            // 
            // DtpkBirth
            // 
            this.DtpkBirth.Location = new System.Drawing.Point(128, 138);
            this.DtpkBirth.Name = "DtpkBirth";
            this.DtpkBirth.Size = new System.Drawing.Size(448, 24);
            this.DtpkBirth.TabIndex = 13;
            // 
            // CBoxCity
            // 
            this.CBoxCity.FormattingEnabled = true;
            this.CBoxCity.Location = new System.Drawing.Point(128, 173);
            this.CBoxCity.Name = "CBoxCity";
            this.CBoxCity.Size = new System.Drawing.Size(448, 26);
            this.CBoxCity.TabIndex = 12;
            // 
            // TxtbSurname
            // 
            this.TxtbSurname.Location = new System.Drawing.Point(128, 104);
            this.TxtbSurname.Name = "TxtbSurname";
            this.TxtbSurname.Size = new System.Drawing.Size(448, 24);
            this.TxtbSurname.TabIndex = 8;
            // 
            // TxtbName
            // 
            this.TxtbName.Location = new System.Drawing.Point(128, 65);
            this.TxtbName.Name = "TxtbName";
            this.TxtbName.Size = new System.Drawing.Size(448, 24);
            this.TxtbName.TabIndex = 7;
            // 
            // TxtbCode
            // 
            this.TxtbCode.Location = new System.Drawing.Point(128, 31);
            this.TxtbCode.Name = "TxtbCode";
            this.TxtbCode.Size = new System.Drawing.Size(448, 24);
            this.TxtbCode.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nac:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(32, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 46);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lista de Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoCliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreCliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ApellidoCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "ApellidoCliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaNacimientoCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaNacimientoCliente";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(UD1_EjercicioSubirNota_01.Cliente);
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClientData);
            this.Name = "GestionClientes";
            this.Text = "Gestion Clientes Gimnasio";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.ClientData.ResumeLayout(false);
            this.ClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudPhone;
        private System.Windows.Forms.DateTimePicker DtpkBirth;
        private System.Windows.Forms.ComboBox CBoxCity;
        private System.Windows.Forms.TextBox TxtbSurname;
        private System.Windows.Forms.TextBox TxtbName;
        private System.Windows.Forms.TextBox TxtbCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLoadJSON;
        private System.Windows.Forms.Button BtnSaveJSON;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}