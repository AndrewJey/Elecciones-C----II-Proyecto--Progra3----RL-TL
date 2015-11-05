namespace ProyectoRaulTony
{
    partial class frmModificarCandidato
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
            this.picPartido = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCandidato = new System.Windows.Forms.TextBox();
            this.lblCandidato = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // picPartido
            // 
            this.picPartido.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picPartido.Location = new System.Drawing.Point(264, 18);
            this.picPartido.Name = "picPartido";
            this.picPartido.Size = new System.Drawing.Size(99, 104);
            this.picPartido.TabIndex = 21;
            this.picPartido.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(134, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(32, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCandidato
            // 
            this.txtCandidato.Location = new System.Drawing.Point(99, 74);
            this.txtCandidato.Name = "txtCandidato";
            this.txtCandidato.Size = new System.Drawing.Size(142, 20);
            this.txtCandidato.TabIndex = 18;
            // 
            // lblCandidato
            // 
            this.lblCandidato.AutoSize = true;
            this.lblCandidato.Location = new System.Drawing.Point(32, 81);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(55, 13);
            this.lblCandidato.TabIndex = 17;
            this.lblCandidato.Text = "Candidato";
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(99, 22);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(142, 20);
            this.txtPartido.TabIndex = 16;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(32, 29);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 15;
            this.lblPartido.Text = "Partido";
            // 
            // frmModificarCandidato
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
            this.Name = "frmModificarCandidato";
            this.Text = "Modificar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.picPartido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPartido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCandidato;
        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label lblPartido;
    }
}