using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace ProyectoRaulTony.CapaLogica
{
    public class CandidatosCL
    {
        public bool IsError { set; get; }
        public string ErrorDescripcion { set; get; }

        public void AgregarCandidato(string partido, string nombre, string ruta)
        {
            IsError = false;
            ErrorDescripcion = null;

            if (string.IsNullOrWhiteSpace(partido) || string.IsNullOrWhiteSpace(nombre))
            {
                IsError = true;
                ErrorDescripcion = "El partido y el nombre del candidato son obligatorios.";
                return;
            }

            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();

            string folderName = DataStorageConfig.GetImagenesCandidatosDirectory();
            string fileName = DataStorageConfig.SanitizeFileName(partido) + ".jpg";
            string destFile = Path.Combine(folderName, fileName);

            try
            {
                if (!string.IsNullOrWhiteSpace(ruta) && File.Exists(ruta))
                {
                    if (!string.Equals(Path.GetFullPath(ruta), Path.GetFullPath(destFile), StringComparison.OrdinalIgnoreCase))
                    {
                        File.Copy(ruta, destFile, true);
                    }
                }
                else
                {
                    destFile = ruta ?? string.Empty;
                }

                accesoDatos.Escribir(nombre.Trim() + "#%" + partido.Trim() + "#%" + destFile);
            }
            catch (Exception ex)
            {
                IsError = true;
                ErrorDescripcion = ex.Message;
                return;
            }

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarCandidatos(string partido, string nombre, string ruta)
        {
            IsError = false;
            ErrorDescripcion = null;

            if (string.IsNullOrWhiteSpace(partido) || string.IsNullOrWhiteSpace(nombre))
            {
                IsError = true;
                ErrorDescripcion = "El partido y el nombre del candidato son obligatorios.";
                return;
            }

            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();

            string folderName = DataStorageConfig.GetImagenesCandidatosDirectory();
            string fileName = DataStorageConfig.SanitizeFileName(partido) + ".jpg";
            string destFile = Path.Combine(folderName, fileName);

            try
            {
                if (!string.IsNullOrWhiteSpace(ruta) && File.Exists(ruta))
                {
                    if (!string.Equals(Path.GetFullPath(ruta), Path.GetFullPath(destFile), StringComparison.OrdinalIgnoreCase))
                    {
                        File.Copy(ruta, destFile, true);
                    }
                }
                else
                {
                    destFile = ruta ?? string.Empty;
                }

                accesoDatos.Editar(partido.Trim(), nombre.Trim() + "#%" + partido.Trim() + "#%" + destFile);
            }
            catch (Exception ex)
            {
                IsError = true;
                ErrorDescripcion = ex.Message;
                return;
            }

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EliminarCandidatos(string partido)
        {
            IsError = false;
            ErrorDescripcion = null;

            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(partido);

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        private static Image LoadThumbnailSafe(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return null;
            }

            try
            {
                byte[] bytes = File.ReadAllBytes(path);
                using (MemoryStream ms = new MemoryStream(bytes))
                using (Image original = Image.FromStream(ms))
                {
                    Bitmap resized = new Bitmap(99, 104);
                    using (Graphics g = Graphics.FromImage(resized))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(original, 0, 0, 99, 104);
                    }
                    return resized;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Candidato> ObtenerCandidato()
        {
            IsError = false;
            ErrorDescripcion = null;
            List<Candidato> candidatos = new List<Candidato>();

            IAccesoDatos accesoDatos = new CandidatosAD();
            accesoDatos.conectar();
            string informacion = accesoDatos.Leer();

            string[] lineas = informacion.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] atributos = linea.Split(new[] { "#%" }, StringSplitOptions.None);
                if (atributos.Length < 2)
                {
                    continue;
                }

                string rutaImg = atributos.Length >= 3 ? atributos[2].Trim() : string.Empty;
                candidatos.Add(new Candidato
                {
                    Partidos = atributos[0].Trim(),
                    Candidatos = atributos[1].Trim(),
                    Imagen = LoadThumbnailSafe(rutaImg)
                });
            }

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

            return candidatos;
        }
    }
}
