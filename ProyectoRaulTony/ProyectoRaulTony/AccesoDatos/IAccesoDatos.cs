using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRaulTony.AccesoDatos
{
    public interface IAccesoDatos
    {
        //atributos de la clase padre
        void conectar();

        void Escribir(string hilera);

        string Leer();

        void Editar(string id, string modificar);

        void Eliminar(string id);

        bool IsError { set; get; }

        string ErrorDescripcion { set; get; }

    }
}
