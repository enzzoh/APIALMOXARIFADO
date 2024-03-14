using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();

        void Add(Categoria categoria);

        void Delete(Categoria categoria);
        void Update(Categoria categoria);
    }
}
