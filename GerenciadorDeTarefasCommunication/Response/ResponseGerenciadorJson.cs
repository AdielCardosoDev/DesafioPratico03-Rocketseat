using GerenciadorDeTarefasCommunication.Enums;

namespace GerenciadorDeTarefasCommunication.Response
{
    public class ResponseGerenciadorJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public TarefasPrioridade Prioridade { get; set; }
        public DateTime DataTarefa { get; set; }
        public Status Status { get; set; }
    }
}
