﻿using ApiKaratePro.model.proc;
using ApiKaratePro.model.Request;
using ApiKaratePro.model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiKaratePro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetenciaController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta m_1_1()
        {
            Respuesta res = p_Competencia.consultaTodoCompetencia();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta m_1_2([FromBody] competencia_A_competencia competencia)
        {
            // Verifica si el modelo es válido
            //if (!ModelState.IsValid)
            //{
            //    // Devuelve errores de validación

            //    Respuesta respu = new Respuesta();
            //    respu.CodigoError = 2;

            //    return respu;
            //}

            Respuesta res = p_Competencia.actualizaCompetencia(competencia);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] competencia_A_competencia competencia)
        {

            //if (!ModelState.IsValid)
            //{
            //    // Devuelve errores de validación

            //    Respuesta respu = new Respuesta();
            //    respu.CodigoError = 2;

            //    return respu;
            //}

            Respuesta res = p_Competencia.grabaCompetencia(competencia);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{com_id}")]
        public Respuesta ro_1_4(int com_id)
        {
            Respuesta res = p_Competencia.eliminaCompetencia(com_id);
            return res;
        }
    }
}