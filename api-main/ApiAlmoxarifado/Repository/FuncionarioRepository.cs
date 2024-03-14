using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Funcionario funcionario)
        {
            bdConexao.Add(funcionario);
            bdConexao.SaveChanges();
        }
        public List<Funcionario> GetAll()
        {
            return bdConexao.Funcionario.ToList();
        }
        public void Delete(Funcionario funcionario)
        {
            bdConexao.Remove(funcionario);
            bdConexao.SaveChanges();
        }
        public void Update(Funcionario Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }
    }
}
