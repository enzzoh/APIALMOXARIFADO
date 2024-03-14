using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface ICategoriaMotivoRepository
    {
        List<CategoriaMotivo> GetAll();

        void Add(CategoriaMotivo categoria);

        void Delete(CategoriaMotivo categoria);
        void Update(CategoriaMotivo categoria);
    }
}
