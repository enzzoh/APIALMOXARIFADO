using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class MotivoSaidaRepository:IMotivoSaidaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(MotivoSaida produto)
        {
            bdConexao.Add(produto);
            bdConexao.SaveChanges();
        }
        public List<MotivoSaida> GetAll()
        {

            return bdConexao.MotivoSaida.ToList();
        }

        public void Update(MotivoSaida produto)
        {
            bdConexao.Update(produto);
            bdConexao.SaveChanges();
        }

        public void Delete(MotivoSaida produto)
        {
            bdConexao.Remove(produto);
            bdConexao.SaveChanges();
        }
    }
}
