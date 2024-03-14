using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IDepartamentoRepository
    {
        List<Departamento> GetAll();

        void Add(Departamento departamento);
        void Update(Departamento departamento);
        void Delete(Departamento departamento);
    }
}
