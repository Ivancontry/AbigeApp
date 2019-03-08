using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion;

namespace TestAbigeApp
{
    [TestFixture]
    class DispositivoTest
    {
        [Test]
        public void Test1()
        {
            RegistrarDispositivo dispositivo = new RegistrarDispositivo();
            // Arrange/Act
            int resultado = dispositivo.validarIdDispositivo("123");

            //// Assert
            Assert.That(resultado, Is.EqualTo("-1"));
            
        }
    }
}
