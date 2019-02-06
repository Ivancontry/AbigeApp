using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimientos
    {
        private int idMantenimiento;
        private string idDispositivo;
        private DateTime fecha;
        private string descripcion;
        private Char estadoMantenimiento;
        private Char estadoDispositivo;
        private Char estadoActual;

        public int IdMantenimiento { get => idMantenimiento; set => idMantenimiento = value; }
        public string IdDispositivo { get => idDispositivo; set => idDispositivo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Char EstadoMantenimiento { get => estadoMantenimiento; set => estadoMantenimiento = value; }
        public Char EstadoDispositivo { get => estadoDispositivo; set => estadoDispositivo = value; }
        public Char EstadoActual{ get => estadoActual; set => estadoActual = value; }
    }
}
