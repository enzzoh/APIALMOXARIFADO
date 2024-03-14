using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IRequisicaoRepository
    {
        List<Requisicao> GetAll();

        void Add(Requisicao categoria);

        void Delete(Requisicao categoria);
        void Update(Requisicao categoria);
    }
}
