using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Loto.Clases
{
    public class Estados_de_cuentaComandos
    {
        Usuario_apostador usuario_apostador;
        Usuario_normal usuario_normal;

        public Estados_de_cuentaComandos()
        {
            usuario_apostador = new Usuario_apostador();
            usuario_normal = new Usuario_normal();
        }

        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario)
        {
            return usuario_apostador.consultar_ganancia(id_usuario);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario)
        {
            return usuario_apostador.consultar_perdida(id_usuario);
        }

        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario, string fecha)
        {
            return usuario_apostador.consultar_ganancia(id_usuario, fecha);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario, string fecha)
        {
            return usuario_apostador.consultar_perdida(id_usuario, fecha);
        }

        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario, int id_juego)
        {
            return usuario_apostador.consultar_ganancia(id_usuario, id_juego);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario, int id_juego)
        {
            return usuario_apostador.consultar_perdida(id_usuario, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario, string fecha, int id_juego)
        {
            return usuario_apostador.consultar_ganancia(id_usuario, fecha, id_juego);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario, string fecha, int id_juego)
        {
            return usuario_apostador.consultar_perdida(id_usuario, fecha, id_juego);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //EXTERNO usuario_normal
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario)
        {
            return usuario_normal.consultar_ganancia(id_usuario);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario)
        {
            return usuario_normal.consultar_perdida(id_usuario);
        }

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario, string fecha)
        {
            return usuario_normal.consultar_ganancia(id_usuario, fecha);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario, string fecha)
        {
            return usuario_normal.consultar_perdida(id_usuario, fecha);
        }

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario, int id_juego)
        {
            return usuario_normal.consultar_ganancia(id_usuario, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario, int id_juego)
        {
            return usuario_normal.consultar_perdida(id_usuario, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario, string fecha, int id_juego)
        {
            return usuario_normal.consultar_ganancia(id_usuario, fecha, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario, string fecha, int id_juego)
        {
            return usuario_normal.consultar_perdida(id_usuario, fecha, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre)
        {
            return usuario_normal.consultar_ganancia_hijos(id_usuario_padre);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre)
        {
            return usuario_normal.consultar_perdida_hijos(id_usuario_padre);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, string fecha)
        {
            return usuario_normal.consultar_ganancia_hijos(id_usuario_padre, fecha);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, string fecha)
        {
            return usuario_normal.consultar_perdida_hijos(id_usuario_padre, fecha);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, int id_juego)
        {
            return usuario_normal.consultar_ganancia_hijos(id_usuario_padre, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, int id_juego)
        {
            return usuario_normal.consultar_perdida_hijos(id_usuario_padre, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, string fecha, int id_juego)
        {
            return usuario_normal.consultar_ganancia_hijos(id_usuario_padre, fecha, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, string fecha, int id_juego)
        {
            return usuario_normal.consultar_perdida_hijos(id_usuario_padre, fecha, id_juego);
        }
    }
}