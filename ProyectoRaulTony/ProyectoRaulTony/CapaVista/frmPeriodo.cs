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

namespace ProyectoRaulTony.CapaVista
{
    public partial class frmPeriodo : Form
    {
        PeriodoCL oPeriodoCL = new PeriodoCL();
        public frmPeriodo()
        {
            InitializeComponent();

            this.TraerDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {//metodo que busca un string elegido por el usuario

            List<Periodo> Periodo = oPeriodoCL.ObtenerPeriodo();
            Periodo = Periodo.Where(x => x.fecha.Contains(txtfiltro.Text)).ToList();
            dtgPeriodo.DataSource = Periodo;

            if (oPeriodoCL.IsError)
            {
                MessageBox.Show(oPeriodoCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que llama a un windows form
            frmAgregarPeriodo oPeriodo = new frmAgregarPeriodo();
            oPeriodo.ShowDialog();
            this.TraerDatos();
        }

        private void TraerDatos()
        {//metodo que setea datos a la tabla
            dtgPeriodo.DataSource = oPeriodoCL.ObtenerPeriodo();

            if (oPeriodoCL.IsError)
            {
                MessageBox.Show(oPeriodoCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que llama a un windows form
            if (dtgPeriodo.SelectedRows.Count > 0)
            {
                Periodo periodo = (Periodo)dtgPeriodo.SelectedRows[0].DataBoundItem;
                frmModificarPeriodo modificarperiodo = new frmModificarPeriodo(periodo);
                modificarperiodo.Show();
            }
            this.TraerDatos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que elimina la fila seleccionada
            if (DialogResult.Yes == MessageBox.Show("Desea eliminar el registro seleccionado",
                "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgPeriodo.SelectedRows.Count > 0)
                {
                    Periodo periodo = (Periodo)dtgPeriodo.SelectedRows[0].DataBoundItem;
                    oPeriodoCL.EliminarPeriodo(periodo.id);
                    if (oPeriodoCL.IsError)
                    {

                        MessageBox.Show(oPeriodoCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Periodo eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TraerDatos();

                    }
                }
            }
        }

    }
}
