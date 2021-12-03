using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RavexSolution.WebApi.Entities;
using RavexSolution.WebApi.Extensions;
using RavexSolution.WebApi.Produtos.Requests;
using RavexSolution.WebApi.Produtos.Responses;

namespace RavexSolution.WebApi.Produtos
{
    [ApiController]
    [Route("produtos")]
    public class ProdutosController : ControllerBase
    {
        private static readonly List<Produto> _produtos = new();

        [HttpDelete("{pId:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int pId)
        {
            var xRemoveu = _produtos.Remover(pId);
            return xRemoveu
                ? NoContent()
                : NotFound();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ProdutoResponse>> Get()
        {
            return Ok(ProdutoResponse.Mapper(_produtos));
        }

        [HttpGet("{pId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProdutoResponse> Get(int pId)
        {
            var xItem = _produtos.FirstOrDefault(p => p.Id == pId);
            return xItem is null
                ? NotFound()
                : Ok(ProdutoResponse.Mapper(xItem));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProdutoResponse> Post([FromBody] ProdutoAdicionarRequest pRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var xRequest = ProdutoAdicionarRequest.Mapper(pRequest);
            var xItem = _produtos.Adicionar(xRequest);
            var xResponse = ProdutoResponse.Mapper(xItem);

            return CreatedAtAction(nameof(Get)
                , new { pId = xResponse.Id }
                , xResponse);
        }

        [HttpPut("{pId:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int pId
            , [FromBody] ProdutoAtualizarRequest pRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var xItem = _produtos.Atualizar(pId
                , pRequest);
            return xItem is null
                ? NotFound()
                : NoContent();
        }
    }
}
