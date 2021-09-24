using System;
using System.Collections.Generic;

class CartaoDebito : IFormaPagamento
{
    public void geraNotaFiscal(List<Item> produtos, double precoTotal)
    {
        Dictionary<string, int> notaFiscal = new Dictionary<string, int>();

        foreach (Item item in produtos)
        {
            if(!notaFiscal.ContainsKey(item._itemName))
            {
                notaFiscal.Add(item._itemName, 1);
            }
            else 
            {
                notaFiscal[item._itemName] += 1;
            }
        }

        foreach (KeyValuePair<string, int> item in notaFiscal)
        {
            System.Console.WriteLine($"Produto: {item.Key}, quantidade: {item.Value}");
        }
        System.Console.WriteLine("Forma de pagamento: Cartão de Débito");
        System.Console.WriteLine($"Subtotal: {precoTotal}");
    }
}
