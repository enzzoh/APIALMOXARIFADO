using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class ProdutoRepository:IProdutoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Produto produto)
        {
            bdConexao.Add(produto);
            bdConexao.SaveChanges();
        }
        public List<Produto> GetAll()
        {
            
            return bdConexao.Produto.ToList();
        }

        public void Update(Produto produto)
        {
            bdConexao.Update(produto);
            bdConexao.SaveChanges();
        }

        public void Delete(Produto produto)
        {
            bdConexao.Remove(produto);
            bdConexao.SaveChanges();
        }
    }
}
