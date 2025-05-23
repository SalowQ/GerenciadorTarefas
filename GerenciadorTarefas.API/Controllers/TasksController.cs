using GerenciadorTarefas.Application.UseCases.Task.Register;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using Petfólio.Communication.Responses;

namespace GerenciadorTarefas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult CreateTask([FromBody] RequestTaskJson request)
        {
            var response = new RegisterTaskUseCase().Execute(request);

            return Created(string.Empty, response);
        }
    }
}
