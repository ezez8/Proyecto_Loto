﻿using MySql.Data.MySqlClient;
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
        Fachada_Estados_de_cuenta comandos = new Fachada_Estados_de_cuenta();

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Usuario Apostador///
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario)
        {
            return comandos.consultar_ganancia_usuario_apostador(id_usuario);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario)
        {
            return comandos.consultar_perdida_usuario_apostador(id_usuario);
        }
    /*    
        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario, string fecha)
        {
            return comandos.consultar_ganancia_usuario_apostador(id_usuario, fecha);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario, string fecha)
        {
            return consultar_perdida_usuario_apostador(id_usuario, fecha);
        }

        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario, int id_juego)
        {
            return comandos.consultar_ganancia_usuario_apostador(id_usuario, id_juego);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario, int id_juego)
        {
            return consultar_perdida_usuario_apostador(id_usuario, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_apostador(int id_usuario, string fecha, int id_juego)
        {
            return comandos.consultar_ganancia_usuario_apostador(id_usuario, fecha, id_juego);
        }

        public Respuesta consultar_perdida_usuario_apostador(int id_usuario, string fecha, int id_juego)
        {
            return comandos.consultar_perdida_usuario_apostador(id_usuario, fecha, id_juego);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Usuario Normal///
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario)
        {
            return comandos.consultar_ganancia_usuario_normal(id_usuario);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario)
        {
            return comandos.consultar_perdida_usuario_normal(id_usuario);
        }

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario, string fecha)
        {
            return comandos.consultar_ganancia_usuario_normal(id_usuario, fecha);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario, string fecha)
        {
            return comandos.consultar_perdida_usuario_normal(id_usuario, fecha);
        }

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario, int id_juego)
        {
            return comandos.consultar_ganancia_usuario_normal(id_usuario, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario, int id_juego) {
            return comandos.consultar_perdida_usuario_normal(id_usuario, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_normal(int id_usuario, string fecha, int id_juego)
        {
            return comandos.consultar_ganancia_usuario_normal(id_usuario, fecha, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal(int id_usuario, string fecha, int id_juego)
        {
            return comandos.consultar_perdida_usuario_normal(id_usuario, fecha, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre) {
            return comandos.consultar_ganancia_usuario_normal_hijos(id_usuario_padre);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre)
        {
            return comandos.consultar_perdida_usuario_normal_hijos(id_usuario_padre);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, string fecha) {
            return comandos.consultar_ganancia_usuario_normal_hijos(id_usuario_padre, fecha);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, string fecha)
        {
            return comandos.consultar_perdida_usuario_normal_hijos(id_usuario_padre, fecha);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, int id_juego)
        {
            return comandos.consultar_ganancia_usuario_normal_hijos(id_usuario_padre, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, int id_juego)
        {
            return comandos.consultar_perdida_usuario_normal_hijos(id_usuario_padre, id_juego);
        }

        public Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, string fecha, int id_juego)
        {
            return comandos.consultar_ganancia_usuario_normal_hijos(id_usuario_padre, fecha, id_juego);
        }

        public Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, string fecha, int id_juego)
        {
            return comandos.consultar_perdida_usuario_normal_hijos(id_usuario_padre, fecha, id_juego);
        }
        */
    }
}
