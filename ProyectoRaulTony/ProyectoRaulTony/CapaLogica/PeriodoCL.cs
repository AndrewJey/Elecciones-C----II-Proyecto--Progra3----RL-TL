using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;

namespace ProyectoRaulTony.CapaLogica
{
    public class PeriodoCL
    {
        public bool IsError { set; get; }
        public string ErrorDescripcion { set; get; }

        public void CrearPeriodo(string fecha, string horaInicio, string horafinal, string estado)
        {
            IsError = false;
            ErrorDescripcion = null;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(horaInicio) || string.IsNullOrWhiteSpace(horafinal))
            {
                IsError = true;
                ErrorDescripcion = "La fecha y las horas de inicio y fin son obligatorias.";
                return;
            }

            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            string id = Guid.NewGuid().ToString("N").Substring(0, 10);
            accesoDatos.Escribir(string.Join("#%", id, fecha.Trim(), horaInicio.Trim(), horafinal.Trim(), (estado ?? string.Empty).Trim()));

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarPeriodo(string id, string fecha, string horaInicio, string horafinal, string estado)
        {
            IsError = false;
            ErrorDescripcion = null;

            if (string.IsNullOrWhiteSpace(id))
            {
                IsError = true;
                ErrorDescripcion = "El identificador del periodo es obligatorio.";
                return;
            }

            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            accesoDatos.Editar(id.Trim(), string.Join("#%", id.Trim(), (fecha ?? string.Empty).Trim(), (horaInicio ?? string.Empty).Trim(), (horafinal ?? string.Empty).Trim(), (estado ?? string.Empty).Trim()));

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EliminarPeriodo(string id)
        {
            IsError = false;
            ErrorDescripcion = null;

            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public List<Periodo> ObtenerPeriodo()
        {
            IsError = false;
            ErrorDescripcion = null;
            List<Periodo> periodos = new List<Periodo>();

            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            string informacion = accesoDatos.Leer();
            string[] lineas = informacion.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                if (linea.Contains("#%"))
                {
                    string[] partes = linea.Split(new[] { "#%" }, StringSplitOptions.None);
                    if (partes.Length >= 5)
                    {
                        periodos.Add(new Periodo
                        {
                            id = partes[0].Trim(),
                            fecha = partes[1].Trim(),
                            horaInicio = partes[2].Trim(),
                            horaFinal = partes[3].Trim(),
                            estado = partes[4].Trim()
                        });
                    }
                    continue;
                }

                string[] atributos = linea.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (atributos.Length >= 12)
                {
                    periodos.Add(new Periodo
                    {
                        id = atributos[0],
                        fecha = string.Join(" ", atributos[1], atributos[2], atributos[3], atributos[4], atributos[5], atributos[6]),
                        horaInicio = atributos[7] + " " + atributos[8],
                        horaFinal = atributos[9] + " " + atributos[10],
                        estado = atributos[11]
                    });
                }
                else if (atributos.Length >= 5)
                {
                    periodos.Add(new Periodo
                    {
                        id = atributos[0],
                        fecha = atributos[1],
                        horaInicio = atributos[2],
                        horaFinal = atributos[3],
                        estado = atributos[4]
                    });
                }
            }

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

            return periodos;
        }
    }
}
