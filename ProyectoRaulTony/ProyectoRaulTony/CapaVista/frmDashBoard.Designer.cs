namespace ProyectoRaulTony
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.mesDashBoard = new System.Windows.Forms.MenuStrip();
            this.votantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRespaldoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importarRespaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btbReiniciaVotaciones = new System.Windows.Forms.Button();
            this.btbReturnLogin = new System.Windows.Forms.Button();
            this.btbGrafico = new System.Windows.Forms.Button();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.mesDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // mesDashBoard
            // 
            this.mesDashBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votantesToolStripMenuItem,
            this.candidatosToolStripMenuItem,
            this.periodoToolStripMenuItem,
            this.respaldoToolStripMenuItem});
            this.mesDashBoard.Location = new System.Drawing.Point(0, 0);
            this.mesDashBoard.Name = "mesDashBoard";
            this.mesDashBoard.Size = new System.Drawing.Size(669, 29);
            this.mesDashBoard.TabIndex = 0;
            this.mesDashBoard.Text = "menuStrip1";
            // 
            // votantesToolStripMenuItem
            // 
            this.votantesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.votantesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.votantesToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.votantes;
            this.votantesToolStripMenuItem.Name = "votantesToolStripMenuItem";
            this.votantesToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.votantesToolStripMenuItem.Text = "Votantes";
            this.votantesToolStripMenuItem.Click += new System.EventHandler(this.votantesToolStripMenuItem_Click);
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.candidatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.candidatosToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.candidato;
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.candidatosToolStripMenuItem.Text = "Candidatos";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // periodoToolStripMenuItem
            // 
            this.periodoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.periodoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.periodoToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.periodo;
            this.periodoToolStripMenuItem.Name = "periodoToolStripMenuItem";
            this.periodoToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.periodoToolStripMenuItem.Text = "Periodo";
            this.periodoToolStripMenuItem.Click += new System.EventHandler(this.periodoToolStripMenuItem_Click);
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRespaldoToolStripMenuItem1,
            this.importarRespaldoToolStripMenuItem});
            this.respaldoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.respaldoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.respaldoToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.respaldo;
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            // 
            // crearRespaldoToolStripMenuItem1
            // 
            this.crearRespaldoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.crearRespaldoToolStripMenuItem1.Image = global::ProyectoRaulTony.Properties.Resources.guardar;
            this.crearRespaldoToolStripMenuItem1.Name = "crearRespaldoToolStripMenuItem1";
            this.crearRespaldoToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.crearRespaldoToolStripMenuItem1.Text = "Exportar";
            this.crearRespaldoToolStripMenuItem1.Click += new System.EventHandler(this.crearRespaldoToolStripMenuItem1_Click);
            // 
            // importarRespaldoToolStripMenuItem
            // 
            this.importarRespaldoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.importarRespaldoToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.importar;
            this.importarRespaldoToolStripMenuItem.Name = "importarRespaldoToolStripMenuItem";
            this.importarRespaldoToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.importarRespaldoToolStripMenuItem.Text = "Importar";
            this.importarRespaldoToolStripMenuItem.Click += new System.EventHandler(this.importarRespaldoToolStripMenuItem_Click);
            // 
            // btbReiniciaVotaciones
            // 
            this.btbReiniciaVotaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbReiniciaVotaciones.Location = new System.Drawing.Point(34, 48);
            this.btbReiniciaVotaciones.Name = "btbReiniciaVotaciones";
            this.btbReiniciaVotaciones.Size = new System.Drawing.Size(106, 78);
            this.btbReiniciaVotaciones.TabIndex = 2;
            this.btbReiniciaVotaciones.Text = "Reiniciar Votaciones";
            this.btbReiniciaVotaciones.UseVisualStyleBackColor = true;
            this.btbReiniciaVotaciones.Click += new System.EventHandler(this.btbReiniciaVotaciones_Click);
            // 
            // btbReturnLogin
            // 
            this.btbReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbReturnLogin.Location = new System.Drawing.Point(35, 138);
            this.btbReturnLogin.Name = "btbReturnLogin";
            this.btbReturnLogin.Size = new System.Drawing.Size(105, 78);
            this.btbReturnLogin.TabIndex = 3;
            this.btbReturnLogin.Text = "Volver al Login";
            this.btbReturnLogin.UseVisualStyleBackColor = true;
            this.btbReturnLogin.Click += new System.EventHandler(this.btbReturnLogin_Click);
            // 
            // btbGrafico
            // 
            this.btbGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbGrafico.Location = new System.Drawing.Point(35, 242);
            this.btbGrafico.Name = "btbGrafico";
            this.btbGrafico.Size = new System.Drawing.Size(106, 78);
            this.btbGrafico.TabIndex = 4;
            this.btbGrafico.Text = "Gráficos";
            this.btbGrafico.UseVisualStyleBackColor = true;
            this.btbGrafico.Click += new System.EventHandler(this.btbGrafico_Click);
            // 
            // picFondo
            // 
            this.picFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFondo.Image = global::ProyectoRaulTony.Properties.Resources.elecciones_consejo;
            this.picFondo.Location = new System.Drawing.Point(0, 29);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(669, 429);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondo.TabIndex = 1;
            this.picFondo.TabStop = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 458);
            this.Controls.Add(this.btbGrafico);
            this.Controls.Add(this.btbReturnLogin);
            this.Controls.Add(this.btbReiniciaVotaciones);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.mesDashBoard);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mesDashBoard;
            this.MinimizeBox = false;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de configuración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mesDashBoard.ResumeLayout(false);
            this.mesDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mesDashBoard;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRespaldoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarRespaldoToolStripMenuItem;
        private System.Windows.Forms.Button btbReiniciaVotaciones;
        private System.Windows.Forms.Button btbReturnLogin;
        private System.Windows.Forms.Button btbGrafico;
    }
}