using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Proyecto_Loto.Clases
{
    public static class Usuario_apostador
    {
        public static MySqlConnection Conexion;
        public static MySqlCommand cmd;
        public static MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public static string Conectar()
        {
            try
            {
                builder.Server = "localhost";
                builder.Port = 3306;
                builder.UserID = "root";
                builder.Password = "agente86";
                builder.Database = "loto";
                Conexion = new MySqlConnection(builder.ToString());
                Conexion.Open();

                return "Se conecto la base de datos";
            }
            catch (Exception e)
            {

                return "No se conecto la base de datos";
            }
        }

        public static string Desconectar()
        {
            try
            {
                Conexion.Close();

                return "Se cerro la base de datos";
            }
            catch (Exception e)
            {
                return "No se cerro la base de datos";
            }
            finally
            {

            }
        }

        public static float consultar_ganancias_usuario_apostador(int id_usuario)
        {
            try
            {
                string consulta = "select monto_pagado, MONTO_APUESTA from tb_ticket A, tb_usuario B" +
                " where A.id_usuario = B.id_usuario and B.id_usuario = "
                + id_usuario;

                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();
 
                float total_ganado = 0;
                float total_apostado = 0;
                
                //if (!myReader.Read()) throw new UsuarioInvalidoException();
 
                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();
                

                if ((total_ganado - total_apostado) > 0)
                    return total_ganado - total_apostado;

                return 0;
            }
            catch (UsuarioInvalidoException e)
            {
                throw;
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        public static float consultar_perdidas_usuario_apostador(int id_usuario)
        {
            try
            {
                string consulta = "select monto_pagado, MONTO_APUESTA from tb_ticket A, tb_usuario B" +
                " where A.id_usuario = B.id_usuario and B.id_usuario = "
                + id_usuario;

                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_apostado - total_ganado) > 0)
                    return total_apostado - total_ganado;

                return 0;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public static float consultar_ganancias_usuario_apostador_fecha(int id_usuario, string fecha)
        {
            string consulta = "select monto_pagado, monto_apuesta " +
                 "from tb_ticket A, tb_usuario B " +
                 "where A.id_usuario = B.id_usuario and fecha_hora >= \"" + fecha +
                 "\" and A.id_usuario = " + id_usuario;

            try
            {
                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_ganado - total_apostado) > 0)
                    return total_ganado - total_apostado;

                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static float consultar_perdidas_usuario_apostador_fecha(int id_usuario, string fecha)
        {
            try
            {
                string consulta = "select monto_pagado, monto_apuesta " +
                 "from tb_ticket A, tb_usuario B " +
                 "where A.id_usuario = B.id_usuario and fecha_hora >= \"" + fecha +
                 "\" and A.id_usuario = " + id_usuario;


                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_apostado - total_ganado) > 0)
                    return total_apostado - total_ganado;

                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static float consultar_ganancias_usuario_apostador_juego(int id_usuario, int id_juego)
        {
            try
            {
                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                "and tb_juego.ID_JUEGO = " + id_juego;


                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_ganado - total_apostado) > 0)
                    return total_ganado - total_apostado;

                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static float consultar_perdidas_usuario_apostador_juego(int id_usuario, int id_juego)
        {
            string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                "and tb_juego.ID_JUEGO = " + id_juego;

            try
            {
                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_apostado - total_ganado) > 0)
                    return total_apostado - total_ganado;

                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static float consultar_ganancias_usuario_apostador_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                "and tb_ticket.FECHA_HORA >= \"" + fecha + "\" " +
                "and tb_juego.ID_JUEGO = " + id_juego;

            try
            {
                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_ganado - total_apostado) > 0)
                    return total_ganado - total_apostado;

                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static float consultar_perdidas_usuario_apostador_fecha_juego(int id_usuario, string fecha, int id_juego)
        {
            string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                "and tb_ticket.FECHA_HORA >= \"" + fecha + "\" " +
                "and tb_juego.ID_JUEGO = " + id_juego;

            try
            {
                cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataReader myReader = cmd.ExecuteReader();

                float total_ganado = 0;
                float total_apostado = 0;

                while (myReader.Read())
                {
                    total_ganado += myReader.GetFloat(0);
                    total_apostado += myReader.GetFloat(1);
                }

                myReader.Close();

                if ((total_apostado - total_ganado) > 0)
                    return total_apostado - total_ganado;

                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
         
    }
}
