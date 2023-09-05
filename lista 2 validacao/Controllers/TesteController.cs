using aplicativo_wb_co.Models.Request;
using aplicativo_wb_co.Models.response;
using Microsoft.AspNetCore.Mvc;

namespace aplicativo_wb_co.Controllers
{



    [ApiController]
    [Route("api/[controller]")] //[controller]
                                // é uma variavel ele substitui pelo  nome do controller 
                                //exemplo: rota / Teste
    public class TesteController : PrincipalController
    {

        [HttpGet]
        public IActionResult Get()

        //assinatura do metodo voce tem IActionResult
        //IActionResult --> Status do protcolo http


        {
            return Ok("Minha primeira request");

            //Ok() é a função de status 200 do protocolo http

            //NotFound();
            //IActionResult do 404
        }



        [HttpPost]
        public IActionResult Post(TesteViewModel testeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return ApiBadRequestResponse(ModelState);

            }
            return ApiResponse(testeViewModel, "Registro criado com sucesso!");
        }


    }
}