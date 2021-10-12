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
	
	public Venda(int id, double valor, IFormaPagamento formaPagamento, List<Produto> produtos, Cliente cliente, Vendedor vendedor)
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
		return "Id: " + Id + "\nValor: " + Valor + "\nFormaPagamento: " + FormaPagamento + "\nProdutos: " + _produtos + "\nCliente: " + Cliente + "\nVendedor: " + Vendedor; 
	}
}
