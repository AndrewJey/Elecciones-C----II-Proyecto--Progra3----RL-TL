using ProyectoRaulTony.CapaLogica;
using ProyectoRaulTony.CapaVista;
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
    public partial class frmAgregarVotantes : Form
    {
        public frmAgregarVotantes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {//metodo que genera una contraseña con numeros y letras
            txtContraseña.Text = Guid.NewGuid().ToString().Substring(0, 10)+"0";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {//metodo que envia datos para que sean agregados
            VotantesCL oVotantesCL = new VotantesCL();
            oVotantesCL.AgregarVotantes(txtUsuario.Text, txtContraseña.Text);

            if (oVotantesCL.IsError)
            {
                MessageBox.Show(oVotantesCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Votante agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtUsuario.ResetText();
            txtContraseña.ResetText();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//metodo que cierra el form
            this.Close();
        }
    }
}
