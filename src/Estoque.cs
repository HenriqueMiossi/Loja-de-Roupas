using System.Collections.Generic;

class Estoque
{
    List<Produto> _produtos = new List<Produto>();

    public Estoque() { }

    public void EntrarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public void SairProduto(Produto produto)
    {
        _produtos.Remove(produto);
    }

    public bool VerificarEstoqueProduto(int id)
    {
        return _produtos.Exists(produto => produto.Id == id);
    }

    public List<string> ListarEstoque()
    {
        List<string> produtosToString = new List<string>();
        foreach (Produto produto in _produtos)
        {
            produtosToString.Add(produto.ToString());
        }
        return produtosToString;
    }
}
