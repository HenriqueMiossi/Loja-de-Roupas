class Endereco
{
	public string Nome { get; set; }
	public int Numero { get; set; }
	public string Bairro { get; set; }
	public string Cidade { get; set; }
	UnidadeFederativa unidadeFederativa;
	// public UnidadeFederativa UnidadeFederativa { get; set; }
	public string Cep { get; set; }
	
	public Endereco(string nome, int numero, string bairro, string cidade, UnidadeFederativa unidadeFederativa, string cep)
	{
		Nome = nome;
		Numero = numero;
		Bairro = bairro;
		Cidade = cidade;
		this.unidadeFederativa = unidadeFederativa;
		Cep = cep;
	}

	public override string ToString()
	{
		return "Nome: " + Nome + "\nNumero: " + Numero + "\nBairro: " + Bairro + "\nCidade: " + Cidade + "\nCep: " + Cep + "\nUnidadeFederativa: " + unidadeFederativa; 
	}
}

