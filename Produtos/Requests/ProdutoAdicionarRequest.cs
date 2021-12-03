using RavexSolution.WebApi.DataAnnotations;
using RavexSolution.WebApi.Entities;

namespace RavexSolution.WebApi.Produtos.Requests
{
    public class ProdutoAdicionarRequest
    {
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(2000)]
        public string Descricao { get; set; }

        [Range(0, 1000)]
        public decimal Valor { get; set; }

        public static Produto Mapper(ProdutoAdicionarRequest pRequest)
        {
            return new Produto
            {
                Nome = pRequest.Nome,
                Descricao = pRequest.Descricao,
                Valor = pRequest.Valor
            };
        }
    }
}