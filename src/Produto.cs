class Produto
{
	public int Id { get; set; }
	public string Categoria { get; set; }
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public double Preco { get; set; }

	public Produto(int id, string categoria, string marca, string modelo, double preco) 
	{
		Id = id;
		Categoria = categoria;
		Marca = marca;
		Modelo = modelo;
		Preco = preco;
	}

	public override string ToString()
	{
		return "Id: " + Id + "\nCategoria: " + Categoria + "\nMarca: " + Marca + "\nModelo: " + Modelo + "Preço: " + Preco;
	}
}

