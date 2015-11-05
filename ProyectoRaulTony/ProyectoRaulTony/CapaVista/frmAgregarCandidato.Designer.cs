namespace ProyectoRaulTony
{
    partial class frmAgregarCandidato
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCandidato = new System.Windows.Forms.TextBox();
            this.lblCandidato = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.picPartido = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(138, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(36, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 34);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCandidato
            // 
            this.txtCandidato.Location = new System.Drawing.Point(100, 72);
            this.txtCandidato.Name = "txtCandidato";
            this.txtCandidato.Size = new System.Drawing.Size(142, 20);
            this.txtCandidato.TabIndex = 10;
            // 
            // lblCandidato
            // 
            this.lblCandidato.AutoSize = true;
            this.lblCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCandidato.Location = new System.Drawing.Point(33, 79);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(55, 13);
            this.lblCandidato.TabIndex = 9;
            this.lblCandidato.Text = "Candidato";
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(100, 31);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(142, 20);
            this.txtPartido.TabIndex = 8;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPartido.Location = new System.Drawing.Point(33, 38);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 7;
            this.lblPartido.Text = "Partido";
            // 
            // picPartido
            // 
            this.picPartido.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picPartido.Location = new System.Drawing.Point(268, 12);
            this.picPartido.Name = "picPartido";
            this.picPartido.Size = new System.Drawing.Size(99, 104);
            this.picPartido.TabIndex = 14;
            this.picPartido.TabStop = false;
            // 
            // frmAgregarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 182);
            this.Controls.Add(this.picPartido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCandidato);
            this.Controls.Add(this.lblCandidato);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.lblPartido);
            this.Name = "frmAgregarCandidato";
            this.Text = "Agregar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.picPartido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCandidato;
        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.PictureBox picPartido;
    }
}