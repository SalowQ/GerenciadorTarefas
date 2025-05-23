using GerenciadorTarefas.Application.UseCases.Task.Delete;
using GerenciadorTarefas.Application.UseCases.Task.GetAll;
using GerenciadorTarefas.Application.UseCases.Task.GetById;
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

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllPets()
        {
            var response = new GetAllTasksUseCase().Execute();

            if (response.Tasks.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var response = new GetTaskByIdUseCase().Execute(id);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskByIdUseCase();

            useCase.Execute(id);

            return NoContent();
        }
    }


}
