using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public int idfinca { get; set; }
        public string identificacion { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string rol { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public char estado { get; set; }
        public string imagen { get; set; }
        public string clave { get; set; }
    }
}
