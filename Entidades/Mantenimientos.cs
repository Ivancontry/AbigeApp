using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimientos
    {
        private string idDispositivo;
        private DateTime fecha;
        private string descripcion;
        private Char estadoMantenimiento;
        private Char estadoActual;

        public string IdDispositivo
        {
            get { return idDispositivo; }
            set
            {
                if (validarIdDispositivo(value))
                {
                    idDispositivo = value;
                }
            }
        }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (validarDescripcion(value))
                {
                    descripcion = value;
                }
            }
        }
        public Char EstadoMantenimiento { get => estadoMantenimiento; set => estadoMantenimiento = value; }
        public Char EstadoActual{ get => estadoActual; set => estadoActual = value; }

        public bool validarIdDispositivo(string codigo)
        {
            return (!codigo.Equals("") && codigo.Length >= 5 && codigo.Length <= 10);

        }

        public bool validarDescripcion(string codigo)
        {
            if (!codigo.Equals("") && codigo.Length >= 5 && codigo.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
