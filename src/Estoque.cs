using System;
using System.Collections.Generic;

namespace Loja_de_Roupas
{
    class Estoque
    {
        List<Produto> _produtos = new List<Produto>();

        public bool verificaDisponibilidade(int id) 
        {
            return true;
        }

        public void entradaProduto(Produto novoProduto) 
        {
            _produtos.Add(novoProduto);
        }

        public void saidaProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }
    }
}
