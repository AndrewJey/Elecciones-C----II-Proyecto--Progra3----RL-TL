using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoRaulTony.CapaVista;
using ProyectoRaulTony.CapaLogica;
using System.IO;
using System.IO.Compression;
using ProyectoRaulTony.estructura;

namespace ProyectoRaulTony
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void votantesToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que crea una instancia y llama un windows form
            frmVotantes votantes = new frmVotantes();
            votantes.Show();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que crea una instancia y llama un windows form
            frmCandidatos candidatos = new frmCandidatos();
            candidatos.Show();
        }
        private void btbReiniciaVotaciones_Click(object sender, EventArgs e)
        {//metodo que reinicia las botaciones, dejando a los candidatos sin votos
            VotacionesCL oVotacionesVl = new VotacionesCL();
            List<Votacion> votos = oVotacionesVl.ObtenerVotaciones();
            for (int i = 0; i < votos.Count; i++)
            {
                oVotacionesVl.EliminarVotaciones(votos[i].Id);
            }
            oVotacionesVl.EliminarVotaciones(@Application.StartupPath + "\\Votos.txt");
        }

        private void btbReturnLogin_Click(object sender, EventArgs e)
        {//metodo que regresa al usuario al login
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btbGrafico_Click(object sender, EventArgs e)
        {//metodo que crea una instancia y llama un windows form que muestra un grafico
            frmGrafico Grafico = new frmGrafico();
            Grafico.Show();
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que crea una instancia y llama un windows form
            frmPeriodo Periodo = new frmPeriodo();
            Periodo.Show();
        }

        private void crearRespaldoToolStripMenuItem1_Click(object sender, EventArgs e)
        {//metodo que llama a otro metodo
            Exportar();
        }

        private void importarRespaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {//metodo que llama a otro metodo
            Importar();
        }
        public void Exportar()
        {//metodo que sirve para pedir al usuario un destino y exportar la base de datos del programa
            string[] archivos = Directory.GetFiles(@Application.StartupPath + "\\Respaldo\\", "*.txt");
            string[] imagenes = Directory.GetFiles(@Application.StartupPath + "\\Respaldo\\ImagenesCandidatos\\", "*.jp*");
            FolderBrowserDialog Guardar = new FolderBrowserDialog();
            Guardar.Description = "Selecione la carpeta de destino para el respaldo";
            DialogResult buscar = Guardar.ShowDialog();

            if (buscar == DialogResult.OK)
            {
                string folderName1 = Guardar.SelectedPath + "\\Respaldo\\ImagenesCandidatos\\";
                string folderName2 = Guardar.SelectedPath + "\\Respaldo\\";
                try
                {
                    if (!System.IO.Directory.Exists(folderName1))
                    {
                        System.IO.Directory.CreateDirectory(folderName1);
                    }
                    if (!System.IO.Directory.Exists(folderName2))
                    {
                        System.IO.Directory.CreateDirectory(folderName2);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Los ficheros ya existen", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                for (int x = 0; x < archivos.Length; x++)
                {
                    string[] nombreArchivo = archivos[x].Split('\\');
                    int cont = nombreArchivo.Length - 1;
                    File.Copy(archivos[x], folderName2 + nombreArchivo[cont], true);
                }
                for (int y = 0; y < imagenes.Length; y++)
                {
                    string[] nombreArchivo = imagenes[y].Split('\\');
                    int cont = nombreArchivo.Length - 1;
                    File.Copy(imagenes[y], folderName1 + nombreArchivo[cont], true);
                }
                MessageBox.Show("Archivos respaldados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Importar()
        {//metodo que sirve para pedir al usuario un destino e importar la base de datos del programa
            FolderBrowserDialog Guardar = new FolderBrowserDialog();
            Guardar.Description = "Selecione la carpeta de destino para el respaldo";
            DialogResult buscar = Guardar.ShowDialog();
            if (buscar == DialogResult.OK)
            {
                string[] archivos = Directory.GetFiles(Guardar.SelectedPath, "*.txt");
                string[] imagenes = Directory.GetFiles(Guardar.SelectedPath + "\\ImagenesCandidatos\\", "*.jp*");
                string folderName1 = @Application.StartupPath + "\\Respaldo\\ImagenesCandidatos\\";
                string folderName2 = @Application.StartupPath + "\\Respaldo\\";
                try
                {
                    if (!System.IO.Directory.Exists(folderName1))
                    {
                        System.IO.Directory.CreateDirectory(folderName1);
                    }
                    if (!System.IO.Directory.Exists(folderName2))
                    {
                        System.IO.Directory.CreateDirectory(folderName2);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Los ficheros ya existen, eliminelos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                for (int x = 0; x < archivos.Length; x++)
                {
                    string[] nombreArchivo = archivos[x].Split('\\');
                    int cont = nombreArchivo.Length - 1;
                    File.Copy(archivos[x], folderName2 + nombreArchivo[cont], true);
                }
                for (int y = 0; y < imagenes.Length; y++)
                {
                    string[] nombreArchivo = imagenes[y].Split('\\');
                    int cont = nombreArchivo.Length - 1;
                    File.Copy(imagenes[y], folderName1 + nombreArchivo[cont], true);
                }
                MessageBox.Show("Archivos respaldados con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
