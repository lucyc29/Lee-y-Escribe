namespace Lee_y_Escribe
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BJuegos = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.LVocales = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BRepetir = new System.Windows.Forms.Button();
            this.TVelocidad = new System.Windows.Forms.TrackBar();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.BJuegos);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.LVocales);
            this.panel1.Controls.Add(this.Inicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 544);
            this.panel1.TabIndex = 1;
            // 
            // BJuegos
            // 
            this.BJuegos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BJuegos.FlatAppearance.BorderSize = 0;
            this.BJuegos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BJuegos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.BJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BJuegos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BJuegos.Image = ((System.Drawing.Image)(resources.GetObject("BJuegos.Image")));
            this.BJuegos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BJuegos.Location = new System.Drawing.Point(3, 169);
            this.BJuegos.Name = "BJuegos";
            this.BJuegos.Size = new System.Drawing.Size(207, 66);
            this.BJuegos.TabIndex = 5;
            this.BJuegos.Text = "   Juegos";
            this.BJuegos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BJuegos.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(3, 467);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(204, 66);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "   Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // LVocales
            // 
            this.LVocales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LVocales.FlatAppearance.BorderSize = 0;
            this.LVocales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.LVocales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.LVocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LVocales.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVocales.Image = ((System.Drawing.Image)(resources.GetObject("LVocales.Image")));
            this.LVocales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LVocales.Location = new System.Drawing.Point(7, 86);
            this.LVocales.Name = "LVocales";
            this.LVocales.Size = new System.Drawing.Size(204, 66);
            this.LVocales.TabIndex = 1;
            this.LVocales.Text = " Lecciones";
            this.LVocales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LVocales.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.Inicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Inicio.FlatAppearance.BorderSize = 0;
            this.Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
            this.Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inicio.Location = new System.Drawing.Point(6, 3);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(204, 66);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "   Inicio";
            this.Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Inicio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BRepetir);
            this.panel2.Controls.Add(this.TVelocidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 544);
            this.panel2.TabIndex = 2;
            // 
            // BRepetir
            // 
            this.BRepetir.BackColor = System.Drawing.Color.Transparent;
            this.BRepetir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BRepetir.FlatAppearance.BorderSize = 0;
            this.BRepetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BRepetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRepetir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRepetir.Image = ((System.Drawing.Image)(resources.GetObject("BRepetir.Image")));
            this.BRepetir.Location = new System.Drawing.Point(507, 474);
            this.BRepetir.Name = "BRepetir";
            this.BRepetir.Size = new System.Drawing.Size(141, 57);
            this.BRepetir.TabIndex = 6;
            this.BRepetir.Text = "Repetir";
            this.BRepetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRepetir.UseVisualStyleBackColor = false;
            // 
            // TVelocidad
            // 
            this.TVelocidad.Location = new System.Drawing.Point(457, 68);
            this.TVelocidad.Minimum = -10;
            this.TVelocidad.Name = "TVelocidad";
            this.TVelocidad.Size = new System.Drawing.Size(171, 45);
            this.TVelocidad.TabIndex = 6;
            this.TVelocidad.Value = -2;
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVelocidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BJuegos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button LVocales;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar TVelocidad;
        private System.Windows.Forms.Button BRepetir;
        private System.Windows.Forms.Timer Tiempo;
    }
}