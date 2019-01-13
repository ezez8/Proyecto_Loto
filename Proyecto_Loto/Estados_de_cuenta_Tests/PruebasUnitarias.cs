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
        Estados_de_cuenta edoCuentas;
        Usuario usuario;
        Respuesta respuesta;

        [TestInitialize]
        public void inicializar()
        {
            usuario = new Usuario();
            edoCuentas = new Estados_de_cuenta();
        }

        ///Usuario///

        [TestMethod]
        public void isUsuario_true()
        {
            bool respuesta = usuario.isUsuario(1);
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void isUsuario_false()
        {
            bool respuesta = usuario.isUsuario(-1);
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void isFecha_true()
        {
            bool respuesta = usuario.isFecha("1997-01-01");
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void isFechar_false()
        {
            bool respuesta = usuario.isFecha("3000-01-01");
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void isJuego_true()
        {
            bool respuesta = usuario.isJuego(1);
            Assert.IsTrue(respuesta);
        }

        [TestMethod]
        public void isJuego_false()
        {
            bool respuesta = usuario.isJuego(-1);
            Assert.IsFalse(respuesta);
        }

        //////////Usuario Apostador////////////

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(-1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(-1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, "1997-01-01");
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(-1, "1997-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, "3000-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, "1997-01-01");
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(-1, "1997-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, "3000-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_juego_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(-1, 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_juego_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(-1, 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_juego_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, "1997-01-01", 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(-1, "1997-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_juego_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, "3000-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_apostador_fecha_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_apostador(1, "1997-01-01", -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_juego_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, "1997-01-01", 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(-1, "1997-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_juego_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, "3000-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_perdida_usuario_apostador_fecha_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_apostador(1, "1997-01-01", -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        ///////Usuario Normal////////

        [TestMethod]
        public void consultar_ganancia_usuario_normal_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(-1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(-1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_fecha_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, "1997-01-01");
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_fecha_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(-1, "1997-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_fecha_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, "3000-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, "1997-01-01");
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(-1, "1997-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, "3000-01-01");
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_juego_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(-1, 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]        public void consultar_ganancia_usuario_normal_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]        public void consultar_perdida_usuario_normal_juego_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(-1, 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_fecha_juego_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, "1997-01-01", 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_fecha_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(-1, "1997-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]        public void consultar_ganancia_usuario_normal_fecha_juego_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, "3000-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_fecha_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal(1, "1997-01-01", -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_juego_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, "1997-01-01", 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(-1, "1997-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_juego_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, "3000-01-01", 1);
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_fecha_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal(1, "1997-01-01", -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }


        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(-1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(-1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_fecha_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, "2000-10-02");
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_fecha_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(-1, "2000-10-02");
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_fecha_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, "3000-10-02");
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_fecha_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, "2000-10-02");
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_fecha_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(-1, "2000-10-02");
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_fecha_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, "3000-10-02");
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_juego_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_jurgo_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(-1, 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_normal_hijos_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_juego_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(-1, 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_normal_hijos_fecha_juego_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_hijos_fecha_juego_valido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, "2000-10-02", 1);
            Assert.IsTrue(respuesta.Res >= 0);
        }

        [TestMethod]
        public void consultar_ganancia_usuario_hijos_fecha_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(-1, "2000-10-02", 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_hijos_fecha_juego_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, "3000-10-02", 1);
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_ganancia_usuario_hijos_fecha_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_ganancia_usuario_normal_hijos(1, "2000-10-02", -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_hijos_fecha_juego_valido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, "2000-10-02", 1);
        }

        [TestMethod]
        public void consultar_perdida_usuario_hijos_fecha_juego_usuario_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(-1, "2000-10-02", 1);
            Assert.AreEqual(respuesta.Mensaje, "Usuario no registrado en la base de datos");
        }

        [TestMethod]
        public void consultar_perdida_usuario_hijos_fecha_juego_fecha_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, "3000-10-02", 1);
            Assert.AreEqual(respuesta.Mensaje, "Fecha mayor a la actual");
        }

        [TestMethod]
        public void consultar_perdida_usuario_hijos_fecha_juego_juego_invalido()
        {
            respuesta = edoCuentas.consultar_perdida_usuario_normal_hijos(1, "2000-10-02", -1);
            Assert.AreEqual(respuesta.Mensaje, "Juego no registrado en la base de datos");
        }
    }
}
