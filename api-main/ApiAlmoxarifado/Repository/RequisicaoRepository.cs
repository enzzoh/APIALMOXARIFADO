using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class RequisicaoRepository:IRequisicaoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Requisicao produto)
        {
            bdConexao.Add(produto);
            bdConexao.SaveChanges();
        }
        public List<Requisicao> GetAll()
        {

            return bdConexao.Requisicao.ToList();
        }

        public void Update(Requisicao produto)
        {
            bdConexao.Update(produto);
            bdConexao.SaveChanges();
        }

        public void Delete(Requisicao produto)
        {
            bdConexao.Remove(produto);
            bdConexao.SaveChanges();
        }
    }
}
