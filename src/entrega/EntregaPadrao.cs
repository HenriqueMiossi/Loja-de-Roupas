using System;

class EntregaPadrao : ITipoEntrega
{
	public int CodigoRastreio { get; set; }

	public EntregaPadrao()
	{
		var random = new Random();
		CodigoRastreio = random.Next(100000000, 999999999);
	}

	public void despachar()
	{
		System.Console.WriteLine("Produto despachado como Entrega Padrão.");
		System.Console.WriteLine($"Código de Rastreio: {CodigoRastreio}");
	}

    public int getCodigoRastreamento()
	{
		return CodigoRastreio;
	}
}
