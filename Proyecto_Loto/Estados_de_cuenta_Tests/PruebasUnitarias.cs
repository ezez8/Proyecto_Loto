using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Loto;
using Proyecto_Loto.Clases;

namespace Estados_de_cuenta_Tests
{
    [TestClass]
    public class PruebasUnitarias
    {
        private Estados_de_cuenta edoCuentas;


        [TestInitialize]
        public void inicializar()
        {
           edoCuentas  = new Estados_de_cuenta();
        }

        [TestMethod]
        public void conectarBaseDatos_Valido()
        {
            var res = edoCuentas.conectarBaseDatos();
            Assert.AreEqual(res, "Se conecto la base de datos");
        }

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_UsuarioValido()
        {
            var res = edoCuentas.consultar_ganancias_apostador(0);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_UsuarioInvalido()
        {
            var res = edoCuentas.consultar_ganancias_apostador(100);
            Assert.Equals(res,new UsuarioInvalidoException());
        }
    }
}
