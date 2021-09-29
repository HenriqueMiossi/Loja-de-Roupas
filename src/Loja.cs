class Loja
{
    public string Cnpj { get; }
    public string NomeFantasia { get; set; }
    public string NomePropietario { get; set; }
    public Endereco Endereco { get; set; }
    public Estoque Estoque { get; set; }

    public Loja(string cnpj, string nomeFantasia, string nomePropietario, Endereco endereco, Estoque estoque) 
    {
	Cnpj = cnpj;
	NomeFantasia = nomeFantasia;
	NomePropietario = nomePropietario;
	Endereco = endereco;
	Estoque  = estoque;
    }

    public override string ToString()
    {
	return "Cnpj: " + Cnpj + "\nNomeFantasia: " + NomeFantasia + "\nNomePropietario: " + NomePropietario + "\n" + Endereco.ToString();
    }
}
