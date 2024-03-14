using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/requisicao")]
    public class RequisicaoController : Controller
    {
        private readonly IRequisicaoRepository _requisicaoRepository;


        public RequisicaoController(IRequisicaoRepository categoriaRepository)
        {
            _requisicaoRepository = categoriaRepository;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_requisicaoRepository.GetAll());
        }



        [HttpGet]
        [Route("{id}/GetCategoriaMotivo")]
        public IActionResult GetCategoria(int id)
        {
            return Ok(_requisicaoRepository.GetAll().Find(x => x.reqID == id));
        }

        [HttpPut]
        [Route("GetCategoriaMotivoUpdate")]
        public IActionResult Update(Requisicao categoria)
        {
            _requisicaoRepository.Update(categoria);
            return Ok("Sucesso");
        }



        [HttpDelete]
        [Route("DeletarCategoriaMotivo")]
        public IActionResult DeletarProdutoSemFoto(int produto)
        {
            var categoria = _requisicaoRepository.GetAll().Find(x => x.reqID == produto);

            _requisicaoRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPost]
        [Route("AdicionarCategoriaMotivo")]
        public IActionResult AdicionarCategoria(Requisicao produto)
        {
            try
            {
                _requisicaoRepository.Add
                (
                new Requisicao() { reqData = produto.reqData, reqObservacao = produto.reqObservacao }
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
