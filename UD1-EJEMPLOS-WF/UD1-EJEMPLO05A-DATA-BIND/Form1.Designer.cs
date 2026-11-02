namespace UD1_EJEMPLO05A_DATA_BIND
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvCities = new System.Windows.Forms.DataGridView();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejmplos de Enalce de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(109, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudades";
            // 
            // CbCity
            // 
            this.CbCity.FormattingEnabled = true;
            this.CbCity.Location = new System.Drawing.Point(195, 129);
            this.CbCity.Name = "CbCity";
            this.CbCity.Size = new System.Drawing.Size(305, 24);
            this.CbCity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(53, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciudades";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(UD1_EJEMPLO05A_DATA_BIND.City);
            // 
            // DgvCities
            // 
            this.DgvCities.AutoGenerateColumns = false;
            this.DgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityNameDataGridViewTextBoxColumn,
            this.populationNameDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn});
            this.DgvCities.DataSource = this.cityBindingSource;
            this.DgvCities.Location = new System.Drawing.Point(138, 196);
            this.DgvCities.Name = "DgvCities";
            this.DgvCities.RowHeadersWidth = 51;
            this.DgvCities.RowTemplate.Height = 24;
            this.DgvCities.Size = new System.Drawing.Size(634, 200);
            this.DgvCities.TabIndex = 4;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
            this.cityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationNameDataGridViewTextBoxColumn
            // 
            this.populationNameDataGridViewTextBoxColumn.DataPropertyName = "PopulationName";
            this.populationNameDataGridViewTextBoxColumn.HeaderText = "PopulationName";
            this.populationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationNameDataGridViewTextBoxColumn.Name = "populationNameDataGridViewTextBoxColumn";
            this.populationNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(195, 416);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(115, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Añadir Lucena";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(464, 415);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(143, 23);
            this.BtnDel.TabIndex = 6;
            this.BtnDel.Text = "Eliminar Sevilla";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvCities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DataBinding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridView DgvCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
    }
}

