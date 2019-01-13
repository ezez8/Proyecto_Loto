using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Loto.DAO
{
    public class Base_de_datos_MySQL : IBase_de_datos
    {
        MySqlConnection conexion;
        MySqlConnectionStringBuilder builder;
        MySqlCommand comando;
        MySqlDataReader reader;

        public Base_de_datos_MySQL()
        {
            builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "agente86";
            builder.Database = "loto";

            conexion = new MySqlConnection(builder.ToString());


        }

        Respuesta_Base_de_datos IBase_de_datos.consultar(string consulta)
        {
            Respuesta_Base_de_datos respuesta = new Respuesta_Base_de_datos();
            try
            {
                conexion.Open();

                comando = new MySqlCommand(consulta, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    respuesta.add_Fila();

                    for (int i = 0; i < reader.FieldCount; i++)
                        respuesta.add_Columna(reader.GetFloat(i));
                }

                return respuesta;
            }
            catch (MySqlException e)
            {
                respuesta.Mensaje = e.Message;
                return respuesta;
            }
            finally {
                conexion.Close();
            }
        }
    }
}