namespace ProyectoRaulTony.CapaVista
{
    partial class frmCandidatos
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
            this.dtgCandidatos = new System.Windows.Forms.DataGridView();
            this.pnlCandidatos = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.mesCandidatos = new System.Windows.Forms.MenuStrip();
            this.agregarCandidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCandidatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCandidatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCandidatos)).BeginInit();
            this.pnlCandidatos.SuspendLayout();
            this.mesCandidatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCandidatos
            // 
            this.dtgCandidatos.AllowUserToAddRows = false;
            this.dtgCandidatos.AllowUserToDeleteRows = false;
            this.dtgCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCandidatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCandidatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCandidatos.Location = new System.Drawing.Point(0, 82);
            this.dtgCandidatos.MultiSelect = false;
            this.dtgCandidatos.Name = "dtgCandidatos";
            this.dtgCandidatos.ReadOnly = true;
            this.dtgCandidatos.Size = new System.Drawing.Size(670, 467);
            this.dtgCandidatos.TabIndex = 8;
            // 
            // pnlCandidatos
            // 
            this.pnlCandidatos.Controls.Add(this.btnBuscar);
            this.pnlCandidatos.Controls.Add(this.txtBuscar);
            this.pnlCandidatos.Controls.Add(this.lblBuscar);
            this.pnlCandidatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCandidatos.Location = new System.Drawing.Point(0, 24);
            this.pnlCandidatos.Name = "pnlCandidatos";
            this.pnlCandidatos.Size = new System.Drawing.Size(670, 58);
            this.pnlCandidatos.TabIndex = 7;
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
            // mesCandidatos
            // 
            this.mesCandidatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCandidatoToolStripMenuItem,
            this.modificarCandidatoToolStripMenuItem1,
            this.eliminarCandidatoToolStripMenuItem1});
            this.mesCandidatos.Location = new System.Drawing.Point(0, 0);
            this.mesCandidatos.Name = "mesCandidatos";
            this.mesCandidatos.Size = new System.Drawing.Size(670, 24);
            this.mesCandidatos.TabIndex = 6;
            this.mesCandidatos.Text = "menuVotantes";
            // 
            // agregarCandidatoToolStripMenuItem
            // 
            this.agregarCandidatoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.agregarCandidatoToolStripMenuItem.Image = global::ProyectoRaulTony.Properties.Resources.agregar;
            this.agregarCandidatoToolStripMenuItem.Name = "agregarCandidatoToolStripMenuItem";
            this.agregarCandidatoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.agregarCandidatoToolStripMenuItem.Text = "Agregar";
            this.agregarCandidatoToolStripMenuItem.Click += new System.EventHandler(this.agregarCandidatoToolStripMenuItem_Click);
            // 
            // modificarCandidatoToolStripMenuItem1
            // 
            this.modificarCandidatoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.modificarCandidatoToolStripMenuItem1.Image = global::ProyectoRaulTony.Properties.Resources.editar;
            this.modificarCandidatoToolStripMenuItem1.Name = "modificarCandidatoToolStripMenuItem1";
            this.modificarCandidatoToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.modificarCandidatoToolStripMenuItem1.Text = "Modificar";
            this.modificarCandidatoToolStripMenuItem1.Click += new System.EventHandler(this.modificarCandidatoToolStripMenuItem1_Click);
            // 
            // eliminarCandidatoToolStripMenuItem1
            // 
            this.eliminarCandidatoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.eliminarCandidatoToolStripMenuItem1.Image = global::ProyectoRaulTony.Properties.Resources.eliminar;
            this.eliminarCandidatoToolStripMenuItem1.Name = "eliminarCandidatoToolStripMenuItem1";
            this.eliminarCandidatoToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.eliminarCandidatoToolStripMenuItem1.Text = "Eliminar";
            this.eliminarCandidatoToolStripMenuItem1.Click += new System.EventHandler(this.eliminarCandidatoToolStripMenuItem1_Click);
            // 
            // frmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 549);
            this.Controls.Add(this.dtgCandidatos);
            this.Controls.Add(this.pnlCandidatos);
            this.Controls.Add(this.mesCandidatos);
            this.Name = "frmCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidatos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCandidatos)).EndInit();
            this.pnlCandidatos.ResumeLayout(false);
            this.pnlCandidatos.PerformLayout();
            this.mesCandidatos.ResumeLayout(false);
            this.mesCandidatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCandidatos;
        private System.Windows.Forms.Panel pnlCandidatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.MenuStrip mesCandidatos;
        private System.Windows.Forms.ToolStripMenuItem agregarCandidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCandidatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarCandidatoToolStripMenuItem1;
    }
}