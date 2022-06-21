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
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = ousuariosAD.delUsuarios_PA(pUsuarios);
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
            try
            {
                lObjRespuesta = ousuariosAD.insUsuarios_PA(pUsuarios);
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
            try
            {
                lObjRespuesta = ousuariosAD.modUsuarios_PA(pUsuarios);
            }
            catch (Exception ex)
            {

                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw ex;
            }
            return lObjRespuesta;
        }

        public List<PA_ListadoUsuarios_Result> recUsuarios_PA()
        {
            List<PA_ListadoUsuarios_Result> lObjRespuesta = new List<PA_ListadoUsuarios_Result>();
            try
            {
                lObjRespuesta = ousuariosAD.recUsuarios_PA();
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
