using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Loto.DAO
{
    interface IDAO
    {
        Respuesta_Base_de_datos consultar(string consulta);
    }     
}
