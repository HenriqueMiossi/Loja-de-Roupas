using System;
using System.Collections.Generic;

class Cli
{
    public void getArquivoSave()
    {
        // Chamar classe de persistência, método para ler o JSON
        // Converter a string de JSON para objeto(s)
    }

    public void salvaArquivo()
    {
        // Chamar classe de persistência, método para gravar o JSON
    }

    public Produto cadastraProduto()
    {
        System.Console.Write("Insira a categoria: ");
        string categoria = Console.ReadLine();

        System.Console.Write("Insira a marca: ");
        string marca = Console.ReadLine();

        System.Console.Write("Insira o modelo: ");
        string modelo = Console.ReadLine();
        
        System.Console.Write("Insira o preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        var random = new Random();
		int id = random.Next(100000000, 999999999);

        return new Produto(id, categoria, marca, modelo, preco);
    }

    UnidadeFederativa cadastraUF()
    {
        string uf = Console.ReadLine();

        if (uf == "AC")
            return UnidadeFederativa.AC;
        
        else if (uf == "AL")
            return UnidadeFederativa.AL;
        
        else if (uf == "AM")
            return UnidadeFederativa.AM;
            
        else if (uf == "AP")
            return UnidadeFederativa.AP;
        
        else if (uf == "BA")
            return UnidadeFederativa.BA;
        
        else if (uf == "CE")
            return UnidadeFederativa.CE;
        
        else if (uf == "DF")
            return UnidadeFederativa.DF;

        else if (uf == "ES")
            return UnidadeFederativa.ES;

        else if (uf == "GO")
            return UnidadeFederativa.GO;

        else if (uf == "MA")
            return UnidadeFederativa.MA;

        else if (uf == "MG")
            return UnidadeFederativa.MG;

        else if (uf == "MS")
            return UnidadeFederativa.MS;

        else if (uf == "MT")
            return UnidadeFederativa.MT;

        else if (uf == "PA")
            return UnidadeFederativa.PA;

        else if (uf == "PB")
            return UnidadeFederativa.PB;

        else if (uf == "PE")
            return UnidadeFederativa.PE;

        else if (uf == "PI")
            return UnidadeFederativa.PI;

        else if (uf == "PR")
            return UnidadeFederativa.PR;

        else if (uf == "RJ")
            return UnidadeFederativa.RJ;

        else if (uf == "RN")
            return UnidadeFederativa.RN;
        
        else if (uf == "RO")
            return UnidadeFederativa.RO;

        else if (uf == "RR")
            return UnidadeFederativa.RR;

        else if (uf == "RS")
            return UnidadeFederativa.RS;

        else if (uf == "SC")
            return UnidadeFederativa.SC;

        else if (uf == "SE")
            return UnidadeFederativa.SE;

        else if (uf == "SP")
            return UnidadeFederativa.SP;

        else if (uf == "TO")
            return UnidadeFederativa.TO;

        else
            throw new ApplicationException("UF inválida");
    }

    Endereco cadastraEndereco()
    {
        System.Console.Write("Insira o número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Insira o bairro: ");
        string bairro = Console.ReadLine();
        
        System.Console.Write("Insira a cidade: ");
        string cidade = Console.ReadLine();

        System.Console.Write("Insira o CEP: ");
        string cep = Console.ReadLine();

    
        System.Console.Write("Insira a UF: ");
        UnidadeFederativa unidadeFederativa = cadastraUF();

        return new Endereco(numero, bairro, cidade, unidadeFederativa, cep);
    }

    public Cliente cadastraCliente()
    {
        System.Console.Write("Insira o nome: ");
        string nome = Console.ReadLine();

        System.Console.Write("Insira o cpf: ");
        string cpf = Console.ReadLine();

        System.Console.Write("Insira o email: ");
        string email = Console.ReadLine();

        System.Console.Write("Insira o telefone: ");
        int telefone = Convert.ToInt32(Console.ReadLine());

        Endereco endereco = cadastraEndereco();

        return new Cliente(nome, cpf, email, endereco, telefone);
    }

    public Vendedor cadastraVendedor()
    {
        System.Console.Write("Insira o telefone: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Insira o telefone: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Insira o nome: ");
        string nome = Console.ReadLine();

        System.Console.Write("Insira o cpf: ");
        string cpf = Console.ReadLine();

        System.Console.Write("Insira o email: ");
        string email = Console.ReadLine();

        System.Console.Write("Insira o telefone: ");
        int telefone = Convert.ToInt32(Console.ReadLine());

        Endereco endereco = cadastraEndereco();

        return new Vendedor(salario, matricula, nome, cpf, email, endereco, telefone);
    }

    IFormaPagamento selecionaFormaPagamento()
    {
        System.Console.Write("Selecione a forma de pagamento" + 
            "(1 = Boleto Bancário, 2 = Cartão de Crédito, 3 = Cartão de Débito, 4 = Dinheiro): ");

        string tipoPagamento = Console.ReadLine();

        if (tipoPagamento == "1")
            return new BoletoBancario();
        else if (tipoPagamento == "2")
            return new CartaoCredito();
        else if (tipoPagamento == "3")
            return new CartaoDebito();
        else
            return new Dinheiro();
    }

    public Venda selecionaTipoVenda(double valor, List<Produto> produtos, Cliente cliente, Vendedor vendedor)
    {
        System.Console.Write("Selecione o tipo da venda (1 = Venda Normal, 2 = Venda Online): ");
        string tipoVenda = Console.ReadLine();

        if (tipoVenda == "1")
        {
            var random = new Random();
		    int id = random.Next(100000000, 999999999);

            IFormaPagamento formaPagamento = selecionaFormaPagamento();

            return new Venda(id, valor, formaPagamento, produtos, cliente, vendedor);
        }

        else
        {
            var random = new Random();
		    int id = random.Next(100000000, 999999999);

            IFormaPagamento formaPagamento = selecionaFormaPagamento();

            return new VendaOnline(id, valor, formaPagamento, produtos, cliente, vendedor);
        }
    }

    public Loja cadastraLoja()
    {
        System.Console.Write("Insira o CNPJ: ");
        string cnpj = Console.ReadLine();

        System.Console.Write("Insira o Nome Fantasia: ");
        string nomeFantasia = Console.ReadLine();

        System.Console.Write("Insira o Nome do Proprietário: ");
        string nomePropietario = Console.ReadLine();

        Endereco endereco = cadastraEndereco();
        Estoque estoque = new Estoque();

        return new Loja(cnpj, nomeFantasia, nomePropietario, endereco, estoque);
    }

    ITipoEntrega selecionaTipoEntrega()
    {
        System.Console.Write("Selecione a forma de envio" + 
            "(1 = Entrega Expressa, 2 = Entrega Padrão): ");

        string tipoEntrega = Console.ReadLine();

        if (tipoEntrega == "1")
            return new EntregaExpressa();
        else
            return new EntregaPadrao();
    }
}
