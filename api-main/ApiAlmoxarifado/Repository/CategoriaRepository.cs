using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class CategoriaRepository:ICategoriaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Categoria categoria)
        {
            bdConexao.Add(categoria);
            bdConexao.SaveChanges();
        }
        public List<Categoria> GetAll()
        {
            return bdConexao.Categoria.ToList();
        }

        public void Delete(Categoria Model)
        {
            bdConexao.Remove(Model);
            bdConexao.SaveChangesAsync();
 
        }

        public void Update(Categoria Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }

    }
}
