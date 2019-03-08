using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbigeApp
{
    [TestFixture]
    class DispositivoTest
    {
        [Test]
        public void Test1()
        {
            Entidades.Dispositivo dispositivo = new Entidades.Dispositivo();
            // Arrange/Act
            //Boolean resultado = dispositivo.validarIdDispositivo();

            //// Assert
            //Assert.That(resultado, Is.EqualTo("Unit Testing"));
        }
    }
}
