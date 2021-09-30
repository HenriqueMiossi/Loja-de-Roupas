using System;
using System.Collections.Generic;

class CartaoDebito : IFormaPagamento
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

        foreach (KeyValuePair<string, int> Produto in notaFiscal)
        {
            System.Console.WriteLine($"Produto: {Produto.Key}, quantidade: {Produto.Value}");
        }
        System.Console.WriteLine("Forma de pagamento: Cartão de Débito");
        System.Console.WriteLine($"Subtotal: {precoTotal}");
    }
}
