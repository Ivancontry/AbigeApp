using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbigeApp
{
    [TestFixture]
    class ServicioMantenimientoTest
    {
        [Test]
        public void Test1() {
            Presentacion.RegistrarDispositivo registrarDispositivo = new Presentacion.RegistrarDispositivo;
            registrarDispositivo.validarBateria();
        }
            
    }
}
