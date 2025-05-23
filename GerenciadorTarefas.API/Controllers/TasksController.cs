using GerenciadorTarefas.Application.UseCases.Task.Register;
using GerenciadorTarefas.Application.UseCases.Task.Update;
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

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePet([FromRoute] int id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();

            useCase.Execute(id, request);

            return NoContent();
        }
    }


}
