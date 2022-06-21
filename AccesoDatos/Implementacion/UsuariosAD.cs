using Entidades;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
   public class UsuariosAD
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private CapasEntidadesss gObjContextoUser;

        public UsuariosAD(CapasEntidadesss lgObjContextoUser)
        {
            gObjContextoUser = lgObjContextoUser;
        }

        public List<PA_ListadoUsuarios_Result> recUsuarios_PA()
        {
            List<PA_ListadoUsuarios_Result> lObjRespuesta = new List<PA_ListadoUsuarios_Result>();
            try
            {
                lObjRespuesta = gObjContextoUser.PA_ListadoUsuarios().ToList();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool insUsuarios_PA(Usuarios pUsuarios)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoUser.PA_InsertarUsuario_( pUsuarios.Nombre, pUsuarios.Apellidos, pUsuarios.Usuario, pUsuarios.Clave , pUsuarios.Direccion, pUsuarios.Telefono, pUsuarios.TipodeUsuario);
                if (intValor == 1)
                {
                    lObjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool modUsuarios_PA(Usuarios pUsuarios)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoUser.PA_EditarUsuarios(pUsuarios.Id ,pUsuarios.Nombre, pUsuarios.Apellidos ,pUsuarios.Usuario, pUsuarios.Clave, pUsuarios.Direccion, pUsuarios.Telefono, pUsuarios.TipodeUsuario);
                if (intValor == 1)
                {
                    lObjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public bool delPacientes_PA(Usuarios pUsuarios)
        {
            bool lObjRespuesta = false;
            int intValor = 0;

            try
            {
                intValor = gObjContextoUser.PA_EliminarUsuario(pUsuarios.Id);
                if (intValor == 1)
                {
                    lObjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }
    }
}
