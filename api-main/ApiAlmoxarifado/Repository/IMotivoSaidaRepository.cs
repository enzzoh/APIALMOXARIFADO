using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IMotivoSaidaRepository
    {
        List<MotivoSaida> GetAll();

        void Add(MotivoSaida categoria);

        void Delete(MotivoSaida categoria);
        void Update(MotivoSaida categoria);
    }
}
