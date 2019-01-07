using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Loto;
using Proyecto_Loto.Clases;
using Proyecto_Loto.Exceptions;

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
            string res = edoCuentas.conectarBaseDatos();
            Assert.AreEqual(res, "Se conecto la base de datos");
        }

        //////////Usuario Apostador////////////

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_Valido()
        {
            float res = edoCuentas.consultar_ganancias_apostador(1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_apostador_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_apostador(-1);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_apostador_Valido()
        {
            float res = edoCuentas.consultar_perdidas_apostador(1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_apostador_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_apostador(-1);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_fecha_Valido()
        {
            float res = edoCuentas.consultar_ganancias_apostador_fecha(1,"1997-01-01");
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_apostador_fecha_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_apostador_fecha(-1, "1997-01-01");
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_ganancias_usuario_apostador_fecha_FechaInvalida()
        {
            edoCuentas.consultar_ganancias_apostador_fecha(1, "3000-01-01");
        }

        [TestMethod]
        public void consultar_perdidas_usuario_apostador_fecha_Valido()
        {
            float res = edoCuentas.consultar_perdidas_apostador_fecha(1, "1997-01-01");
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_apostador_fecha_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_apostador_fecha(-1, "1997-01-01");
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_perdidas_usuario_apostador_fecha_FechaInvalida()
        {
            edoCuentas.consultar_perdidas_apostador_fecha(1, "3000-01-01");
        }

        [TestMethod]
        public void consultar_ganancias_apostador_juego_Valido()
        {
            float res = edoCuentas.consultar_ganancias_apostador_juego(1, 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_apostador_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_apostador_juego(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_ganancias_apostador_juego_JuegoInvalido()
        {
            edoCuentas.consultar_ganancias_apostador_juego(1, -1);
        }

        [TestMethod]
        public void consultar_perdidas_apostador_juego_Valido()
        {
            float res = edoCuentas.consultar_perdidas_apostador_juego(1, 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_apostador_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_apostador_juego(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_perdidas_apostador_juego_JuegoInvalido()
        {
            edoCuentas.consultar_perdidas_apostador_juego(1, -1);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_apostador_fecha_juego_Valido()
        {
            float res = edoCuentas.consultar_ganancias_apostador_fecha_juego(1, "1997-01-01", 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_apostador_fecha_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_apostador_fecha_juego(-1, "1997-01-01", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_ganancias_usuario_apostador_fecha_juego_FechaInvalida()
        {
            edoCuentas.consultar_ganancias_apostador_fecha_juego(1, "3000-01-01", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_ganancias_usuario_apostador_fecha_juego_JuegoInvalido()
        {
            edoCuentas.consultar_ganancias_apostador_fecha_juego(1, "1997-01-01", -1);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_apostador_fecha_juego_Valido()
        {
            float res = edoCuentas.consultar_perdidas_apostador_fecha_juego(1, "1997-01-01", 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_apostador_fecha_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_apostador_fecha_juego(-1, "1997-01-01", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_perdidas_usuario_apostador_fecha_juego_FechaInvalida()
        {
            edoCuentas.consultar_perdidas_apostador_fecha_juego(1, "3000-01-01", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_perdidas_usuario_apostador_fecha_juego_JuegoInvalido()
        {
            edoCuentas.consultar_perdidas_apostador_fecha_juego(1, "1997-01-01", -1);
        }

        ///////Usuario Normal////////

        [TestMethod]
        public void consultar_ganancias_usuario_normal_Valido()
        {
            float res = edoCuentas.consultar_ganancias_normal(1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_normal_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_normal(-1);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_normal_Valido()
        {
            float res = edoCuentas.consultar_perdidas_normal(1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_normal_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_normal(-1);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_normal_fecha_Valido()
        {
            float res = edoCuentas.consultar_ganancias_normal_fecha(1,"2000-10-02");
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_normal_fecha_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_normal_fecha(-1, "1997-01-01");
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_ganancias_usuario_normal_fecha_FechaInvalida()
        {
            edoCuentas.consultar_ganancias_normal_fecha(1, "3000-01-01");
        }

        [TestMethod]
        public void consultar_perdidas_usuario_normal_fecha_Valido()
        {
            float res = edoCuentas.consultar_perdidas_normal_fecha(1, "2000-10-02");
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_normal_fecha_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_normal_fecha(-1, "1997-01-01");
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_perdidas_usuario_normal_fecha_FechaInvalida()
        {
            edoCuentas.consultar_perdidas_normal_fecha(1, "3000-01-01");
        }

        [TestMethod]
        public void consultar_ganancias_normal_juego_Valido()
        {
            float res = edoCuentas.consultar_ganancias_normal_juego(1, 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_normal_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_normal_juego(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_ganancias_normal_juego_JuegoInvalido()
        {
            edoCuentas.consultar_ganancias_normal_juego(1, -1);
        }

        [TestMethod]
        public void consultar_perdidas_normal_juego_Valido()
        {
            float res = edoCuentas.consultar_perdidas_normal_juego(1, 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_normal_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_normal_juego(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_perdidas_normal_juego_JuegoInvalido()
        {
            edoCuentas.consultar_perdidas_normal_juego(1, -1);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_normal_fecha_juego_Valido()
        {
            float res = edoCuentas.consultar_ganancias_normal_fecha_juego(1, "2000-10-02",1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_normal_fecha_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_normal_fecha_juego(-1, "2000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_ganancias_usuario_normal_fecha_juego_FechaInvalida()
        {
            edoCuentas.consultar_ganancias_normal_fecha_juego(1, "3000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_ganancias_usuario_normal_fecha_juego_JuegoInvalido()
        {
            edoCuentas.consultar_ganancias_normal_fecha_juego(1, "2000-10-02", -1);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_normal_fecha_juego_Valido()
        {
            float res = edoCuentas.consultar_perdidas_normal_fecha_juego(1, "2000-10-02", 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_normal_fecha_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_normal_fecha_juego(-1, "2000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_perdidas_usuario_normal_fecha_juego_FechaInvalida()
        {
            edoCuentas.consultar_perdidas_normal_fecha_juego(1, "3000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_perdidas_usuario_normal_fecha_juego_JuegoInvalido()
        {
            edoCuentas.consultar_perdidas_normal_fecha_juego(1, "2000-10-02", -1);
        }

        [TestMethod]
        public void consultar_ganancias_hijo_Valido()
        {
            float res = edoCuentas.consultar_ganancias_hijo(1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_hijo_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_hijo(-1);
        }

        [TestMethod]
        public void consultar_perdidas_hijo_Valido()
        {
            float res = edoCuentas.consultar_perdidas_hijo(1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_hijo_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_hijo(-1);
        }

        [TestMethod]
        public void consultar_ganancias_hijo_fecha_Valido()
        {
            float res = edoCuentas.consultar_ganancias_hijo_fecha(1, "2000-10-02");
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_hijo_fecha_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_hijo_fecha(-1, "2000-10-02");
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_ganancias_hijo_fecha_FechaInvalida()
        {
            edoCuentas.consultar_ganancias_hijo_fecha(1, "3000-10-02");
        }

        [TestMethod]
        public void consultar_perdidas_hijo_fecha_Valido()
        {
            float res = edoCuentas.consultar_perdidas_hijo_fecha(1, "2000-10-02");
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_hijo_fecha_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_hijo_fecha(-1, "2000-10-02");
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_perdidas_hijo_fecha_FechaInvalida()
        {
            edoCuentas.consultar_perdidas_hijo_fecha(1, "3000-10-02");
        }

        [TestMethod]
        public void consultar_ganancias_hijo_juego_Valido()
        {
            float res = edoCuentas.consultar_ganancias_hijo_juego(1, 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_hijo_jurgo_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_hijo_juego(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_ganancias_hijo_juego_JuegoInvalido()
        {
            edoCuentas.consultar_ganancias_hijo_juego(1, -1);
        }

        [TestMethod]
        public void consultar_perdidas_hijo_juego_Valido()
        {
            float res = edoCuentas.consultar_perdidas_hijo_juego(1, 1);
            Assert.IsTrue(res >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_hijo_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_hijo_juego(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_perdidas_hijo_fecha_JuegoInvalido()
        {
            edoCuentas.consultar_perdidas_hijo_juego(1, -1);
        }

        [TestMethod]
        public void consultar_ganancias_usuario_hijo_fecha_juego_Valido()
        {
            edoCuentas.consultar_ganancias_hijo_fecha_juego(1, "2000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_ganancias_usuario_hijo_fecha_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_ganancias_hijo_fecha_juego(-1, "2000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_ganancias_usuario_hijo_fecha_juego_FechaInvalida()
        {
            edoCuentas.consultar_ganancias_hijo_fecha_juego(1, "3000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_ganancias_usuario_hijo_fecha_juego_JuegoInvalido()
        {
            edoCuentas.consultar_ganancias_hijo_fecha_juego(1, "2000-10-02", -1);
        }

        [TestMethod]
        public void consultar_perdidas_usuario_hijo_fecha_juego_Valido()
        {
            edoCuentas.consultar_perdidas_hijo_fecha_juego(1, "2000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(UsuarioInvalidoException))]
        public void consultar_perdidas_usuario_hijo_fecha_juego_UsuarioInvalido()
        {
            edoCuentas.consultar_perdidas_hijo_fecha_juego(-1, "2000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(FechaInvalidaException))]
        public void consultar_perdidas_usuario_hijo_fecha_juego_FechaInvalida()
        {
            edoCuentas.consultar_perdidas_hijo_fecha_juego(1, "3000-10-02", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoInvalidoException))]
        public void consultar_perdidas_usuario_hijo_fecha_juego_JuegoInvalido()
        {
            edoCuentas.consultar_perdidas_hijo_fecha_juego(1, "2000-10-02", -1);
        }
    }
}
