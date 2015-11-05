namespace ProyectoRaulTony.CapaVista
{
    partial class frmVotantes
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
            this.dtgVotantes = new System.Windows.Forms.DataGridView();
            this.pnlVotantes = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.mesVotantes = new System.Windows.Forms.MenuStrip();
            this.agregarVotantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVotantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVotantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVotantes)).BeginInit();
            this.pnlVotantes.SuspendLayout();
            this.mesVotantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVotantes
            // 
            this.dtgVotantes.AllowUserToAddRows = false;
            this.dtgVotantes.AllowUserToDeleteRows = false;
            this.dtgVotantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVotantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVotantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVotantes.Location = new System.Drawing.Point(0, 82);
            this.dtgVotantes.MultiSelect = false;
            this.dtgVotantes.Name = "dtgVotantes";
            this.dtgVotantes.ReadOnly = true;
            this.dtgVotantes.Size = new System.Drawing.Size(635, 352);
            this.dtgVotantes.TabIndex = 5;
            // 
            // pnlVotantes
            // 
            this.pnlVotantes.Controls.Add(this.btnBuscar);
            this.pnlVotantes.Controls.Add(this.txtBuscar);
            this.pnlVotantes.Controls.Add(this.lblBuscar);
            this.pnlVotantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVotantes.Location = new System.Drawing.Point(0, 24);
            this.pnlVotantes.Name = "pnlVotantes";
            this.pnlVotantes.Size = new System.Drawing.Size(635, 58);
            this.pnlVotantes.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(339, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(76, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(257, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(27, 23);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(32, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Filtro:";
            // 
            // mesVotantes
            // 
            this.mesVotantes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVotantesToolStripMenuItem,
            this.modificarVotantesToolStripMenuItem1,
            this.eliminarVotantesToolStripMenuItem1});
            this.mesVotantes.Location = new System.Drawing.Point(0, 0);
            this.mesVotantes.Name = "mesVotantes";
            this.mesVotantes.Size = new System.Drawing.Size(635, 24);
            this.mesVotantes.TabIndex = 3;
            this.mesVotantes.Text = "menuVotantes";
            // 
            // agregarVotantesToolStripMenuItem
            // 
            this.agregarVotantesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.agregarVotantesToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.agregar;
            this.agregarVotantesToolStripMenuItem.Name = "agregarVotantesToolStripMenuItem";
            this.agregarVotantesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.agregarVotantesToolStripMenuItem.Text = "Agregar";
            this.agregarVotantesToolStripMenuItem.Click += new System.EventHandler(this.agregarVotantesToolStripMenuItem_Click);
            // 
            // modificarVotantesToolStripMenuItem1
            // 
            this.modificarVotantesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.modificarVotantesToolStripMenuItem1.Image = global::ProyectoRaulTony.Properties.Resources.editar;
            this.modificarVotantesToolStripMenuItem1.Name = "modificarVotantesToolStripMenuItem1";
            this.modificarVotantesToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.modificarVotantesToolStripMenuItem1.Text = "Modificar";
            this.modificarVotantesToolStripMenuItem1.Click += new System.EventHandler(this.modificarVotantesToolStripMenuItem1_Click);
            // 
            // eliminarVotantesToolStripMenuItem1
            // 
            this.eliminarVotantesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.eliminarVotantesToolStripMenuItem1.Image = global::ProyectoRaulTony.Properties.Resources.eliminar;
            this.eliminarVotantesToolStripMenuItem1.Name = "eliminarVotantesToolStripMenuItem1";
            this.eliminarVotantesToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.eliminarVotantesToolStripMenuItem1.Text = "Eliminar";
            this.eliminarVotantesToolStripMenuItem1.Click += new System.EventHandler(this.eliminarVotantesToolStripMenuItem1_Click);
            // 
            // frmVotantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(635, 434);
            this.Controls.Add(this.dtgVotantes);
            this.Controls.Add(this.pnlVotantes);
            this.Controls.Add(this.mesVotantes);
            this.Name = "frmVotantes";
            this.Text = "Votantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVotantes)).EndInit();
            this.pnlVotantes.ResumeLayout(false);
            this.pnlVotantes.PerformLayout();
            this.mesVotantes.ResumeLayout(false);
            this.mesVotantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVotantes;
        private System.Windows.Forms.Panel pnlVotantes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.MenuStrip mesVotantes;
        private System.Windows.Forms.ToolStripMenuItem agregarVotantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVotantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarVotantesToolStripMenuItem1;
    }
}