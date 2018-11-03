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
    
    public class ServiciosDispositivo
    {
        RepositorioDispositivos datosDispositivo = new RepositorioDispositivos();
        RepositorioMantenimientos datosMantenimientos = new RepositorioMantenimientos();

        public int registrarDispositivo(Dispositivo dispositivo)
        {
            return datosDispositivo.registrarDispositivo(dispositivo);
        }
        public int actulizarDispositivo(Dispositivo dispositivo)
        {
            return datosDispositivo.actualizarDispositivo(dispositivo);
        }
        public int registraPosicionActual(Posicion posicion) {            
            return datosDispositivo.registrarPosicionActual(posicion);
        }
        public DataTable listadoPosicionDispositivo() {
            return datosDispositivo.listadoPosicionDispositivo();
        }

        public DataTable buscarDispositvo(string idDispositivo)
        {
            return datosMantenimientos.buscarDispoitivo(idDispositivo);
        }

        public DataTable listadoPerimetros()
        {
            return datosDispositivo.listadoPerimetros();
        }

        public DataTable listadoCoordenadasPerimetro(int idPerimetro)
        {
            return datosDispositivo.listadoCoordenadasPerimetro(idPerimetro);
        }


    }
}
