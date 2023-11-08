using TarefasBlazor.Entidades;

namespace TarefasBlazor.Repositories
{
    public interface IRepository
    {
        List<Tarefa> ObterTarefa();
    }
}
