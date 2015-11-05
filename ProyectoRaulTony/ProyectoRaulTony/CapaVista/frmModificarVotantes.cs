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
    public partial class frmModificarVotantes : Form
    {
        public frmModificarVotantes(Votante votante)
        {//metodo que define objetos con datos que recive por parametros
            InitializeComponent();
            txtUser.Text = votante.Usuario;
            txtContraseña.Text = votante.Contraseña;
        }
        public frmModificarVotantes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {//botom que genera una clave con numeros y letras
            txtContraseña.Text = Guid.NewGuid().ToString().Substring(0, 10) + "0";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {//metodo que envia datos para que sean modificados
            VotantesCL oVotantesCL = new VotantesCL();
            oVotantesCL.EditarVotantes(txtUser.Text, txtContraseña.Text);

            if (oVotantesCL.IsError)
            {
                MessageBox.Show(oVotantesCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Votante Modificado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//metodo que cierra el windowns form
            this.Close();
        }

    }
}

