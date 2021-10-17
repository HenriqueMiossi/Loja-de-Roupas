using System;

interface IPersistencia
{
	public string Serializar(Object objeto);
    public void SalvarJson(string jsonString, string nomeArquivo);
	public string BuscarJson(string nomeArquivo, string nomeObjeto);
}
