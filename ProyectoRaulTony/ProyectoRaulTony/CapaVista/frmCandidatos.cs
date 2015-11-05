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
    public partial class frmCandidatos : Form
    {
        public frmCandidatos()
        {
            InitializeComponent();
            TraerDatos();
        }

        private void agregarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que crea una instancia y llama un windows form
            frmAgregarCandidato agregaCandidato = new frmAgregarCandidato();
            agregaCandidato.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {//metodo que realiza una busqueda y actualiza la tabla con los datos encontrados
            CandidatosCL oCandidatoCl = new CandidatosCL();

            List<Candidato> Candidato = oCandidatoCl.ObtenerCandidato();
            Candidato = Candidato.Where(x => x.Candidatos.Contains(txtBuscar.Text)).ToList();
            dtgCandidatos.DataSource = Candidato;

            if (oCandidatoCl.IsError)
            {
                MessageBox.Show(oCandidatoCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void TraerDatos()
        {//metodo que obtiene datos de una instancia
            CandidatosCL oCandidatoCl = new CandidatosCL();
            dtgCandidatos.DataSource = oCandidatoCl.ObtenerCandidato();

            if (oCandidatoCl.IsError)
            {
                MessageBox.Show(oCandidatoCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {//metodo que crea una instancia que abre un windows form
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                Candidato candidato = (Candidato)dtgCandidatos.SelectedRows[0].DataBoundItem;
                frmModificarCandidato modificarCandidato = new frmModificarCandidato(candidato);
                modificarCandidato.Show();
                this.TraerDatos();
            }
        }

        private void eliminarCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {//metodo que elimina la fila seleccionada
            if (DialogResult.Yes == MessageBox.Show("Desea eliminar el registro seleccionado",
                "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (dtgCandidatos.SelectedRows.Count > 0)
                {
                    Candidato candidatos = (Candidato)dtgCandidatos.SelectedRows[0].DataBoundItem;
                    CandidatosCL oCandidatoCl = new CandidatosCL();

                    oCandidatoCl.EliminarCandidatos(candidatos.Candidatos);
                    if (oCandidatoCl.IsError)
                    {

                        MessageBox.Show(oCandidatoCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.TraerDatos();

                    }

                }
            }
        }
    }
}
