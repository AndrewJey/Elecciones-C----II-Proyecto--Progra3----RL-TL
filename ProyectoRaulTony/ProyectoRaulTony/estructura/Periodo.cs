using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRaulTony.estructura
{
    public struct Periodo
    {//estructuda de periodo con sus atributos
        public string id { set; get; }
        public string fecha { set; get; }
        public string horaInicio { set; get; }
        public string horaFinal { set; get; }
        public string estado { set; get; }
    }
}
