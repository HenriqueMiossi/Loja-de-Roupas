using System;
using System.Collections.Generic;

class Produto
{
    public int _id { get; set; }
    public string _nome { get; set; }
    public double _preco { get; set; }
    List<Item> _itens = new List<Item>();

    public Produto(int id, string nome, double preco) 
    {
        this._id = id;
        this._nome = nome;
        this._preco = preco;
    }
    public int verificaQuantidade() 
    {
        int quantidade = 0;

        foreach(var item in _itens) quantidade++;
        
        return quantidade;
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
