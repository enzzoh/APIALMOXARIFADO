using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_funcionarioRepository.GetAll());
        }


        [HttpGet]
        [Route("{id}/GetFuncionario")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_funcionarioRepository.GetAll().Find(x => x.funcID == id));
        }

        [HttpPut]
        [Route("GetFuncionarioUpdate")]
        public IActionResult Update(Funcionario categoria)
        {
            _funcionarioRepository.Update(categoria);
            return Ok("Sucesso");
        }

        [HttpDelete]
        [Route("DeletarCategoria")]
        public IActionResult DeletarDepartamento(int produto)
        {
            var categoria = _funcionarioRepository.GetAll().Find(x => x.funcID == produto);

            _funcionarioRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarDepartamento")]
        public IActionResult AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                _funcionarioRepository.Add
                (
                new Funcionario() { nome = funcionario.nome, cargo = funcionario.cargo, dataNascimento = funcionario.dataNascimento,
                    salario = funcionario.salario, endereço = funcionario.endereço, cidade = funcionario.cidade, uf = funcionario.uf }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro" + ex.Message);
            }

        }
    }
}
