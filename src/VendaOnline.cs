using System;
using System.Collections.Generic;

class VendaOnline : Venda
{
    List<Produto> _produtos = new List<Produto>();
    public ITipoEntrega TipoEntrega { get; set; }
    
    public VendaOnline(double valor, IFormaPagamento formaPagamento, List<Produto> produtos, Cliente cliente, Vendedor vendedor, ITipoEntrega tipoEntrega)
    : base(valor, formaPagamento, produtos, cliente, vendedor)
    {
        var random = new Random();
		Id = random.Next(100000000, 999999999);
		
        Valor = valor;
        FormaPagamento = formaPagamento;
        _produtos = produtos;
        Cliente = cliente;
        Vendedor = vendedor;
        TipoEntrega = tipoEntrega;
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
