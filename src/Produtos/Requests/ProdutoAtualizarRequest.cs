using RavexSolution.WebApi.DataAnnotations;

namespace RavexSolution.WebApi.Produtos.Requests
{
    public class ProdutoAtualizarRequest
    {
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(2000)]
        public string Descricao { get; set; }

        [Range(0, 1000)]
        public decimal Valor { get; set; }
    }
}