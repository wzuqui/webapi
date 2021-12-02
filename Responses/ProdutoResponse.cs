using System.Collections.Generic;
using System.Linq;
using RavexSolution.WebApi.Entities;

namespace RavexSolution.WebApi.Responses
{
    public class ProdutoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public static IEnumerable<ProdutoResponse> Mapper(IEnumerable<Produto> pItens)
        {
            return pItens.Select(Mapper);
        }

        public static ProdutoResponse Mapper(Produto pItem)
        {
            return new ProdutoResponse
            {
                Id = pItem.Id,
                Nome = pItem.Nome,
                Descricao = pItem.Descricao,
                Valor = pItem.Valor
            };
        }
    }
}