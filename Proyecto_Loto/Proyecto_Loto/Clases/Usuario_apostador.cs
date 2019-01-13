using MySql.Data.MySqlClient;
using Proyecto_Loto.DAO;
using Proyecto_Loto.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Proyecto_Loto.Clases
{
    public class Usuario_apostador : Usuario
    {
        public Usuario_apostador() : base()
        {
            
        }
        
        public Respuesta consultar_ganancia(int id_usuario)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();

                string consulta = "select monto_pagado, monto_apuesta from tb_ticket A, tb_usuario B" +
                " where A.id_usuario = B.id_usuario and B.id_usuario = "
                + id_usuario;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++) {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }    

                if (total_ganado > total_apostado)
                {
                    return new Respuesta() { Res = total_ganado - total_apostado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
               return new Respuesta() { Error = e.Message }; ;
            }
        }
        
        public Respuesta consultar_perdida(int id_usuario)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();

                string consulta = "select monto_pagado, MONTO_APUESTA from tb_ticket A, tb_usuario B" +
                " where A.id_usuario = B.id_usuario and B.id_usuario = "
                + id_usuario;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_apostado > total_ganado)
                {
                     return new Respuesta() { Res = total_apostado - total_ganado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }
        /*
        public Respuesta consultar_ganancia(int id_usuario, string fecha)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();

                string consulta = "select monto_pagado, monto_apuesta " +
                "from tb_ticket A, tb_usuario B " +
                "where A.id_usuario = B.id_usuario and fecha_hora >= \"" + fecha +
                "\" and A.id_usuario = " + id_usuario;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_ganado > total_apostado)
                {
                    return new Respuesta() { Res = total_ganado - total_apostado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (FechaInvalidaException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_perdida(int id_usuario, string fecha)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();

                string consulta = "select monto_pagado, monto_apuesta " +
                 "from tb_ticket A, tb_usuario B " +
                 "where A.id_usuario = B.id_usuario and fecha_hora >= \"" + fecha +
                 "\" and A.id_usuario = " + id_usuario;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_apostado > total_ganado)
                {
                    return new Respuesta() { Res = total_apostado - total_ganado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (FechaInvalidaException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_ganancia(int id_usuario, int id_juego)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                " and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_ganado > total_apostado)
                {
                    return new Respuesta() { Res = total_ganado - total_apostado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (FechaInvalidaException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_perdida(int id_usuario, int id_juego)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                " and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_apostado > total_ganado)
                {
                    return new Respuesta() { Res = total_apostado - total_ganado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (FechaInvalidaException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_ganancia(int id_usuario, string fecha, int id_juego)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                " and tb_ticket.FECHA_HORA >= \"" + fecha + "\" " +
                "and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_ganado > total_apostado)
                {
                    return new Respuesta() { Res = total_ganado - total_apostado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (FechaInvalidaException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (JuegoInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_perdida(int id_usuario, string fecha, int id_juego)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                " and tb_ticket.FECHA_HORA >= \"" + fecha + "\" " +
                "and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);

                float total_ganado = 0;
                float total_apostado = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado += respuestas.Filas[i][0];
                    total_apostado += respuestas.Filas[i][1];
                }

                if (total_apostado > total_ganado)
                {
                    return new Respuesta() { Res = total_apostado - total_ganado, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (FechaInvalidaException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (JuegoInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }*/
         
    }
}
