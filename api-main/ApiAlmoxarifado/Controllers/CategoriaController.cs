using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

     
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_categoriaRepository.GetAll());
        }



        [HttpGet]
        [Route("{id}/GetCategoria")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_categoriaRepository.GetAll().Find(x => x.categoriaid == id));
        }

        [HttpPut]
        [Route("GetCategoriaUpdate")]
        public IActionResult Update(Categoria categoria)
        {
            _categoriaRepository.Update(categoria);
            return Ok("Sucesso"); 
        }



        [HttpDelete]
        [Route("DeletarCategoria")]
        public IActionResult DeletarProdutoSemFoto(int produto)
        {
            var categoria = _categoriaRepository.GetAll().Find(x => x.categoriaid == produto);

            _categoriaRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarCategoria")]
        public IActionResult AdicionarCategoria(Categoria produto)
        {
            try
            {
                _categoriaRepository.Add
                (
                new Categoria() { descricao = produto.descricao}
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
