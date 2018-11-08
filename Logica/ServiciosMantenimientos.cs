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
    }
}
