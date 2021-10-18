using System.Collections.Generic;

class Estoque
{
    List<Produto> Produtos = new List<Produto>();

    public void EntrarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void SairProduto(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public bool VerificarEstoqueProduto(int id)
    {
        return Produtos.Exists(produto => produto.Id == id);
    }

    public List<string> ListarEstoque()
    {
        List<string> produtosToString = new List<string>();
        foreach (Produto produto in Produtos)
        {
            produtosToString.Add(produto.Marca + " - " + produto.Modelo);
        }
        return produtosToString;
    }

    public Produto CompraProduto(int indice)
    {
        if (VerificarEstoqueProduto(Produtos[indice].Id))
        {
            Produto produto = Produtos[indice];
            SairProduto(produto);

            return produto;
        }
        else
            return null;
    }
}
