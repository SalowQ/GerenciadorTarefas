using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Responses
{
    public class ResponseShortTaskJson
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Status Status { get; set; }
    }
}
