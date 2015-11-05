namespace ProyectoRaulTony.CapaVista
{
    partial class frmGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btbgrafico = new System.Windows.Forms.Button();
            this.btbSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chtGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend1);
            this.chtGrafico.Location = new System.Drawing.Point(12, 87);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Size = new System.Drawing.Size(328, 300);
            this.chtGrafico.TabIndex = 0;
            this.chtGrafico.Text = "chart1";
            // 
            // btbgrafico
            // 
            this.btbgrafico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btbgrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbgrafico.Location = new System.Drawing.Point(91, 12);
            this.btbgrafico.Name = "btbgrafico";
            this.btbgrafico.Size = new System.Drawing.Size(159, 53);
            this.btbgrafico.TabIndex = 2;
            this.btbgrafico.Text = "Gráfico";
            this.btbgrafico.UseVisualStyleBackColor = true;
            // 
            // btbSalir
            // 
            this.btbSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btbSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbSalir.Location = new System.Drawing.Point(274, 412);
            this.btbSalir.Name = "btbSalir";
            this.btbSalir.Size = new System.Drawing.Size(79, 25);
            this.btbSalir.TabIndex = 3;
            this.btbSalir.Text = "Salir";
            this.btbSalir.UseVisualStyleBackColor = true;
            this.btbSalir.Click += new System.EventHandler(this.btbSalir_Click);
            // 
            // frmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 437);
            this.Controls.Add(this.btbSalir);
            this.Controls.Add(this.btbgrafico);
            this.Controls.Add(this.chtGrafico);
            this.Name = "frmGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Button btbgrafico;
        private System.Windows.Forms.Button btbSalir;





    }
}