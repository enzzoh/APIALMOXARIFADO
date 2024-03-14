using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/departamento")]
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoController(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_departamentoRepository.GetAll());
        }

        [HttpGet]
        [Route("{id}/GetDepartamento")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_departamentoRepository.GetAll().Find(x => x.depid == id));
        }

        [HttpPut]
        [Route("GetDepartamentoUpdate")]
        public IActionResult CategoriaUpdate(Departamento categoria)
        {
            _departamentoRepository.Update(categoria);
            return Ok("Sucesso");
        }

    
        [HttpDelete]
        [Route("DeletarCategoria")]
        public IActionResult DeletarDepartamento(int produto)
        {
            var categoria = _departamentoRepository.GetAll().Find(x => x.depid == produto);

            _departamentoRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarDepartamento")]
        public IActionResult AdicionarDepartamento(Departamento produto)
        {
            try
            {
                _departamentoRepository.Add
                (
                new Departamento() { descricao = produto.descricao, ativado = produto.ativado}
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
