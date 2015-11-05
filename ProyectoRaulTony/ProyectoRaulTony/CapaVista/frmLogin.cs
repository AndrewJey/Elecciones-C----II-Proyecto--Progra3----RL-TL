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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {//metodo que valida si el usuario tiene derechos a entrar como administrador o como
            //votante, o si fuera el caso denegarle el acceso por falta de permisos
            bool valor = false;
            VotantesCL oVotantesCl = new VotantesCL();
            if (txtUser.Text == "admin" && txtPass.Text == "12345")
            {
                MessageBox.Show("Gracias por ingresar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmDashBoard oDashBoard = new frmDashBoard();
                oDashBoard.Show();
                valor = true;
                this.Hide();
            }

            for (int i = 0; i < oVotantesCl.ObtenerVotante().Count(); i++)
            {
                if (txtUser.Text == oVotantesCl.ObtenerVotante()[i].Usuario && txtPass.Text == oVotantesCl.ObtenerVotante()[i].Contraseña)
                {
                    string contraseña = oVotantesCl.ObtenerVotante()[i].Contraseña.Substring(oVotantesCl.ObtenerVotante()[i].Contraseña.Length - 1);
                    string contraseñaCompletaVoto = oVotantesCl.ObtenerVotante()[i].Contraseña.Substring(0, oVotantesCl.ObtenerVotante()[i].Contraseña.Length - 1) + "1";
                    if (contraseña == "0")
                    {
                        MessageBox.Show("Gracias por ingresar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        oVotantesCl.EditarVotantes(oVotantesCl.ObtenerVotante()[i].Usuario, contraseñaCompletaVoto);
                        CandidatosCL oCandidatosCl = new CandidatosCL();
                        frmVotar Votar = new frmVotar(oCandidatosCl.ObtenerCandidato());
                        Votar.Show();
                        valor = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ingresado ya ejercio su voto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (!valor)
            {
                MessageBox.Show("Usuario y clave erróneas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {//metodo que cierra el windows form
            this.Close();
        }
    }
}
