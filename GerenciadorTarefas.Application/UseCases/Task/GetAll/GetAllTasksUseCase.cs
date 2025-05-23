using GerenciadorTarefas.Communication.Enums;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Task.GetAll
{
    public class GetAllTasksUseCase
    {
        public ResponseAllTasksJson Execute()
        {
            var response = new ResponseAllTasksJson
            {
                Tasks = new List<ResponseShortTaskJson>()
            };
            // Simulate fetching tasks from a database or repository
            for (int i = 1; i <= 10; i++)
            {
                response.Tasks.Add(new ResponseShortTaskJson
                {
                    Id = i,
                    Title = $"Atividade {i}",
                    Status = (Status)(i % 3) // Simulate different statuses
                });
            }
            return response;
        }
    }
}
