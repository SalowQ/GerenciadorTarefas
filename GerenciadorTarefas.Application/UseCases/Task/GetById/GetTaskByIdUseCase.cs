using GerenciadorTarefas.Communication.Enums;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Task.GetById
{
    public class GetTaskByIdUseCase
    {
        public ResponseTaskJson Execute(int id)
        {
            var task = new ResponseTaskJson
            {
                Id = id,
                Name = $"Atividade {id}",
                Description = $"Descrição da atividade {id}",
                Status = (Status)(id % 3),
                DueDate = DateTime.Now.AddDays(id),
                Priority = (Priority)(id % 3)
            };
            return task;
        }
}
}
