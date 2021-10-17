using System;

class EntregaExpressa : ITipoEntrega
{
	public int CodigoRastreio { get; set; }

	public EntregaExpressa()
	{
		var random = new Random();
		CodigoRastreio = random.Next(100000000, 999999999);
	}

	public void despachar()
	{
		System.Console.WriteLine("Produto despachado como Entrega Expressa.");
		System.Console.WriteLine($"Código de Rastreio: {CodigoRastreio}");
	}

    public int getCodigoRastreamento()
	{
		return CodigoRastreio;
	}
}
