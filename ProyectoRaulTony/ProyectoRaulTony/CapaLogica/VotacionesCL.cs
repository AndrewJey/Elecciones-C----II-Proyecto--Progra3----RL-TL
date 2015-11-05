using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRaulTony.CapaLogica
{
    public class VotacionesCL
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
        public void AgregarVotaciones(string id, string valor)
        {
            IAccesoDatos accesoDatos = new VotacionesAD();
            accesoDatos.conectar();
            accesoDatos.Escribir(id + " " + valor);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean eliminados
        public void EliminarVotaciones(string id)
        {
            IAccesoDatos accesoDatos = new VotacionesAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que devuelve una lista de votos
        public List<Votacion> ObtenerVotaciones()
        {
            List<Votacion> Votacion = new List<Votacion>();

            IAccesoDatos accesoDatos = new VotacionesAD();
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

                        Votacion.Add(new Votacion()
                        {
                            Id = atributos[0],
                            Voto = Convert.ToInt32(atributos[1])
                        });
                    }
                }
            }
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
            return Votacion;
        }
    }
}
