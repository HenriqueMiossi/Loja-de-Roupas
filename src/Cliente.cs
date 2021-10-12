using System.Collections.Generic;

class Cliente
{
    List<Venda> _historicoCompras = new List<Venda>();

    public List<Venda> getHistoricoCompras()
    {
        return _historicoCompras;
    }

    public void addCompra(Venda novaVenda)
    {
        _historicoCompras.Add(novaVenda);
    }
}
