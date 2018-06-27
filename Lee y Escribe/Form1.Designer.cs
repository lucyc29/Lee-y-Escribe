namespace Lee_y_Escribe
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TVelocidad = new System.Windows.Forms.TrackBar();
            this.PFlechaR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaR)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(574, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inicio";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TVelocidad
            // 
            this.TVelocidad.Location = new System.Drawing.Point(585, 127);
            this.TVelocidad.Minimum = -5;
            this.TVelocidad.Name = "TVelocidad";
            this.TVelocidad.Size = new System.Drawing.Size(104, 45);
            this.TVelocidad.TabIndex = 2;
            this.TVelocidad.Value = -2;
            // 
            // PFlechaR
            // 
            this.PFlechaR.BackColor = System.Drawing.Color.Transparent;
            this.PFlechaR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PFlechaR.BackgroundImage")));
            this.PFlechaR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PFlechaR.Location = new System.Drawing.Point(482, 437);
            this.PFlechaR.Name = "PFlechaR";
            this.PFlechaR.Size = new System.Drawing.Size(86, 57);
            this.PFlechaR.TabIndex = 9;
            this.PFlechaR.TabStop = false;
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 506);
            this.ControlBox = false;
            this.Controls.Add(this.PFlechaR);
            this.Controls.Add(this.TVelocidad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Portada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprende a Leer y Escribir con Tatty";
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PFlechaR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar TVelocidad;
        private System.Windows.Forms.PictureBox PFlechaR;
    }
}

