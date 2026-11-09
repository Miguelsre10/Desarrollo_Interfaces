namespace EJ_WF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NudCodigoPedido = new System.Windows.Forms.NumericUpDown();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEmpty = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCodigoPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS DE NUESTROS CLIENTES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NudCodigoPedido);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnEmpty);
            this.panel2.Controls.Add(this.BtnShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 481);
            this.panel2.TabIndex = 1;
            // 
            // NudCodigoPedido
            // 
            this.NudCodigoPedido.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudCodigoPedido.Location = new System.Drawing.Point(589, 60);
            this.NudCodigoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.NudCodigoPedido.Name = "NudCodigoPedido";
            this.NudCodigoPedido.Size = new System.Drawing.Size(160, 22);
            this.NudCodigoPedido.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(777, 57);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(165, 28);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Eliminar Pedido";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEmpty
            // 
            this.BtnEmpty.Location = new System.Drawing.Point(233, 58);
            this.BtnEmpty.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmpty.Name = "BtnEmpty";
            this.BtnEmpty.Size = new System.Drawing.Size(148, 28);
            this.BtnEmpty.TabIndex = 1;
            this.BtnEmpty.Text = "Limpiar Pedidos";
            this.BtnEmpty.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(41, 58);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(144, 28);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Mostrar Pedidos";
            this.BtnShow.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 325);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudCodigoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEmpty;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.NumericUpDown NudCodigoPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoDataGridViewTextBoxColumn;
    }
}

