using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Task.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisterTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisterTaskJson
            {
                Id = 1,
                Name = request.Name
            };
        }
    }
}
