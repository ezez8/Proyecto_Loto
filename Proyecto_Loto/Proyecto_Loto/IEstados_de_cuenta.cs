using Proyecto_Loto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Proyecto_Loto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstados_de_cuenta" in both code and config file together.
    [ServiceContract]
    public interface IEstados_de_cuenta
    {        
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGan",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_apostador(int id_usuario);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPer",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_apostador(int id_usuario);
    /*    
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanFech",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_apostador(int id_usuario, string fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerFech",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_apostador(int id_usuario, string fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_apostador(int id_usuario, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_apostador(int id_usuario, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanFechJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_apostador(int id_usuario, string fecha, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerFechJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_apostador(int id_usuario, string fecha, int id_juego);

        ////////////////////
        ///Usuario Normal///
        ////////////////////

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanNor",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal(int id_usuario);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerNor",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal(int id_usuario);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanNorFech",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal(int id_usuario, string fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerNorFech",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal(int id_usuario, string fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanNorJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal(int id_usuario, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerNorJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal(int id_usuario, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanNorFechJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal(int id_usuario, string fecha, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerNorFechJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal(int id_usuario, string fecha, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanHij",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerHij",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanHijFech",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, string fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerHijFech",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, string fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanHijJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerHijJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarGanHijFechJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_ganancia_usuario_normal_hijos(int id_usuario_padre, string fecha, int id_juego);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/consultarPerHijFechJue",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        Respuesta consultar_perdida_usuario_normal_hijos(int id_usuario_padre, string fecha, int id_juego);
   */
    }

    [DataContract]
    public class Respuesta : MsgRespuesta
    {
        [DataMember]
        public float Res { get; set; }
    }

    [DataContract]
    public class MsgRespuesta
    {
        [DataMember]
        public string MensajeRespuesta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }


}
