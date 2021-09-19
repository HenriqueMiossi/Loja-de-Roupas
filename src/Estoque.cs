using System;
using System.Collections.Generic;

namespace Loja_de_Roupas
{
    class Estoque
    {
        public List<Produto> _produtos = new List<Produto>();

        public bool verificaDisponibilidade(int id) 
        {
            foreach(var item in _produtos) if(item._id == id) {
                return true;
            }
            
            return false;
        }

        public void entradaProduto(Produto novoProduto) 
        {
            _produtos.Add(novoProduto);
        }

        public void saidaProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }

        public Produto getProduto(int id) 
        {
            foreach(var item in _produtos) if(item._id == id) {
                return item;
            }

            return null;
        }
    }
}
