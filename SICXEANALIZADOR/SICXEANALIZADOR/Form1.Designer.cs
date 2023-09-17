namespace SICXEANALIZADOR
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
            this.titulo = new System.Windows.Forms.Label();
            this.botonex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Magenta;
            this.titulo.Location = new System.Drawing.Point(187, 37);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(461, 48);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "ANALIZADOR SICXE";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonex
            // 
            this.botonex.Location = new System.Drawing.Point(301, 147);
            this.botonex.Name = "botonex";
            this.botonex.Size = new System.Drawing.Size(208, 53);
            this.botonex.TabIndex = 1;
            this.botonex.Text = "EXAMINAR";
            this.botonex.UseVisualStyleBackColor = true;
            this.botonex.Click += new System.EventHandler(this.botonex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonex);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button botonex;
    }
}

