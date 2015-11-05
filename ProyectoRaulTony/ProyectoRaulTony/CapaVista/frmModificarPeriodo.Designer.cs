namespace ProyectoRaulTony
{
    partial class frmModificarPeriodo
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
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.lblHoraFinalA = new System.Windows.Forms.Label();
            this.lblHoraInicioA = new System.Windows.Forms.Label();
            this.lblFechaA = new System.Windows.Forms.Label();
            this.lblIDA = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoA = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(245, 139);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraFinal.TabIndex = 3;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(245, 107);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraInicio.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(245, 75);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Location = new System.Drawing.Point(94, 29);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(43, 13);
            this.lblAnterior.TabIndex = 28;
            this.lblAnterior.Text = "Anterior";
            // 
            // lblHoraFinalA
            // 
            this.lblHoraFinalA.AutoSize = true;
            this.lblHoraFinalA.Location = new System.Drawing.Point(76, 145);
            this.lblHoraFinalA.Name = "lblHoraFinalA";
            this.lblHoraFinalA.Size = new System.Drawing.Size(0, 13);
            this.lblHoraFinalA.TabIndex = 27;
            // 
            // lblHoraInicioA
            // 
            this.lblHoraInicioA.AutoSize = true;
            this.lblHoraInicioA.Location = new System.Drawing.Point(76, 113);
            this.lblHoraInicioA.Name = "lblHoraInicioA";
            this.lblHoraInicioA.Size = new System.Drawing.Size(0, 13);
            this.lblHoraInicioA.TabIndex = 26;
            // 
            // lblFechaA
            // 
            this.lblFechaA.AutoSize = true;
            this.lblFechaA.Location = new System.Drawing.Point(76, 82);
            this.lblFechaA.Name = "lblFechaA";
            this.lblFechaA.Size = new System.Drawing.Size(0, 13);
            this.lblFechaA.TabIndex = 25;
            // 
            // lblIDA
            // 
            this.lblIDA.AutoSize = true;
            this.lblIDA.Location = new System.Drawing.Point(76, 53);
            this.lblIDA.Name = "lblIDA";
            this.lblIDA.Size = new System.Drawing.Size(0, 13);
            this.lblIDA.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(245, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(146, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(10, 145);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(52, 13);
            this.lblHoraFinal.TabIndex = 21;
            this.lblHoraFinal.Text = "HoraFinal";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(10, 113);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(55, 13);
            this.lblHoraInicio.TabIndex = 20;
            this.lblHoraInicio.Text = "HoraInicio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(10, 82);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 177);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "Estado";
            // 
            // lblEstadoA
            // 
            this.lblEstadoA.AutoSize = true;
            this.lblEstadoA.Location = new System.Drawing.Point(76, 177);
            this.lblEstadoA.Name = "lblEstadoA";
            this.lblEstadoA.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoA.TabIndex = 33;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(245, 170);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(200, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // frmModificarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 276);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstadoA);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.lblHoraFinalA);
            this.Controls.Add(this.lblHoraInicioA);
            this.Controls.Add(this.lblFechaA);
            this.Controls.Add(this.lblIDA);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblID);
            this.Name = "frmModificarPeriodo";
            this.Text = "Modificar Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label lblHoraFinalA;
        private System.Windows.Forms.Label lblHoraInicioA;
        private System.Windows.Forms.Label lblFechaA;
        private System.Windows.Forms.Label lblIDA;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoA;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblID;
    }
}