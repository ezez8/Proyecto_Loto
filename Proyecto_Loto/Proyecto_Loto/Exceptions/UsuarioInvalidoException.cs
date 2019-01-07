using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Proyecto_Loto.Clases
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException() : base("Usuario no registrado en la base de datos")
        {
        }

        public UsuarioInvalidoException(string message) : base(message)
        {
        }

        public UsuarioInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UsuarioInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}