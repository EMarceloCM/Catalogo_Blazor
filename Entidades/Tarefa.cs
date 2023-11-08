namespace TarefasBlazor.Entidades
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
