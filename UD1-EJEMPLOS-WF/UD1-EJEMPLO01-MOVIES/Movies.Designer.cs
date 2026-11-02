namespace UD1_EJEMPLO01_MOVIES
{
    partial class Movies
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblPelicula = new System.Windows.Forms.Label();
            this.CbMovies = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtMovie = new System.Windows.Forms.TextBox();
            this.LblMovieR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(124, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de peliculas de los 80";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BtnExit.Location = new System.Drawing.Point(85, 239);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(130, 45);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Cerrar Aplicacion";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblPelicula
            // 
            this.LblPelicula.AutoSize = true;
            this.LblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblPelicula.Location = new System.Drawing.Point(112, 144);
            this.LblPelicula.Name = "LblPelicula";
            this.LblPelicula.Size = new System.Drawing.Size(86, 25);
            this.LblPelicula.TabIndex = 2;
            this.LblPelicula.Text = "Pelicula:";
            // 
            // CbMovies
            // 
            this.CbMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CbMovies.FormattingEnabled = true;
            this.CbMovies.Location = new System.Drawing.Point(242, 179);
            this.CbMovies.Name = "CbMovies";
            this.CbMovies.Size = new System.Drawing.Size(273, 30);
            this.CbMovies.TabIndex = 3;
            this.CbMovies.SelectedIndexChanged += new System.EventHandler(this.CbMovies_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnAdd.Location = new System.Drawing.Point(85, 179);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(130, 34);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TxtMovie
            // 
            this.TxtMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtMovie.Location = new System.Drawing.Point(242, 141);
            this.TxtMovie.Name = "TxtMovie";
            this.TxtMovie.Size = new System.Drawing.Size(273, 28);
            this.TxtMovie.TabIndex = 5;
            // 
            // LblMovieR
            // 
            this.LblMovieR.AutoSize = true;
            this.LblMovieR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LblMovieR.ForeColor = System.Drawing.Color.Crimson;
            this.LblMovieR.Location = new System.Drawing.Point(276, 247);
            this.LblMovieR.Name = "LblMovieR";
            this.LblMovieR.Size = new System.Drawing.Size(59, 20);
            this.LblMovieR.TabIndex = 6;
            this.LblMovieR.Text = "label2";
            this.LblMovieR.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.ControlBox = false;
            this.Controls.Add(this.LblMovieR);
            this.Controls.Add(this.TxtMovie);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbMovies);
            this.Controls.Add(this.LblPelicula);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Name = "Quiz";
            this.Text = "GESTION DE PELICULAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblPelicula;
        private System.Windows.Forms.ComboBox CbMovies;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtMovie;
        private System.Windows.Forms.Label LblMovieR;
    }
}

