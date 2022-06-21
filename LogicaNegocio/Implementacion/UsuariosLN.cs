using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion
{
    public class UsuariosLN : IUsuariosLN
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        public static CapasEntidadesss gObjContextoUserLN = new CapasEntidadesss();

        private readonly IUsuariosAD ousuariosAD = new UsuariosAD(gObjContextoUserLN);

        public bool delUsuarios_PA(Usuarios pUsuarios)
        {
            throw new NotImplementedException();
        }

        public bool insUsuarios_PA(Usuarios pUsuarios)
        {
            throw new NotImplementedException();
        }

        public bool modUsuarios_PA(Usuarios pUsuarios)
        {
            throw new NotImplementedException();
        }

        public List<PA_ListadoUsuarios_Result> recUsuarios_PA()
        {
            throw new NotImplementedException();
        }
    }
}
