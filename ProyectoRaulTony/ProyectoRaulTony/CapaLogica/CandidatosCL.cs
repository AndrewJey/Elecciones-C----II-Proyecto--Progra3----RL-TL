using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRaulTony.CapaLogica
{
    public class CandidatosCL
    {
        //direccion de la carpeta de imagenes
        static string folderName = @Application.StartupPath + "\\Respaldo\\ImagenesCandidatos";

        public bool IsError
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
        //metodo que envia datos para que sean agregados
        public void AgregarCandidato(string partido,string nombre, string ruta)
        {
            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();
            string fileName = partido + ".jpg";
            accesoDatos.Escribir(nombre + "#%" + partido + "#%" + folderName + "\\" + fileName);
            string sourceFile = System.IO.Path.Combine(folderName, fileName);
            System.IO.File.Copy(ruta, sourceFile, false);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean editados
        public void EditarCandidatos(string partido,string nombre, string ruta)
        {
            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();
            string fileName = partido + ".jpg";
            accesoDatos.Editar(partido, nombre + "#%" + partido + "#%" + folderName + "\\" + fileName);
            string sourceFile = System.IO.Path.Combine(folderName, fileName);
            System.IO.File.Copy(ruta, sourceFile, true);
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean eliminados
        public void EliminarCandidatos(string partido)
        {
            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(partido);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que devuelve una lista de candidatos
        public List<Candidato> ObtenerCandidato()
        {
            List<Candidato> candidatos = new List<Candidato>();

            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();
            StringBuilder informacion = new StringBuilder(accesoDatos.Leer());
            PictureBox Imagen = new PictureBox();

            string[] lineas = informacion.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos = linea.Split(new string[] { "#%" }, StringSplitOptions.None);
                        Imagen.Image = System.Drawing.Image.FromFile(atributos[2]);
                        Bitmap b = new Bitmap(99, 104);
                        Graphics g = Graphics.FromImage((Image)b);
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(Imagen.Image, 0, 0, 99, 104);
                        Imagen.Image = (Image) b;
                        candidatos.Add(new Candidato()
                        {
                            Partidos = atributos[0],
                            Candidatos = atributos[1],
                            Imagen = Imagen.Image
                        });
                    }
                }
            }

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
            return candidatos;
        }
       
    }
}
