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

        //      PRUEBAS DE ACIERTO

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
        public void consultar_perdidas_usuario_apostador_Valido()
        {
            var res = edoCuentas.consultar_perdidas_apostador(0);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_fecha_Valido()
        {
            var res = edoCuentas.consultar_ganancias_apostador_fecha(1,"2018-10-10");
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_apostador_fecha_Valido()
        {
            var res = edoCuentas.consultar_perdidas_apostador_fecha(1, "2018-10-10");
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_fecha_juego_Valido()
        {
            var res = edoCuentas.consultar_ganancias_apostador_fecha_juego(1, "2018-10-10",1);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_apostador_fecha_juego_Valido()
        {
            var res = edoCuentas.consultar_perdidas_apostador_fecha_juego(1, "2018-10-10", 1);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_normal_Valido()
        {
            var res = edoCuentas.consultar_ganancias_normal(1);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_normal_Valido()
        {
            var res = edoCuentas.consultar_perdidas_normal(1);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_normal_fecha_Valido()
        {
            var res = edoCuentas.consultar_ganancias_normal_fecha(1,"2000-10-02");
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_normal_fecha_Valido()
        {
            var res = edoCuentas.consultar_perdidas_normal_fecha(1, "2000-10-02");
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_normal_fecha_juego_Valido()
        {
            var res = edoCuentas.consultar_ganancias_normal_fecha_juego(1, "2000-10-02",1);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_normal_fecha_juego_Valido()
        {
            var res = edoCuentas.consultar_perdidas_normal_fecha_juego(1, "2000-10-02", 1);
            Assert.IsNotNull(res);
        }

        //      PRUEBAS DE FALLO

      /*  [TestMethod]
        public void consultar_ganancias_usuario_apostador_UsuarioInvalido()
        {
            var res = edoCuentas.consultar_ganancias_apostador(100);
            Assert.Equals(res,new UsuarioInvalidoException());
        }*/
    }
}
