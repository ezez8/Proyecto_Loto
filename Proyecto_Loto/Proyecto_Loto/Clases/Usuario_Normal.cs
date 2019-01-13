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
    public class Usuario_normal : Usuario
    {
        public Usuario_normal() : base()
        {

        }
        
        public Respuesta consultar_ganancia(int id_usuario)
        {
            try
            {
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();

                string consulta = "select MONTO_PAGADO, MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION" +
                    " from tb_usuario A, tb_ticket B, tb_comision C" +
                    " where A.id_usuario = B.id_usuario" +
                    " and A.id_usuario = C.id_usuario" +
                    " and B.fecha_hora <= C.fechafin" +
                    " and B.fecha_hora >= C.fechainicio" +
                    " and A.id_usuario = " + id_usuario;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
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

                string consulta = "select MONTO_PAGADO, MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION" +
                    " from tb_usuario A, tb_ticket B, tb_comision C" +
                    " where A.id_usuario = B.id_usuario" +
                    " and A.id_usuario = C.id_usuario" +
                    " and B.fecha_hora <= C.fechafin" +
                    " and B.fecha_hora >= C.fechainicio" +
                    " and A.id_usuario = " + id_usuario;

                Respuesta_Base_de_datos respuestas = consultar(consulta);                

                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
                }
                               
                if (totalperdida > totalganancia)
                {
                    return new Respuesta() { Res = totalperdida - totalganancia, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_ganancia(int id_usuario, string fecha)
        {
            try
            {            
                if (!isUsuario(id_usuario)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();

                string consulta = "select MONTO_PAGADO, MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION" +
                    " from tb_usuario A, tb_ticket B, tb_comision C" +
                    " where A.id_usuario = B.id_usuario" +
                    " and A.id_usuario = C.id_usuario" +
                    " and B.fecha_hora <= C.fechafin" +
                    " and B.fecha_hora >= C.fechainicio" +
                    " and A.id_usuario = " + id_usuario +
                    " and B.fecha_hora >= \"" + fecha + "\"";

                Respuesta_Base_de_datos respuestas = consultar(consulta);                

                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
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

                string consulta = "select MONTO_PAGADO, MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION" +
                    " from tb_usuario A, tb_ticket B, tb_comision C" +
                    " where A.id_usuario = B.id_usuario" +
                    " and A.id_usuario = C.id_usuario" +
                    " and B.fecha_hora <= C.fechafin" +
                    " and B.fecha_hora >= C.fechainicio" +
                    " and A.id_usuario = " + id_usuario +
                    " and B.fecha_hora >= \"" + fecha + "\"";

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
                }

                if (totalperdida > totalganancia)
                {
                    return new Respuesta() { Res = totalperdida - totalganancia, MensajeRespuesta = "Operación exitosa" }; ;
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

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket, tb_comision C " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                " and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
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
            catch (JuegoInvalidoException e)
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

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA, COMISIONVENTA, COMISIONPARTICIPACION " +
                "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket, tb_comision C " +
                "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                "and tb_usuario.ID_USUARIO = " + id_usuario +
                " and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
                }

                if (totalperdida > totalganancia)
                {
                    return new Respuesta() { Res = totalperdida - totalganancia, MensajeRespuesta = "Operación exitosa" }; ;
                }

                return new Respuesta() { Res = 0, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (JuegoInvalidoException e)
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

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA, tb_comision.COMISIONVENTA, tb_comision.COMISIONPARTICIPACION " +
                    "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket, tb_comision " +
                    "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                    "and tb_usuario.ID_USUARIO = tb_comision.ID_USUARIO " +
                    "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                    "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                    "and tb_ticket.fecha_hora <= tb_comision.fechafin " +
                    "and tb_ticket.fecha_hora >= tb_comision.fechainicio " +
                    "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                    "and tb_usuario.ID_USUARIO = " + id_usuario +
                    " and tb_ticket.FECHA_HORA >= \"" + fecha + "\" " +
                    "and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                

                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
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

                string consulta = "select tb_ticket.MONTO_PAGADO, tb_ticket.MONTO_APUESTA, tb_comision.COMISIONVENTA, tb_comision.COMISIONPARTICIPACION " +
                    "from tb_usuario_sorteo_item, tb_item, tb_juego, tb_usuario, tb_ticket, tb_comision " +
                    "where tb_juego.ID_JUEGO = tb_item.ID_JUEGO " +
                    "and tb_usuario.ID_USUARIO = tb_comision.ID_USUARIO " +
                    "and tb_ticket.ID_USUARIO = tb_usuario.ID_USUARIO " +
                    "and tb_usuario.ID_USUARIO = tb_usuario_sorteo_item.ID_USUARIO " +
                    "and tb_ticket.fecha_hora <= tb_comision.fechafin " +
                    "and tb_ticket.fecha_hora >= tb_comision.fechainicio " +
                    "and tb_usuario_sorteo_item.ID_ITEM = tb_item.ID_ITEM " +
                    "and tb_usuario.ID_USUARIO = " + id_usuario +
                    " and tb_ticket.FECHA_HORA >= \"" + fecha + "\" " +
                    "and tb_juego.ID_JUEGO = " + id_juego;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float total_ganado = 0;
                float total_apostado = 0;
                float totalganancia = 0;
                float totalperdida = 0;
                float comisionventa = 0;
                float comisionparticipacion = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    total_ganado = respuestas.Filas[i][0];
                    total_apostado = respuestas.Filas[i][1];
                    comisionventa = respuestas.Filas[i][2];
                    comisionparticipacion = respuestas.Filas[i][3];

                    if (total_apostado > total_ganado)
                        totalganancia += (total_apostado - total_ganado) * comisionventa / 100;
                    else if (total_ganado > total_apostado)
                        totalperdida += (total_ganado - total_apostado) * comisionparticipacion / 100;
                }

                if (totalperdida > totalganancia)
                {
                    return new Respuesta() { Res = totalperdida - totalganancia, MensajeRespuesta = "Operación exitosa" }; ;
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

        public Respuesta consultar_ganancia_hijos(int id_usuario_padre)
        {
            try
            {               
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();             
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);                

                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_ganancia((int)respuestas.Filas[i][0]).Res +
                        consultar_ganancia_hijos((int)respuestas.Filas[i][0]).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_perdida_hijos(int id_usuario_padre)
        {
            Respuesta respuesta = new Respuesta();
            try
            {             
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();               
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);                

                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_perdida((int)respuestas.Filas[i][0]).Res +
                        consultar_perdida_hijos((int)respuestas.Filas[i][0]).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_ganancia_hijos(int id_usuario_padre, string fecha)
        {
            try
            {             
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();              
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_ganancia((int)respuestas.Filas[i][0],fecha).Res +
                        consultar_ganancia_hijos((int)respuestas.Filas[i][0],fecha).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
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

        public Respuesta consultar_perdida_hijos(int id_usuario_padre, string fecha)
        {
            try
            {               
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();              
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                

                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_perdida((int)respuestas.Filas[i][0],fecha).Res +
                        consultar_perdida_hijos((int)respuestas.Filas[i][0],fecha).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
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

        public Respuesta consultar_ganancia_hijos(int id_usuario_padre, int id_juego)
        {
            try
            {               
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();              
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_ganancia((int)respuestas.Filas[i][0],id_juego).Res +
                        consultar_ganancia_hijos((int)respuestas.Filas[i][0],id_juego).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (JuegoInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_perdida_hijos(int id_usuario_padre, int id_juego)
        {
            try
            {               
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();               
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);
                
                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_perdida((int)respuestas.Filas[i][0],id_juego).Res +
                        consultar_perdida_hijos((int)respuestas.Filas[i][0],id_juego).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
            }
            catch (UsuarioInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
            catch (JuegoInvalidoException e)
            {
                return new Respuesta() { Error = e.Message }; ;
            }
        }

        public Respuesta consultar_ganancia_hijos(int id_usuario_padre, string fecha, int id_juego)
        {
            try
            {               
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();               
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);                

                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_ganancia((int)respuestas.Filas[i][0],fecha,id_juego).Res +
                        consultar_ganancia_hijos((int)respuestas.Filas[i][0],fecha,id_juego).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
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

        public Respuesta consultar_perdida_hijos(int id_usuario_padre, string fecha, int id_juego)
        {
            try
            {              
                if (!isUsuario(id_usuario_padre)) throw new UsuarioInvalidoException();
                if (!isFecha(fecha)) throw new FechaInvalidaException();
                if (!isJuego(id_juego)) throw new JuegoInvalidoException();               
                
                string consulta = "select U.id_usuario" +
                    " from tb_usuario U" +
                    " where U.id_usuariopadre = " + id_usuario_padre;

                Respuesta_Base_de_datos respuestas = consultar(consulta);                

                float suma = 0;

                for (int i = 0; i < respuestas.catidad_de_filas(); i++)
                {
                    suma += consultar_perdida((int)respuestas.Filas[i][0],fecha,id_juego).Res +
                        consultar_perdida_hijos((int)respuestas.Filas[i][0], fecha, id_juego).Res;
                }

                return new Respuesta() { Res = suma, MensajeRespuesta = "Operación exitosa" }; ;
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
    }
}