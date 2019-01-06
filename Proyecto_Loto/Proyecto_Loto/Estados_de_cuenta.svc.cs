using Proyecto_Loto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Proyecto_Loto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Estados_de_cuenta" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Estados_de_cuenta.svc or Estados_de_cuenta.svc.cs at the Solution Explorer and start debugging.
    public class Estados_de_cuenta : IEstados_de_cuenta
    {
        //Base_de_datos dataBase = new Base_de_datos();

        public string conectarBaseDatos()
        {
            Usuario_Normal.Conectar();
            return Usuario_apostador.Conectar();

        }

        public string desconectarBaseDatos()
        {
            return Usuario_apostador.Desconectar();
        }

        public float consultar_ganancias_apostador(int id_usuario)
        {
            return Usuario_apostador.consultar_ganancias_usuario_apostador(id_usuario);
        }

        public float consultar_perdidas_apostador(int id_usuario)
        {
            return Usuario_apostador.consultar_perdidas_usuario_apostador(id_usuario);
        }

        public float consultar_ganancias_apostador_fecha(int id_usuario, string fecha)
        {
            return Usuario_apostador.consultar_ganancias_usuario_apostador_fecha(id_usuario, fecha);
        }

        public float consultar_perdidas_apostador_fecha(int id_usuario, string fecha)
        {
            return Usuario_apostador.consultar_perdidas_usuario_apostador_fecha(id_usuario, fecha);
        }

        public float consultar_ganancias_apostador_juego(int id_usuario, int id_juego)
        {
            return Usuario_apostador.consultar_ganancias_usuario_apostador_juego(id_usuario, id_juego);
        }

        public float consultar_perdidas_apostador_juego(int id_usuario, int id_juego)
        {
            return Usuario_apostador.consultar_perdidas_usuario_apostador_juego(id_usuario, id_juego);
        }

        public float consultar_ganancias_apostador_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            return Usuario_apostador.consultar_ganancias_usuario_apostador_fecha_juego(id_usuario, fecha, id_juego);
        }

        public float consultar_perdidas_apostador_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            return Usuario_apostador.consultar_perdidas_usuario_apostador_fecha_juego(id_usuario, fecha, id_juego);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //EXTERNO NORMAL
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public float consultar_ganancias_normal(int id_usuario)
        {
            return Usuario_Normal.consultar_ganancias_usuario_normal(id_usuario);
        }

        public float consultar_perdidas_normal(int id_usuario)
        {
            return Usuario_Normal.consultar_perdidas_usuario_normal(id_usuario);
        }

        public float consultar_ganancias_normal_fecha(int id_usuario, string fecha)
        {
            return Usuario_Normal.consultar_ganancias_usuario_normal_fecha(id_usuario,fecha);
        }

        public float consultar_perdidas_normal_fecha(int id_usuario, string fecha)
        {
            return Usuario_Normal.consultar_perdidas_usuario_normal_fecha(id_usuario, fecha);
        }

        public float consultar_ganancias_normal_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            return Usuario_Normal.consultar_ganancias_usuario_normal_fecha_juego(id_usuario, fecha, id_juego);
        }

        public float consultar_perdidas_normal_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            return Usuario_Normal.consultar_perdidas_usuario_normal_fecha_juego(id_usuario, fecha, id_juego);
        }

        public float consultar_ganancias_hijo_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            return Usuario_Normal.consultar_ganancias_usuario_hijo_fecha_juego(id_usuario, fecha, id_juego);
        }

        public float consultar_perdidas_hijo_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            return Usuario_Normal.consultar_perdidas_usuario_hijo_fecha_juego(id_usuario,fecha,id_juego);
        }
    }
}
