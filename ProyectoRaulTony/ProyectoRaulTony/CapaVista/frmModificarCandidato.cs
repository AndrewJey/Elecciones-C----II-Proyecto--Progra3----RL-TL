using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoRaulTony.CapaLogica;
using ProyectoRaulTony.estructura;

namespace ProyectoRaulTony
{
    public partial class frmModificarCandidato : Form
    {
        public frmModificarCandidato(Candidato candidato)
        {
            //se resiben datos por parametros para que sean definidos
            InitializeComponent();
            txtCandidato.Text = candidato.Candidatos;
            txtPartido.Text = candidato.Partidos;
            picPartido.Image = candidato.Imagen;
        }
        public frmModificarCandidato()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {//metodo que envia datos para que se editen
            CandidatosCL oCandidatoCL = new CandidatosCL();
            oCandidatoCL.EditarCandidatos(txtPartido.Text, txtCandidato.Text, ruta());
            
            if (oCandidatoCL.IsError)
            {
                MessageBox.Show(oCandidatoCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Candidato modificado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtPartido.ResetText();
            txtCandidato.ResetText();
            this.Close();
        }
        public string ruta()
        {//metodo que pide al usuario una ruta de la imagen elegida
            string ruta = "";
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {

                String Direccion = BuscarImagen.FileName;
                this.picPartido.ImageLocation = Direccion;
                picPartido.SizeMode = PictureBoxSizeMode.StretchImage;
                ruta = Direccion;
            }
            return ruta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {//metodo que cierra el windows form
            this.Close();
        }

    }
}
