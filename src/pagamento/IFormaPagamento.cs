using System.Collections.Generic;

interface IFormaPagamento
{
    public void geraNotaFiscal(List<Produto> produtos, double precoTotal);
}
