class Venda
{
	public int Id
	public double Valor
	public IFormaPagamento FormaPagamento
	public List Produtos
	public Cliente Cliente
	public Vendedor Vendedor
	
	public Venda(int Id, double Valor, IFormaPagamento FormaPagamento, Produtos Produtos, Cliente Cliente, Vendedor Vendedor)
	{
		Id = id;
		Valor = valor;
		FormaPagamento = formaPagamento;
		Produtos = produto;
		Cliente = cliente;
		Vendedor = vendedor;
	}

	public override string ToString()
	{
		return "Id: " + Id + "\nValor: " + Valor + "\nFormaPagamento: " + FormaPagamento + "\nProdutos: " + Produtos + "\nCliente: " + Cliente + "\nVendedor: " + Vendedor; 
	}
}
