using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestUnitarios
{
    [TestClass]
    public class TestTP04
    {
        [TestMethod]
        public void Test_VentasGuardarXml()
        {
            Ventas v = new Ventas(200, 200);
            bool retorno = Ventas.GuardarXml(v);

            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void Test_ValidarCantidad()
        {
            bool ret = Hardcodeo.ValidarCantidad("Leche", 200);

            Assert.IsFalse(ret);
        }

    }
}
