using RavexSolution.WebApi.DataAnnotations;

namespace RavexSolution.WebApi.Controllers.Produtos.Requests
{
    public class ProdutoAtualizarRequest
    {
        [Required]
        [StringLength(200)]
        public string Nome { get; init; }

        [StringLength(2000)]
        public string Descricao { get; init; }

        [Range(0, int.MaxValue)]
        public decimal Valor { get; init; }
    }
}
