using GerenciadorDeTarefasApplication.UseCase.Delete;
using GerenciadorDeTarefasApplication.UseCase.GetAll;
using GerenciadorDeTarefasApplication.UseCase.Register;
using GerenciadorDeTarefasApplication.UseCase.Update;
using GerenciadorDeTarefasCommunication.Response;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenciadorController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterGerenciadorJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] ResponseGerenciadorJson request)
        {
            var useCase = new RegisterGerenciadorUserCase().Executar(request);

            return Created(string.Empty, useCase);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update(int id, [FromBody] ResponseGerenciadorJson request)
        {
            var userCase = new UpdateGerenciadorUserCase();

            userCase.Executar(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllGerenciador), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var userCase = new GetAllUserCase();

            userCase.Executar();

            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseAllGerenciadorJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseGerenciadorJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteGeranciadorByIdUserCase();

            useCase.Execute(id);

            return NoContent();
        }
    }
}
