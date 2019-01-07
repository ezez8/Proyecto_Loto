using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Proyecto_Loto.Exceptions
{
    public class FechaInvalidaException : Exception
    {
        public FechaInvalidaException() : base("Fecha mayor a la actual")
        {
        }

        public FechaInvalidaException(string message) : base(message)
        {
        }

        public FechaInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FechaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}