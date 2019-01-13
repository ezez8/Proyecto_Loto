using Proyecto_Loto.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Loto.Clases
{
    public class Usuario
    {
        IDAO base_de_datos;

        public Usuario()
        {
            base_de_datos = new DAO_MySQL();
        }

        public Respuesta_Base_de_datos consultar(string consulta) {
            return base_de_datos.consultar(consulta);
        }

        public Boolean isUsuario(int id_usuario)
        {
            string consulta = "select id_usuario from tb_usuario where id_usuario = " + id_usuario;

            Respuesta_Base_de_datos respuestas = consultar(consulta);

            return respuestas.isFilas();
        }

        public Boolean isFecha(string fecha)
        {
            if (DateTime.Parse(fecha) <= DateTime.Today)
                return true;
            else
                return false;
        }

        public Boolean isJuego(int id_juego)
        {
            string consulta = "select id_juego from tb_juego where id_juego = " + id_juego;

            Respuesta_Base_de_datos respuestas = consultar(consulta);

            return respuestas.isFilas();
        }
    }
}