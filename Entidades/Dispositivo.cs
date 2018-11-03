using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dispositivo
    {
        public string idDispositivo { get; set; }
        public int idPerimetro { get; set; }
        public string estado { get; set; }
        public string idAnimal { get; set; }
        public float bateria { get; set; }
        public DateTime fecha { get; set; }

    }
}
