using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        private int idUsuario;
        private int idfinca;
        private string identificacion;
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private string rol;
        private string email;
        private string telefono;
        private string direccion;
        private char estado;
        private string imagen;
        private string clave;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Idfinca { get => idfinca; set => idfinca = value; }
        public string Identificacion { get => identificacion; set => identificacion= value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public char Estado { get => estado; set => estado = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Clave
        {
            get { return clave; }
            set
            {
                if (!clave.Equals("") && clave.Length >= 6 && clave.Length <= 20)
                {
                    clave = value;
                }
            }
        }
    }
}
