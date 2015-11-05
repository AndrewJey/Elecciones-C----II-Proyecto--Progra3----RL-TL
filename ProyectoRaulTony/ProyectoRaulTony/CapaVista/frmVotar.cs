using ProyectoRaulTony.CapaLogica;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
namespace ProyectoRaulTony
{
    public partial class frmVotar : System.Windows.Forms.Form
    {
        private FlowLayoutPanel panel = new FlowLayoutPanel();//se declaran atributos
        private List<Candidato> candidato2 = null;
        private List<string> partidos;
        private List<int> valor;
        #region " Windows Form Designer generated code "
        public frmVotar(List<Candidato> candidato)
            : base()
        {
            partidos = new List<string> { };//se inicializan los atributos
            valor = new List<int> { };
            InitializeComponent();
            InitializeComponent2(candidato);

            candidato2 = candidato;

        }
        private void InitializeComponent2(List<Candidato> candidato)//metodo que 
        {//metodo que determina el diseño dinamico del windows form
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btbVotar = new System.Windows.Forms.Button();
            // 
            // btbVotar
            // 
            this.btbVotar.Location = new System.Drawing.Point(this.Height - 170, this.Width - 130);
            this.btbVotar.Name = "btbVotar";
            this.btbVotar.TabIndex = 0;
            this.btbVotar.Text = "Votar";
            this.btbVotar.Click += new System.EventHandler(this.btbVotar_Clicked);
            this.btbVotar.Dock = System.Windows.Forms.DockStyle.Bottom;

            for (int i = 0; i < candidato.Count(); i++)
            {
                this.panelCandidatos = new System.Windows.Forms.Panel();

                this.chkVotar = new System.Windows.Forms.CheckBox();
                this.lblCandidato = new System.Windows.Forms.Label();
                this.lblPartido = new System.Windows.Forms.Label();
                this.picPartido = new System.Windows.Forms.PictureBox();
                this.flowLayoutPanel1.SuspendLayout();
                this.panelCandidatos.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.picPartido)).BeginInit();
                this.SuspendLayout();
                // 
                // flpPanel
                // 
                this.flowLayoutPanel1.AutoScroll = true;
                this.flowLayoutPanel1.Controls.Add(this.panelCandidatos);
                this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                this.flowLayoutPanel1.WrapContents = true;
                this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
                this.flowLayoutPanel1.Name = "flpPanel";
                this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 500);
                this.flowLayoutPanel1.TabIndex = 0;
                // 
                // PanelCandidatos
                // 
                this.panelCandidatos.Controls.Add(this.chkVotar);
                this.panelCandidatos.Controls.Add(this.lblCandidato);
                this.panelCandidatos.Controls.Add(this.lblPartido);
                this.panelCandidatos.Controls.Add(this.picPartido);
                this.panelCandidatos.Location = new System.Drawing.Point(0, 0);
                this.panelCandidatos.Name = "PanelCandidatos";
                this.panelCandidatos.Size = new System.Drawing.Size(134, 235);
                this.panelCandidatos.TabIndex = 1;
                // 
                // chkVotar
                // 
                this.partidos.Add(candidato[i].Partidos);
                this.valor.Add(0);
                this.chkVotar.Appearance = System.Windows.Forms.Appearance.Button;
                this.chkVotar.AutoSize = true;
                this.chkVotar.Location = new System.Drawing.Point(40, 171);
                this.chkVotar.MaximumSize = new System.Drawing.Size(50, 50);
                this.chkVotar.MinimumSize = new System.Drawing.Size(50, 50);
                this.chkVotar.Name = candidato[i].Partidos;
                this.chkVotar.Size = new System.Drawing.Size(50, 50);
                this.chkVotar.TabIndex = 1;
                this.chkVotar.UseVisualStyleBackColor = true;
                this.chkVotar.CheckedChanged += new System.EventHandler(this.chkVotar_CheckedChanged);
                // 
                // lblCandidato
                // 
                this.lblCandidato.AutoSize = true;
                this.lblCandidato.Location = new System.Drawing.Point(38, 136);
                this.lblCandidato.Name = "lblCandidato";
                this.lblCandidato.Size = new System.Drawing.Size(55, 13);
                this.lblCandidato.TabIndex = 17;
                this.lblCandidato.Text = candidato[i].Candidatos;
                // 
                // lblPartido
                // 
                this.lblPartido.AutoSize = true;
                this.lblPartido.Location = new System.Drawing.Point(42, 5);
                this.lblPartido.Name = "lblPartido";
                this.lblPartido.Size = new System.Drawing.Size(40, 13);
                this.lblPartido.TabIndex = 16;
                this.lblPartido.Text = candidato[i].Partidos;
                // 
                // picPartido
                // 
                this.picPartido.BackColor = System.Drawing.Color.DeepSkyBlue;
                this.picPartido.Location = new System.Drawing.Point(13, 21);
                this.picPartido.Name = "picPartido";
                this.picPartido.Size = new System.Drawing.Size(99, 104);
                this.picPartido.TabIndex = 15;
                this.picPartido.TabStop = false;
                this.picPartido.Image = candidato[i].Imagen;
                // 
                // Form1
                // 
                this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
                this.Controls.Add(btbVotar);
                this.Controls.Add(flowLayoutPanel1);
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(700, 525);
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Name = "frmVotar";
                this.Text = "Votar";
                this.flowLayoutPanel1.ResumeLayout(false);
                this.panelCandidatos.ResumeLayout(false);
                this.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.picPartido)).EndInit();
                this.ResumeLayout(false);

            }
        }
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelCandidatos;
        private System.Windows.Forms.CheckBox chkVotar;
        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.PictureBox picPartido;
        private System.Windows.Forms.Button btbVotar;
        #endregion

        private void btbVotar_Clicked(object sender, EventArgs e)
        {//metodo que realiza el voto, valida que se encuentre en un periodo activo y que su computadora
            PeriodoCL oPeriodoCl = new PeriodoCL();//tenga la hora entre el periodo de votacion
            DateTime fechaActual = DateTime.Now;
            List<Periodo> periodo = new List<Periodo> { };
            periodo = oPeriodoCl.ObtenerPeriodo();
            for (int x = 0; x < periodo.Count; x++)
            {
                if (periodo[x].estado.ToUpper() == "A")
                {
                    string[] fecha = periodo[x].fecha.Split(' ');
                    string dia = fecha[1];
                    string mes2 = fecha[3];
                    string año = fecha[5];
                    string Inicio = periodo[x].horaInicio;
                    string Fin = periodo[x].horaFinal;
                    int mes = 0;
                    List<string> meses = new List<string> { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
                    for (int y = 0; y < meses.Count; y++)
                    {
                        if (meses[y] == mes2.ToLower())
                        {
                            mes = y + 1;
                        }
                    }
                    if (mes < 10)
                    {
                        mes2 = "0" + mes;
                    }
                    else
                    {
                        mes2 = "" + mes;
                    }
                    CultureInfo culture;
                    DateTimeStyles styles;
                    DateTime FechaInicio;

                    // Parse a date and time with no styles.
                    culture = CultureInfo.CreateSpecificCulture("en-US");
                    styles = DateTimeStyles.None;
                    string AMoPM = Inicio.Remove(0, 9);
                    AMoPM = AMoPM.Remove(1, 3);
                    if (AMoPM.ToLower() == "a")
                    {
                        AMoPM = "AM";
                    }
                    else
                    {
                        AMoPM = "PM";
                    }
                    string temp = mes2 + "/" + dia + "/" + año + " " + Inicio.Remove(8, 5) + " " + AMoPM;
                    if (DateTime.TryParse(temp, culture, styles, out FechaInicio))
                        Console.WriteLine("{0} converted to {1} {2}.", temp, FechaInicio, FechaInicio.Kind);
                    DateTime fechaFin;
                    // Parse a date and time with no styles.
                    culture = CultureInfo.CreateSpecificCulture("en-US");
                    styles = DateTimeStyles.None;
                    AMoPM = Fin.Remove(0, 9);
                    AMoPM = AMoPM.Remove(1, 3);
                    if (AMoPM.ToLower() == "a")
                    {
                        AMoPM = "AM";
                    }
                    else
                    {
                        AMoPM = "PM";
                    }
                    temp = mes2 + "/" + dia + "/" + año + " " + Fin.Remove(8, 5) + " " + AMoPM;
                    if (DateTime.TryParse(temp, culture, styles, out fechaFin))
                        Console.WriteLine("{0} converted to {1} {2}.", temp, fechaFin, fechaFin.Kind);
                    if (fechaActual >= FechaInicio && fechaActual <= fechaFin)
                    {
                        int cont = 0;
                        int posicion = 0;
                        for (int i = 0; i < partidos.Count(); i++)
                        {
                            if (valor[i] == 1)
                            {
                                cont++;
                                posicion = i;
                            }
                        }
                        if (cont == 1)
                        {
                            VotacionesCL oVotacionesCL = new VotacionesCL();
                            oVotacionesCL.AgregarVotaciones(partidos[posicion], Convert.ToString(valor[posicion]));

                            if (oVotacionesCL.IsError)
                            {
                                MessageBox.Show(oVotacionesCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Voto agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();
                        }
                        else
                        {
                            VotacionesCL oVotacionesCL = new VotacionesCL();
                            oVotacionesCL.AgregarVotaciones("Nulo", "1");

                            if (oVotacionesCL.IsError)
                            {
                                MessageBox.Show(oVotacionesCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Voto agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra en el periodo de votación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                if (x == periodo.Count - 1)
                {
                    MessageBox.Show("No se encuentra ningún periodo de votacion activo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void chkVotar_CheckedChanged(object sender, EventArgs e)
        {//metodo que guarda los eventos que ocurren cuando se activa o desactiva un checkbox
            for (int i = 0; i < partidos.Count(); i++)
            {
                CheckBox cbSeleccionado = (CheckBox)sender;
                if (partidos[i] == cbSeleccionado.Name)
                {
                    if (cbSeleccionado.Checked)
                    {
                        valor[i] = 1;
                    }
                    else
                    {
                        valor[i] = 0;
                    }
                }
            }
        }
    }
}


