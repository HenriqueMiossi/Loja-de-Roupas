using System;
using System.Collections.Generic;


class Dinheiro : IFormaPagamento
{
    public void GeraNotaFiscal(List<Produto> produtos, double precoTotal)
    {
        Dictionary<string, int> notaFiscal = new Dictionary<string, int>();

        foreach (Produto produto in produtos)
        {
            if(!notaFiscal.ContainsKey(produto.Modelo))
            {
                notaFiscal.Add(produto.Modelo, 1);
            }
            else 
            {
                notaFiscal[produto.Modelo] += 1;
            }
        }

        foreach (KeyValuePair<string, int> produto in notaFiscal)
        {
            System.Console.WriteLine($"Produto: {produto.Key}, quantidade: {produto.Value}");
        }
        System.Console.WriteLine("Forma de pagamento: Dinheiro");
        System.Console.WriteLine($"Subtotal: {precoTotal}");
    }
}
