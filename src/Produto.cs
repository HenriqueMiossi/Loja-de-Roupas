using System;
using System.Collections.Generic;

namespace Loja_de_Roupas
{
    class Produto
    {
        public int _id { get; set; }
        public string _nome { get; set; }
        public double _preco { get; set; }
        List<Item> _itens = new List<Item>();

        public bool verificaQuantidade(int id) 
        {
            return true;
        }
        public void adicionaItem(Item novoItem) 
        {
            _itens.Add(novoItem);
        }

        public void removeItem(Item item)
        {
            _itens.Remove(item);
        }
    }
}
