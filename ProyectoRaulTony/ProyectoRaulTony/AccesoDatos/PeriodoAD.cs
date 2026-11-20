using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoRaulTony.AccesoDatos
{
    public class PeriodoAD : IAccesoDatos
    {
        private string Ruta => Path.Combine(DataStorageConfig.GetRespaldoDirectory(), "Periodo.txt");
        private string FolderRespaldo => DataStorageConfig.GetRespaldoDirectory();

        public void conectar()
        {
            try
            {
                Directory.CreateDirectory(FolderRespaldo);
                if (!File.Exists(Ruta))
                {
                    File.WriteAllText(Ruta, string.Empty, Encoding.UTF8);
                }
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        public void Escribir(string hilera)
        {
            try
            {
                this.conectar();
                using (StreamWriter sw = new StreamWriter(Ruta, true, Encoding.UTF8))
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

        public string Leer()
        {
            StringBuilder resultado = new StringBuilder();
            try
            {
                this.conectar();
                using (StreamReader sr = new StreamReader(Ruta, Encoding.UTF8))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        resultado.AppendLine(linea);
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

        private static bool MatchesRecordId(string linea, string id)
        {
            if (string.IsNullOrWhiteSpace(linea) || string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            string target = id.Trim();
            if (linea.Contains("#%"))
            {
                string firstPipe = linea.Split(new[] { "#%" }, StringSplitOptions.None)[0].Trim();
                return string.Equals(firstPipe, target, StringComparison.OrdinalIgnoreCase);
            }

            string[] tokens = linea.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tokens.Length > 0 && string.Equals(tokens[0].Trim(), target, StringComparison.OrdinalIgnoreCase);
        }

        public void Editar(string id, string modificar)
        {
            try
            {
                this.conectar();
                List<string> lines = new List<string>(File.ReadAllLines(Ruta, Encoding.UTF8));
                for (int i = 0; i < lines.Count; i++)
                {
                    if (MatchesRecordId(lines[i], id))
                    {
                        lines[i] = modificar;
                    }
                }
                File.WriteAllLines(Ruta, lines, Encoding.UTF8);
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        public void Eliminar(string id)
        {
            try
            {
                this.conectar();
                List<string> kept = new List<string>();
                foreach (string linea in File.ReadAllLines(Ruta, Encoding.UTF8))
                {
                    if (!MatchesRecordId(linea, id))
                    {
                        kept.Add(linea);
                    }
                }
                File.WriteAllLines(Ruta, kept, Encoding.UTF8);
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        public bool IsError { set; get; }
        public string ErrorDescripcion { set; get; }
    }
}
