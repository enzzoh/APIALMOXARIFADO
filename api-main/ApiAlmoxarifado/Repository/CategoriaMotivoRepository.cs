using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class CategoriaMotivoRepository:ICategoriaMotivoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(CategoriaMotivo categoria)
        {
            bdConexao.Add(categoria);
            bdConexao.SaveChanges();
        }
        public List<CategoriaMotivo> GetAll()
        {
            return bdConexao.CategoriaMotivo.ToList();
        }

        public void Delete(CategoriaMotivo Model)
        {
            bdConexao.Remove(Model);
            bdConexao.SaveChangesAsync();

        }

        public void Update(CategoriaMotivo Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }

    }
}
