using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Proyecto_Loto.Exceptions
{
    public class JuegoInvalidoException : Exception
    {
        public JuegoInvalidoException() : base("Juego no registrado en la base de datos")
        {
        }

        public JuegoInvalidoException(string message) : base(message)
        {
        }

        public JuegoInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JuegoInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}