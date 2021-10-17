class Endereco
{
	public int Numero { get; set; }
	public string Bairro { get; set; }
	public string Cidade { get; set; }
	public UnidadeFederativa UnidadeFederativa { get; set; }
	public string Cep { get; set; }
	
	public Endereco(int numero, string bairro, string cidade, UnidadeFederativa unidadeFederativa, string cep)
	{
		Numero = numero;
		Bairro = bairro;
		Cidade = cidade;
		UnidadeFederativa = unidadeFederativa;
		Cep = cep;
	}

	public override string ToString()
	{
		return "Numero: " + Numero + "\nBairro: " + Bairro + "\nCidade: " + Cidade + "\nCep: " + Cep + "\nUnidadeFederativa: " + UnidadeFederativa; 
	}
}
