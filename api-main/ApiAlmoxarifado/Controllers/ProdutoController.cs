using ApiAlmoxarifado.Models;
using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_produtoRepository.GetAll());
        }

        [HttpPost]
        [Route("AdicionarProdutoSemFoto")]
        public IActionResult AdicionarProdutoSemFoto(ProdutoViewModelSemFoto produto)
        {
            try
            {
                _produtoRepository.Add
                (
                new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro" + ex.Message);
            }

        }

        //[HttpPost]
        //[Route("AdicionarProdutoSemFoto")]
        //public IActionResult AdicionarProdutoComFoto([FromForm] ProdutoViewModelComFoto produto)
        //{
        //    try
        //    {
        //        var caminho = Path.Combine("Storage", produto.photourl.FileName);
        //        using Stream fileStream = new FileStream(caminho, FileMode.Create);
        //        produto.photourl.CopyTo(fileStream);
        //        _produtoRepository.Add
        //        (
        //        new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = caminho }
        //        );

        //        return Ok("Cadastrado com Sucesso");
        //    }
        //    catch (Exception ex)
        //    {

        //        return BadRequest("Não Cadastrado. Erro" + ex.Message);
        //    }

        //}

        [HttpGet]
        [Route("{id}/GetProduto")]
        public IActionResult GetProduto(int id)
        {
            return Ok(_produtoRepository.GetAll().Find(x => x.id == id));
        }

        [HttpDelete]
        [Route("DeletarProdutoSemFoto")]
        public IActionResult DeletarProdutoSemFoto(int id)
        {
            var categoria = _produtoRepository.GetAll().Find(x => x.id == id);

            _produtoRepository.Delete(categoria);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpPut]
        [Route("AtualizarProdutoSemFoto")]
        public IActionResult AtualizarProdutoSemFoto(ProdutoViewModelUpdateSemFoto produto)
        {
            Produto produtoatualizar = new Produto()
            {
                id = produto.id,
                nome = produto.nome,
                estoque = produto.estoque
            };
            _produtoRepository.Update(produtoatualizar);
            return Ok("Atualizado Com Sucesso");
        }

        [HttpGet]
        [Route("{id}/Download")]
        public IActionResult Download(int id)
        {
            try
            {
                var produto = _produtoRepository.GetAll().Find(x => x.id == id);
                if (produto.photourl == null)
                {
                    return Ok("Não existe faalta cadastrada para o Produto");
                }
                else
                {
                    var dataBytes = System.IO.File.ReadAllBytes(produto.photourl);
                    return File(dataBytes, "img/jpg");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Erro em fazer download: " + ex.Message);
                throw;
            }
        }
    }
}

