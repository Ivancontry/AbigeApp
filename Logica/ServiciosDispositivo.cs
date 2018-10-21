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
        public int registraPosicionActual(Dispositivos posicion) {            
            return datosDispositivo.registrarPosicionActual(posicion);
        }
        public DataTable listadoPosicionDispositivo() {
            return datosDispositivo.listadoPosicionDispositivo();
        }
    }
}
