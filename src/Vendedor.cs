class Vendedor : Pessoa
{
    public double Salario { get; set; }
    public int Matricula { get; set; }

    public Vendedor(double salario, int matricula, string nome, string cpf, string email, Endereco endereco, int telefone)
    {
        Salario = salario;
        Matricula = matricula;

        this.nome = nome;
        this.cpf = cpf;
        this.email = email;
        this.endereco = endereco;
        this.telefone = telefone;
    }

    public override string ToString()
    {
        return "Salario: " + Salario + "\n Matricula: " + Matricula;
    }

    public string getNome()
    {
        return nome;
    }
}
