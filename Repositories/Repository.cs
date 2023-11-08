using TarefasBlazor.Entidades;

namespace TarefasBlazor.Repositories
{
    public class Repository : IRepository
    {
        public List<Tarefa> ObterTarefa()
        {
            return new List<Tarefa>()
            {
                new Tarefa
                {
                    Id = new Guid("f0dcda47-1f23-4538-92e0-a47dcdcc7850"),
                    Descricao = "Fazer o curso",
                    Concluida = false,
                    DataCriacao = new DateTime(2019, 08, 11)
                },
                new Tarefa
                {
                    Id = new Guid("d21b0f7e-a5a9-45ee-ad9b-eafd911e22fa"),
                    Descricao = "Comprar o curso",
                    Concluida = false,
                    DataCriacao = new DateTime(2019, 08, 05)
                }
            };
        }
    }
}