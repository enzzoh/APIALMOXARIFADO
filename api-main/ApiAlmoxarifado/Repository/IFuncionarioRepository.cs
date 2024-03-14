using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IFuncionarioRepository
    {
        List<Funcionario> GetAll();

        void Add(Funcionario funcionario);

        void Update(Funcionario funcionario);
        void Delete(Funcionario funcionario);
    }
}
