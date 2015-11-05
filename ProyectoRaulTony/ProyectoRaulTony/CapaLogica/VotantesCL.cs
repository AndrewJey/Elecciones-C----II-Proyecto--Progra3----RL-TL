using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRaulTony.CapaLogica
{
    public class VotantesCL
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
        public void AgregarVotantes(string cedula, string contraseña)
        {
            IAccesoDatos accesoDatos = new VotantesAD();
            accesoDatos.conectar();
            accesoDatos.Escribir(cedula + " " + contraseña + "0");

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean editados
        public void EditarVotantes(string id, string contraseña)
        {
            IAccesoDatos accesoDatos = new VotantesAD();
            accesoDatos.conectar();
            accesoDatos.Editar(id, id + " " + contraseña);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que envia datos para que sean eliminados
        public void EliminarVotantes(string id)
        {
            IAccesoDatos accesoDatos = new VotantesAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        //metodo que devuelve una lista de votantes
        public List<Votante> ObtenerVotante()
        {
            List<Votante> votantes = new List<Votante>();

            IAccesoDatos accesoDatos = new VotantesAD();
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

                        votantes.Add(new Votante()
                        {
                            Usuario = atributos[0],
                            Contraseña = atributos[1],
                        });
                    }
                }
            }
            if (accesoDatos.IsError)
            {
                this.IsError = true;
                this.ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
            return votantes;
        }
    }
}
