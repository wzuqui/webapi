using System.Collections.Generic;
using System.Linq;
using RavexSolution.WebApi.Entities;

namespace RavexSolution.WebApi.Produtos.Responses
{
    public class ProdutoResponse
    {
        public string Descricao { get; init; }
        public int Id { get; init; }
        public string Nome { get; init; }
        public decimal Valor { get; init; }

        public static IEnumerable<ProdutoResponse> Mapper(IEnumerable<Produto> pItens)
        {
            return pItens.Select(Mapper);
        }

        public static ProdutoResponse Mapper(Produto pItem)
        {
            return new ProdutoResponse
            {
                Id = pItem.Id
                , Nome = pItem.Nome
                , Descricao = pItem.Descricao
                , Valor = pItem.Valor
            };
        }
    }
}
