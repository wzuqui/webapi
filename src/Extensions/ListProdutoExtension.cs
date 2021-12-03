using System.Collections.Generic;
using System.Linq;
using RavexSolution.WebApi.Entities;
using RavexSolution.WebApi.Produtos.Requests;

namespace RavexSolution.WebApi.Extensions
{
    public static class ListProdutoExtension
    {
        public static Produto Adicionar(this List<Produto> pItens
            , Produto pItem)
        {
            var xId = pItens.Count + 1;
            pItem.Id = xId;
            pItens.Add(pItem);
            return pItem;
        }

        public static Produto Atualizar(this IEnumerable<Produto> pItens
            , int pId
            , ProdutoAtualizarRequest pItem)
        {
            var xPersistido = pItens.FirstOrDefault(p => p.Id == pId);
            if (xPersistido == null) // FailFast
                return null;

            xPersistido.Nome = pItem.Nome;
            xPersistido.Descricao = pItem.Descricao;
            xPersistido.Valor = pItem.Valor;
            return xPersistido;
        }

        public static bool Remover(this List<Produto> pItens
            , int pId)
        {
            var xPersistido = pItens.FirstOrDefault(p => p.Id == pId); // proposital, pois parece com repository

            // legibilidade
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (xPersistido == null) // FailFast
                return false;
            return pItens.Remove(xPersistido);
        }
    }
}
