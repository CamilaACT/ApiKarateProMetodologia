using ApiKaratePro.model.proc;
using ApiKaratePro.model.Request;
using ApiKaratePro.model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiKaratePro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RangoController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta rol_1_1()
        {
            Respuesta res = p_Rango.consultaTodoRango();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta ro_1_2([FromBody] rango_A_rango rango)
        {

            Respuesta res = p_Rango.actualizaRango(rango);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] rango_A_rango rango)
        {

            Respuesta res = p_Rango.grabaRango(rango);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{ran_id}")]
        public Respuesta ro_1_4(int ran_id)
        {
            Respuesta res = p_Rango.eliminaRango(ran_id);
            return res;
        }
    }
}
