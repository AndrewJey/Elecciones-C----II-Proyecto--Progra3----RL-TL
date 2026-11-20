using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;

namespace ProyectoRaulTony.CapaLogica
{
    public class VotacionesCL
    {
        public bool IsError { set; get; }
        public string ErrorDescripcion { set; get; }

        public void AgregarVotaciones(string id, string valor)
        {
            IsError = false;
            ErrorDescripcion = null;

            int parsedVote;
            if (string.IsNullOrWhiteSpace(id) || !int.TryParse((valor ?? string.Empty).Trim(), out parsedVote))
            {
                IsError = true;
                ErrorDescripcion = "El identificador y el valor numérico del voto son obligatorios.";
                return;
            }

            IAccesoDatos accesoDatos = new VotacionesAD();
            accesoDatos.conectar();
            accesoDatos.Escribir(id.Trim() + " " + parsedVote);

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EliminarVotaciones(string id)
        {
            IsError = false;
            ErrorDescripcion = null;

            IAccesoDatos accesoDatos = new VotacionesAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public List<Votacion> ObtenerVotaciones()
        {
            IsError = false;
            ErrorDescripcion = null;
            List<Votacion> votaciones = new List<Votacion>();

            IAccesoDatos accesoDatos = new VotacionesAD();
            accesoDatos.conectar();
            string informacion = accesoDatos.Leer();
            string[] lineas = informacion.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] atributos = linea.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int voto;
                if (atributos.Length < 2 || !int.TryParse(atributos[1], out voto))
                {
                    continue;
                }

                votaciones.Add(new Votacion
                {
                    Id = atributos[0].Trim(),
                    Voto = voto
                });
            }

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

            return votaciones;
        }
    }
}
