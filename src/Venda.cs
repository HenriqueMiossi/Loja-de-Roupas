using System;
using System.Collections.Generic;

class Venda
{
	List<Produto> _produtos = new List<Produto>();
	public int Id;
	public double Valor;
	public IFormaPagamento FormaPagamento;
	public Cliente Cliente;
	public Vendedor Vendedor;
	
	public Venda(double valor, IFormaPagamento formaPagamento, List<Produto> produtos, Cliente cliente, Vendedor vendedor)
	{
		var random = new Random();
		Id = random.Next(100000000, 999999999);
		
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

		return "Tipo de Venda: Venda Normal" + "\nId: " + Id + "\nValor: " + Valor + "\nForma de Pagamento: " + FormaPagamento + "\nProdutos: " + listaProdutos + "\nCliente: " + Cliente.getNome() + "\nVendedor: " + Vendedor.getNome(); 
	}
}
