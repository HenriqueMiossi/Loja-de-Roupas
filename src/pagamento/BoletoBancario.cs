using System;
using System.Collections.Generic;

class BoletoBancario : IFormaPagamento
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

        foreach (KeyValuePair<string, int> item in notaFiscal)
        {
            System.Console.WriteLine($"Produto: {item.Key}, quantidade: {item.Value}");
        }
        System.Console.WriteLine("Forma de pagamento: Boleto Bancário");
        System.Console.WriteLine($"Subtotal: {precoTotal}");
    }
}
