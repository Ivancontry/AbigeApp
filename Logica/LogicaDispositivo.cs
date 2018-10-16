using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    
    public class LogicaDispositivo
    {
        DatosDispositivo datosDispositivo = new DatosDispositivo();
        public int registraPosicionActual(Posicion posicion) {            
            return datosDispositivo.registrarPosicionActual(posicion);
        }
       
    }
}
