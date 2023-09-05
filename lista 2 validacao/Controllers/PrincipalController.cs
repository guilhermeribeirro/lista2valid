using aplicativo_wb_co.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace aplicativo_wb_co.Controllers
{
    public abstract class PrincipalController : ControllerBase
    {
        protected IActionResult ApiResponse<T>(T data, string message = null)
        {
            var response = new RetornoApiCustomizado<T>
            {
                Sucesso = true,
                Mensagem = message,
                Dados = data,
                Status =200
            };
            return Ok(response);
        }

        protected IActionResult ApiBadRequestResponse(ModelStateDictionary modelState, string message = "Dados inválidos")
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            var response = new RetornoApiCustomizado< object>
            {
                Sucesso = false,
                Mensagem = message,
                Dados = erros.Select(n => n.ErrorMessage).ToArray(),
                Status = 500
            };
            return BadRequest(response);
        }


    }
}
