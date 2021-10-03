class Vendedor
{
    public double Salario { get; set; }
    public int Matricula { get; set; }

    public Vendedor(double salario, int matricula)
    {
        Salario = salario;
        Matricula = matricula;
    }

    public override string ToString()
	{
		return "Salario" + Salario + "\n Matricula" + Matricula; 
	}
}