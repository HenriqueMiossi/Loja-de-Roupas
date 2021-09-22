using System;
using System.Collections.Generic;

class Estoque
{
    public List<Produto> _produtos = new List<Produto>();

    public bool verificarProduto(int id) 
    {
        foreach(var item in _produtos) if(item._id == id) {
            return true;
        }
        
        return false;
    }

    public void entrarProduto(Produto novoProduto) 
    {
        _produtos.Add(novoProduto);
    }

    public void sairProduto(Produto produto)
    {
        _produtos.Remove(produto);
    }

    public Produto listarProduto(int id) 
    {
        foreach(var item in _produtos) if(item._id == id) {
            return item;
        }

        return null;
    }
}
