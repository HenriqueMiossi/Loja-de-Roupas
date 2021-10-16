using System.Collections.Generic;

class Cliente : Pessoa
{
    List<Venda> _historicoCompras = new List<Venda>();

    public Cliente(string nome, string cpf, string email, Endereco endereco, int telefone)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.email = email;
        this.endereco = endereco;
        this.telefone = telefone;
    }

    public List<Venda> getHistoricoCompras()
    {
        return _historicoCompras;
    }

    public void addCompra(Venda novaVenda)
    {
        _historicoCompras.Add(novaVenda);
    }

    public override string ToString()
    {
        return "Nome: " + nome + "\nCPF: " + cpf + "\nEmail: " + email + "\nEndereço: " + endereco + "\nTelefone: " + telefone;
    }

    public string getNome()
    {
        return nome;
    }
}
