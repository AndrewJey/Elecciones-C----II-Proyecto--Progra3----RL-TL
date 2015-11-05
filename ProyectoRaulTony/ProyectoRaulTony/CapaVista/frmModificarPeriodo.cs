using ProyectoRaulTony.CapaLogica;
using ProyectoRaulTony.estructura;
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
    public partial class frmModificarPeriodo : Form
    {
        public frmModificarPeriodo(Periodo periodo)
        {//se definen objetos con datos que se resiven por parametros
            InitializeComponent();
            lblIDA.Text = periodo.id;
            lblFechaA.Text = periodo.fecha;
            lblHoraInicioA.Text = periodo.horaInicio;
            lblHoraFinalA.Text = periodo.horaFinal;
            lblEstadoA.Text = periodo.estado;
            txtEstado.Text = periodo.estado;
        }

        public frmModificarPeriodo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {//botom que modifica el periodo seleccionado y valida que solo exista un único periodo activo
            PeriodoCL oPeriodoCL = new PeriodoCL();
            int edit = 0;
            for (int i = 0; i < oPeriodoCL.ObtenerPeriodo().Count(); i++)
            {
                if ((oPeriodoCL.ObtenerPeriodo()[i].estado.Equals("a")) && (txtEstado.Text.Equals("a"))
                    ||(oPeriodoCL.ObtenerPeriodo()[i].estado.Equals("A")) && (txtEstado.Text.Equals("A")))
                {
                    edit = 1;
                }
            }
            if (edit == 0)
            {
                oPeriodoCL.EditarPeriodo(lblIDA.Text, dtpFecha.Text, dtpHoraInicio.Text, dtpHoraFinal.Text, txtEstado.Text);

                if (oPeriodoCL.IsError)
                {
                    MessageBox.Show(oPeriodoCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Periodo modificado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya existe otro periodo activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//metodo que cierra el windows form
            this.Close();
        }
    }
}
