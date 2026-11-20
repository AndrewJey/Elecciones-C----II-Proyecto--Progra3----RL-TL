using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoRaulTony.AccesoDatos
{
    public interface IAccesoDatos
    {
        void conectar();

        void Escribir(string hilera);

        string Leer();

        void Editar(string id, string modificar);

        void Eliminar(string id);

        bool IsError { set; get; }

        string ErrorDescripcion { set; get; }
    }

    public static class DataStorageConfig
    {
        public static string GetRespaldoDirectory()
        {
            string envDir = Environment.GetEnvironmentVariable("ELECCIONES_DATA_DIR");
            if (!string.IsNullOrWhiteSpace(envDir))
            {
                return envDir.Trim();
            }

            return Path.Combine(Application.StartupPath, "Respaldo");
        }

        public static string GetImagenesCandidatosDirectory()
        {
            return Path.Combine(GetRespaldoDirectory(), "ImagenesCandidatos");
        }

        public static string SanitizeFileName(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
            {
                return "candidato";
            }

            char[] invalid = Path.GetInvalidFileNameChars();
            string cleaned = raw.Trim();
            foreach (char c in invalid)
            {
                cleaned = cleaned.Replace(c, '_');
            }
            return string.IsNullOrWhiteSpace(cleaned) ? "candidato" : cleaned;
        }
    }
}
