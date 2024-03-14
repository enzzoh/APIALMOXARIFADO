using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/categoriamotivo")]
    public class CategoriaMotivoController : Controller
    {
        private readonly ICategoriaMotivoRepository _categoriaMotivoRepository;

        public CategoriaMotivoController(ICategoriaMotivoRepository categoriaRepository)
        {
            _categoriaMotivoRepository = categoriaRepository;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_categoriaMotivoRepository.GetAll());
        }



        [HttpGet]
        [Route("{id}/GetCategoriaMotivo")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_categoriaMotivoRepository.GetAll().Find(x => x.camID == id));
        }

        [HttpPut]
        [Route("GetCategoriaMotivoUpdate")]
        public IActionResult Update(CategoriaMotivo categoria)
        {
            _categoriaMotivoRepository.Update(categoria);
            return Ok("Sucesso");
        }



        [HttpDelete]
        [Route("DeletarCategoriaMotivo")]
        public IActionResult DeletarProdutoSemFoto(int produto)
        {
            var categoria = _categoriaMotivoRepository.GetAll().Find(x => x.camID == produto);

            _categoriaMotivoRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarCategoriaMotivo")]
        public IActionResult AdicionarCategoria(CategoriaMotivo produto)
        {
            try
            {
                _categoriaMotivoRepository.Add
                (
                new CategoriaMotivo() { camDescricao = produto.camDescricao }
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
