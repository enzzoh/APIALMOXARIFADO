using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class DepartamentoRepository:IDepartamentoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Departamento departamento)
        {
            bdConexao.Add(departamento);
            bdConexao.SaveChanges();
        }
        public List<Departamento> GetAll()
        {
            return bdConexao.Departamento.ToList();
        }

        public void Delete(Departamento departamento)
        {
            bdConexao.Remove(departamento);
            bdConexao.SaveChanges();
        }

        public void Update(Departamento Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }
    }
}
