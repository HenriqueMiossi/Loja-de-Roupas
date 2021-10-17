using System;
using System.Collections.Generic;

class VendaOnline : Venda
{
    List<Produto> _produtos = new List<Produto>();
    
    public VendaOnline(int id, double valor, IFormaPagamento formaPagamento, List<Produto> produtos, Cliente cliente, Vendedor vendedor)
    : base(id, valor, formaPagamento, produtos, cliente, vendedor)
    {
        Id = id;
        Valor = valor;
        FormaPagamento = formaPagamento;
        _produtos = produtos;
        Cliente = cliente;
        Vendedor = vendedor;
    }

    public override string ToString()
    {
        string listaProdutos = "";
		foreach (Produto produto in _produtos)
		{
			listaProdutos = listaProdutos + $"\n- {produto.Marca} {produto.Modelo}";
		}

        return "Tipo de Venda: Venda Online" + "\nId: " + Id + "\nValor: " + Valor + "\nForma de Pagamento: " + FormaPagamento + "\nProdutos: " + listaProdutos + "\nCliente: " + Cliente.getNome() + "\nVendedor: " + Vendedor.getNome();
    }
}
