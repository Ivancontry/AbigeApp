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
                if (validarIdDispositivo())
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
                if (validarDescripcion())
                {
                    descripcion = value;
                }
            }
        }
        public Char EstadoMantenimiento { get => estadoMantenimiento; set => estadoMantenimiento = value; }
        public Char EstadoActual{ get => estadoActual; set => estadoActual = value; }

        public bool validarIdDispositivo()
        {
            if (!idDispositivo.Equals("") && idDispositivo.Length >= 5 && idDispositivo.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarDescripcion()
        {
            if (!descripcion.Equals("") && descripcion.Length >= 5 && descripcion.Length <= 10)
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
