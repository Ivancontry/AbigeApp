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
            get { return IdDispositivo; }
            set
            {
                if (!idDispositivo.Equals("") && idDispositivo.Length >= 5 && idDispositivo.Length <= 10)
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
                if (!descripcion.Equals("") && descripcion.Length >= 5 && descripcion.Length <= 10)
                {
                    descripcion = value;
                }
            }
        }
        public Char EstadoMantenimiento { get => estadoMantenimiento; set => estadoMantenimiento = value; }
        public Char EstadoActual{ get => estadoActual; set => estadoActual = value; }
    }
}
