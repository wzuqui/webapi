using RavexSolution.WebApi.DataAnnotations;
using RavexSolution.WebApi.Entities;

namespace RavexSolution.WebApi.Produtos.Requests
{
    public class ProdutoAdicionarRequest
    {
        [StringLength(2000)]
        public string Descricao { get; init; }

        [Required]
        [StringLength(200)]
        public string Nome { get; init; }

        [Range(0, int.MaxValue)]
        public decimal Valor { get; init; }

        public static Produto Mapper(ProdutoAdicionarRequest pRequest)
        {
            return new Produto
            {
                Nome = pRequest.Nome
                , Descricao = pRequest.Descricao
                , Valor = pRequest.Valor
            };
        }
    }
}
