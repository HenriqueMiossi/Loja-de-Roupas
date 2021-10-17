using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

class static Persistencia
{
	public static string nomePasta = @"json";
	private static string path;

	public static string Serializar(Object objeto)
	{
		return JsonSerializer.Serialize(objeto);
	}

	public static void SalvarJson(string nomeArquivo, string jsonString)
	{
		nomeArquivo = $"{nomeArquivo}.json";
		path = Path.Combine(nomePasta, nomeArquivo);
		try
		{
			if(!Directory.Exists(nomePasta))
			{
				Directory.CreateDirectory(nomePasta);
				File.WriteAllText(path, jsonString);
			}
			File.WriteAllText(path, jsonString);
		}
		catch (Exception e)
		{
			throw new ArgumentException("O processo falhou: ", e);
		}
	}

	public static string BuscarJson(string nomeArquivo)
	{
		string path;
		string jsonString;

		path = Path.Combine(nomePasta, nomeArquivo);
		jsonString = File.ReadAllText(path);

		return jsonString;
	}
}
