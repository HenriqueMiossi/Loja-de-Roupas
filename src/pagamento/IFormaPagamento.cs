using System.Collections.Generic;

interface IFormaPagamento
{
    public void GeraNotaFiscal(List<Produto> produtos, double precoTotal);
}
