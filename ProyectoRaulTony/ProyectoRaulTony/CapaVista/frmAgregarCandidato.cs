using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using ProyectoRaulTony.CapaLogica;

namespace ProyectoRaulTony
{
    public partial class frmAgregarCandidato : Form
    {
        public frmAgregarCandidato()
        {
            InitializeComponent();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //botom que envia datos para que sean agregados
            CandidatosCL oCandidatoCL = new CandidatosCL();
            oCandidatoCL.AgregarCandidato(txtPartido.Text, txtCandidato.Text, ruta());
            if (oCandidatoCL.IsError)
            {
                MessageBox.Show(oCandidatoCL.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Candidato agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtPartido.ResetText();
            txtCandidato.ResetText();
            this.Close();
        }


        public string ruta()
        {
            //metodo que sirve para obtener la ruta en donde se encuentra la imagen
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
        {
            //botom para salir
            this.Close();
        }
    }
}
