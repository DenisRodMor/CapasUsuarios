using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos.Interfaces
{
   public interface IUsuariosAD
    {

        List<PA_ListadoUsuarios_Result> recUsuarios_PA();
        bool insUsuarios_PA(Usuarios pUsuarios);
        bool modUsuarios_PA(Usuarios pUsuarios);
        bool delUsuarios_PA(Usuarios pUsuarios);

    }
}
