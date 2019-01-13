using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Loto.DAO
{
    public class Respuesta_Base_de_datos
    {
        string mensaje;
        List<List<float>> filas;

        public string Mensaje { get => mensaje; set => mensaje = value; }
        public List<List<float>> Filas { get => filas; set => filas = value; }

        public Respuesta_Base_de_datos()
        {
            filas = new List<List<float>>();
            mensaje = null;
        }

        public bool isFilas() {
            return filas.Any();
        }

        public float get_Dato(int i)
        {
            return filas[0][i];
        }

        public int catidad_de_filas()
        {
            return filas.Count();
        }

        public List<float> get_Fila(int fila)
        {
            return filas[fila];
        }

        public List<float> get_Ultima_Fila() {
            return filas.Last();
        }

        public void add_Fila() {
            filas.Add(new List<float>());
        }

        public void add_Columna(float columna) {
            filas.Last().Add(columna);
        }
    }
}