using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Loto.Clases
{
    public class Respuesta
    {
        string mensaje;
        float res;

        public string Mensaje { get => mensaje; set => mensaje = value; }
        public float Res { get => res; set => res = value; }

        public Respuesta()
        {
            res = 0;
            Mensaje = null;
        }

    }
}