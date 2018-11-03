using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimientos
    {
        public int idMantenimiento { get; set; }
        public string idDispositivo { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public Char estadoMantenimiento { get; set; }
        public Char estadoDispositivo { get; set; }
        public Char estadoActual{ get; set; }
    }
}
