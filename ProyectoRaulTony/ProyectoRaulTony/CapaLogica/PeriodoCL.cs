using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRaulTony.CapaLogica
{

    public class PeriodoCL
    {
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
        public void CrearPeriodo(string fecha, string horaInicio, string horafinal, string estado)
        {
            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            accesoDatos.Escribir(Guid.NewGuid().ToString().Substring(0, 10) + " " + fecha + " " + horaInicio + " " + horafinal + " " + estado);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean editados
        public void EditarPeriodo(string id, string fecha, string horaInicio, string horafinal, string estado)
        {
            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            accesoDatos.Editar(id, id + " " + fecha + " " + horaInicio + " " + horafinal + " " + estado);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean eliminados
        public void EliminarPeriodo(string id)
        {
            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que devuelve una lista de periodos
        public List<Periodo> ObtenerPeriodo()
        {
            List<Periodo> periodo = new List<Periodo>();

            IAccesoDatos accesoDatos = new PeriodoAD();
            accesoDatos.conectar();
            StringBuilder informacion = new StringBuilder(accesoDatos.Leer());

            string[] lineas = informacion.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            if (lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos = linea.Split(new string[] { " " }, StringSplitOptions.None);

                        periodo.Add(new Periodo()
                        {
                            id = atributos[0],
                            fecha = atributos[1] + " " + atributos[2] + " " + atributos[3] + " " + atributos[4] + " " + atributos[5] + " " + atributos[6],
                            horaInicio = atributos[7] + " " + atributos[8],
                            horaFinal = atributos[9] + " " + atributos[10],
                            estado = atributos[11],
                        });
                    }
                }
            }
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
            return periodo;
        }
    }
}
