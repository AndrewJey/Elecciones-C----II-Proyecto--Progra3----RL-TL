using ProyectoRaulTony.AccesoDatos;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoRaulTony.CapaLogica
{
    public class VotantesCL
    {
        public bool IsError { set; get; }
        public string ErrorDescripcion { set; get; }

        public void AgregarVotantes(string cedula, string contraseña)
        {
            IsError = false;
            ErrorDescripcion = null;

            string ced = (cedula ?? string.Empty).Trim();
            string pwd = (contraseña ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(ced) || string.IsNullOrEmpty(pwd))
            {
                IsError = true;
                ErrorDescripcion = "La cédula y la contraseña del votante son obligatorias.";
                return;
            }

            if (ObtenerVotante().Any(v => string.Equals(v.Usuario, ced, StringComparison.OrdinalIgnoreCase)))
            {
                IsError = true;
                ErrorDescripcion = "Ya existe un votante registrado con esa cédula.";
                return;
            }

            IAccesoDatos accesoDatos = new VotantesAD();
            accesoDatos.conectar();
            accesoDatos.Escribir(ced + " " + pwd + " 0");

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EditarVotantes(string id, string contraseña)
        {
            IsError = false;
            ErrorDescripcion = null;

            string ced = (id ?? string.Empty).Trim();
            string pwd = (contraseña ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(ced) || string.IsNullOrEmpty(pwd))
            {
                IsError = true;
                ErrorDescripcion = "La cédula y la contraseña son obligatorias.";
                return;
            }

            IAccesoDatos accesoDatos = new VotantesAD();
            accesoDatos.conectar();
            accesoDatos.Editar(ced, ced + " " + pwd + " 0");

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public void EliminarVotantes(string id)
        {
            IsError = false;
            ErrorDescripcion = null;

            IAccesoDatos accesoDatos = new VotantesAD();
            accesoDatos.conectar();
            accesoDatos.Eliminar(id);

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }

        public List<Votante> ObtenerVotante()
        {
            IsError = false;
            ErrorDescripcion = null;
            List<Votante> votantes = new List<Votante>();

            IAccesoDatos accesoDatos = new VotantesAD();
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
                if (atributos.Length < 2)
                {
                    continue;
                }

                votantes.Add(new Votante
                {
                    Usuario = atributos[0].Trim(),
                    Contraseña = atributos[1].Trim()
                });
            }

            if (accesoDatos.IsError)
            {
                IsError = true;
                ErrorDescripcion = accesoDatos.ErrorDescripcion;
            }

            return votantes;
        }
    }
}
