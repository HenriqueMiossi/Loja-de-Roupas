using System.Collections.Generic;

interface IFormaPagamento
{
    public void geraNotaFiscal(List<Item> produtos, double precoTotal);
}
