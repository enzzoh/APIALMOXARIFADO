using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/motivosaida")]
    public class MotivoSaidaController : Controller
    {
        private readonly IMotivoSaidaRepository _motivosaidaRepository;

        public MotivoSaidaController(IMotivoSaidaRepository categoriaRepository)
        {
            _motivosaidaRepository = categoriaRepository;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_motivosaidaRepository.GetAll());
        }



        [HttpGet]
        [Route("{id}/GetCategoria")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_motivosaidaRepository.GetAll().Find(x => x.motID == id));
        }

        [HttpPut]
        [Route("GetCategoriaUpdate")]
        public IActionResult Update(MotivoSaida categoria)
        {
            _motivosaidaRepository.Update(categoria);
            return Ok("Sucesso");
        }



        [HttpDelete]
        [Route("DeletarCategoria")]
        public IActionResult DeletarProdutoSemFoto(int produto)
        {
            var categoria = _motivosaidaRepository.GetAll().Find(x => x.motID == produto);

            _motivosaidaRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarCategoria")]
        public IActionResult AdicionarCategoria(MotivoSaida produto)
        {
            try
            {
                _motivosaidaRepository.Add
                (
                new MotivoSaida() { motDescricao = produto.motDescricao, categoriaid = produto.categoriaid }
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
