namespace SICXE
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
            this.analizar = new System.Windows.Forms.Button();
            this.dt_TabSim = new System.Windows.Forms.DataGridView();
            this.SIMBOLO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TabSim)).BeginInit();
            this.SuspendLayout();
            // 
            // analizar
            // 
            this.analizar.Location = new System.Drawing.Point(42, 27);
            this.analizar.Name = "analizar";
            this.analizar.Size = new System.Drawing.Size(75, 23);
            this.analizar.TabIndex = 0;
            this.analizar.Text = "ANALIZAR";
            this.analizar.UseVisualStyleBackColor = true;
            this.analizar.Click += new System.EventHandler(this.analizar_Click);
            // 
            // dt_TabSim
            // 
            this.dt_TabSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_TabSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIMBOLO,
            this.DIRECCION});
            this.dt_TabSim.Location = new System.Drawing.Point(42, 90);
            this.dt_TabSim.Name = "dt_TabSim";
            this.dt_TabSim.Size = new System.Drawing.Size(247, 150);
            this.dt_TabSim.TabIndex = 1;
            // 
            // SIMBOLO
            // 
            this.SIMBOLO.HeaderText = "SIMBOLO";
            this.SIMBOLO.Name = "SIMBOLO";
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.dt_TabSim);
            this.Controls.Add(this.analizar);
            this.Name = "Form1";
            this.Text = "ANALIZADOR";
            ((System.ComponentModel.ISupportInitialize)(this.dt_TabSim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button analizar;
        private System.Windows.Forms.DataGridView dt_TabSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
    }
}

