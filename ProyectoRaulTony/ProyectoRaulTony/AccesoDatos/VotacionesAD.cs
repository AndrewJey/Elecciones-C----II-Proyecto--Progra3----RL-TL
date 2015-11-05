using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRaulTony.AccesoDatos
{
    public class VotacionesAD : IAccesoDatos
    {
        //crea el archivo txt donde se guardan los datos
        string ruta = @Application.StartupPath + "\\Respaldo" + "/Votos.txt";
        string folderName = @Application.StartupPath + "\\Respaldo";

        #region Medotos de la Clase padre

        //metodo para conectarse con el archivo txt anteriormente creado
        public void conectar()
        {
            try
            {
                if (!System.IO.Directory.Exists(folderName))
                {
                    System.IO.Directory.CreateDirectory(folderName);
                }
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }

            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        //medoto para ingresar o escribir datos en el archivo txt
        public void Escribir(string hilera)
        {
            try
            {
                this.conectar();
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(hilera);
                }
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }
        public void Editar(string id, string modificar)
        {

        }
        //metodo que lee los datos guardados en el archivo txt
        public string Leer()
        {
            StringBuilder resultado = new StringBuilder();

            try
            {
                this.conectar();

                using (StreamReader sr = new StreamReader(ruta))
                {
                    while (sr.Peek() >= 0)
                    {
                        resultado.AppendLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
            return resultado.ToString();
        }

        //metodo que elimina datos del archivo txt
        public void Eliminar(string ruta)
        {
            try
            {
                File.Delete(ruta);
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

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
        #endregion
    }
}
