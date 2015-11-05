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
    public partial class frmVotantes : Form
    {
        public frmVotantes()
        {
            InitializeComponent();
            this.TraerDatos();
        }
        private void modificarVotantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {//metodo que llama a un windows form
            if (dtgVotantes.SelectedRows.Count > 0)
            {
                Votante votante = (Votante)dtgVotantes.SelectedRows[0].DataBoundItem;
                frmModificarVotantes modificarVotantes = new frmModificarVotantes(votante);
                modificarVotantes.Show();
                this.TraerDatos();
            }
            this.TraerDatos();
        }

        private void eliminarVotantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {//metodo que elimina la fila seleccionada
            if (DialogResult.Yes == MessageBox.Show("Desea eliminar el registro seleccionado",
                "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgVotantes.SelectedRows.Count > 0)
                {
                    Votante votante = (Votante)dtgVotantes.SelectedRows[0].DataBoundItem;
                    VotantesCL oVontantesCl = new VotantesCL();

                    oVontantesCl.EliminarVotantes(votante.Usuario);
                    if (oVontantesCl.IsError)
                    {

                        MessageBox.Show(oVontantesCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.TraerDatos();

                    }

                }
            }
            this.TraerDatos();
        }

        private void agregarVotantesToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que llama a un windows form
            frmAgregarVotantes agregaVotantes = new frmAgregarVotantes();
            agregaVotantes.Show();
            this.TraerDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {//metodo que busca utilizando un string dado por el usuario
            VotantesCL oVontantesCl = new VotantesCL();

            List<Votante> repuestos = oVontantesCl.ObtenerVotante();
            repuestos = repuestos.Where(x => x.Usuario.Contains(txtBuscar.Text)).ToList();
            dtgVotantes.DataSource = repuestos;

            if (oVontantesCl.IsError)
            {
                MessageBox.Show(oVontantesCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void TraerDatos()
        {//metodo que setea la tabla con datos
            VotantesCL oVontantesCl = new VotantesCL();
            dtgVotantes.DataSource = oVontantesCl.ObtenerVotante();

            if (oVontantesCl.IsError)
            {
                MessageBox.Show(oVontantesCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
