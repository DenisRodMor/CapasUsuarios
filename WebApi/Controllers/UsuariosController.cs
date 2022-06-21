using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly Logger gobjLogger = LogManager.GetCurrentClassLogger();
        private readonly IUsuariosLN ousuarios = new UsuariosLN();




        // GET: api/<UsuariosController>
        [HttpGet]
        public List<PA_ListadoUsuarios_Result> recUsuarios_PA()
        {
            List<PA_ListadoUsuarios_Result> lObjRespuesta = new List<PA_ListadoUsuarios_Result>();
            try
            {
                lObjRespuesta = ousuarios.recUsuarios_PA();
            }
            catch (Exception ex)
            {
                gobjLogger.Error("Se produjo un error. Detalle " + ex.Message + " " + ex.InnerException.Message);
                throw;
            }
            return lObjRespuesta;
        }

        

        // POST api/<UsuariosController>
        [HttpPost]
        public  ActionResult insUsuarios_PA([FromBody] Usuarios pUsuarios)
        {

            if (ModelState.IsValid)
            {
                ousuarios.insUsuarios_PA(pUsuarios);
                return Ok(pUsuarios);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public ActionResult modUsuarios_PA(int Id, [FromBody] Usuarios pUsuarios)
        {

            if (ModelState.IsValid)
            {
                ousuarios.modUsuarios_PA(pUsuarios);
                return Ok(pUsuarios);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public ActionResult delUsuarios_PA(int id, [FromBody] Usuarios pUsuarios)
        {

            if (ModelState.IsValid)
            {
                ousuarios.delUsuarios_PA(pUsuarios);
                return Ok(pUsuarios);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
