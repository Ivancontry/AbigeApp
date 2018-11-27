using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class ServiciosMantenimientos
    {
        RepositorioMantenimientos datosMantenimientos = new RepositorioMantenimientos();
        public int registraMantenimiento(Mantenimientos mantenientos)
        {
            return datosMantenimientos.registrarMantenimientos(mantenientos);
        }
        public int actualizarMantenimiento(Mantenimientos mantenientos)
        {
            return datosMantenimientos.actualizarMantenimientos(mantenientos);
        }
        public DataTable mostrarMantenimientos() {
            return datosMantenimientos.mostrarMantenimientos();
        }
        public DataTable buscarDispositvoMantenientos(string idDispositivo) {
            return datosMantenimientos.buscarDispoitivoMantenimiento(idDispositivo);
        }
        public DataTable buscarDispositvo(string idDispositivo)
        {
            return datosMantenimientos.buscarDispoitivo(idDispositivo);
        }
        public DataTable topMantenimientos(int limite, DateTime fecha1, DateTime fecha2) {
            return datosMantenimientos.topMantenimientos(limite, fecha1, fecha2);
                 
        }
        public DataTable buscarHistorialDispositvoMantenimiento(string idDispositivo)
        {
            return datosMantenimientos.buscarHistorialDispositvoMantenimiento(idDispositivo);
        }
    }
}
