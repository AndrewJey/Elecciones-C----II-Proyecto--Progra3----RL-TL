using ProyectoRaulTony.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRaulTony
{
    public partial class frmAgregarPeriodo : Form
    {
        public frmAgregarPeriodo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //botom que envia datos para que sean agregados
            PeriodoCL oPeriodo = new PeriodoCL();
            oPeriodo.CrearPeriodo((dtpFecha.Text), (dtpHoraInicio.Text), (dtpHoraFinal.Text), ("I"));
            if (oPeriodo.IsError)
            {
                MessageBox.Show(oPeriodo.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Periodo agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//botom que sale del form
            this.Close();
        }
    }
}
