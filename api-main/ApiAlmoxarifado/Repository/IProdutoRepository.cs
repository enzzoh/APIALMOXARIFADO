using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();

        void Add (Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
    }
}
