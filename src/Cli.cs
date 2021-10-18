using System;
using System.Collections.Generic;
using System.Text.Json;

class Cli
{
	public Produto getArquivoProduto(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Produto p = JsonSerializer.Deserialize<Produto>(jsonString);
		return p;
	}

	public Estoque getArquivoEstoque(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Estoque e = JsonSerializer.Deserialize<Estoque>(jsonString);
		return e;
	}

	public Loja getArquivoLoja(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Loja j = JsonSerializer.Deserialize<Loja>(jsonString);
		return j;
	}

	public Endereco getArquivoEndereco(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Endereco e = JsonSerializer.Deserialize<Endereco>(jsonString);
		return e;
	}

	public Pessoa getArquivoPessoa(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Pessoa p = JsonSerializer.Deserialize<Pessoa>(jsonString);
		return p;
	}

	public Vendedor getArquivoVendedor(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Vendedor v = JsonSerializer.Deserialize<Vendedor>(jsonString);
		return v;
	}

	public Venda getArquivoVenda(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Venda v = JsonSerializer.Deserialize<Venda>(jsonString);
		return v;
	}

	public VendaOnline getArquivoVendaOnline(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		VendaOnline vo = JsonSerializer.Deserialize<VendaOnline>(jsonString);
		return vo;
	}

	public EntregaPadrao getArquivoEntregaPadrao(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		EntregaPadrao ep = JsonSerializer.Deserialize<EntregaPadrao>(jsonString);
		return ep;
	}

	public EntregaExpressa getArquivoEntregaExpressa(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		EntregaExpressa ex = JsonSerializer.Deserialize<EntregaExpressa>(jsonString);
		return ex;
	}

	public BoletoBancario getArquivoBoletoBancario(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		BoletoBancario b = JsonSerializer.Deserialize<BoletoBancario>(jsonString);
		return b;
	}

	public CartaoCredito getArquivoCartaoCredito(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		CartaoCredito cc = JsonSerializer.Deserialize<CartaoCredito>(jsonString);
		return cc;
	}

	public CartaoDebito getArquivoCartaoDebito(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		CartaoDebito cd = JsonSerializer.Deserialize<CartaoDebito>(jsonString);
		return cd;
	}

	public Dinheiro getArquivoDinheiro(string nomeArquivo)
	{
		string jsonString = Persistencia.BuscarJson(nomeArquivo);
		Dinheiro d = JsonSerializer.Deserialize<Dinheiro>(jsonString);
		return d;
	}

	public void salvaArquivo(Object objeto)
	{
		string jsonString = Persistencia.Serializar(objeto);

		Console.Write("Insira o nome do arquivo: ");
		string nomeArquivo = Console.ReadLine();
		Persistencia.SalvarJson(nomeArquivo, jsonString);

		Console.WriteLine("Arquivo salvo com sucesso.");
	}

    public Produto cadastraProduto()
    {
        Console.Write("Insira a categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Insira a marca: ");
        string marca = Console.ReadLine();

        Console.Write("Insira o modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Insira o preço: ");
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
        Console.Write("Insira o número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o bairro: ");
        string bairro = Console.ReadLine();

        Console.Write("Insira a cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Insira o CEP: ");
        string cep = Console.ReadLine();


        Console.Write("Insira a UF: ");
        UnidadeFederativa unidadeFederativa = cadastraUF();

        return new Endereco(numero, bairro, cidade, unidadeFederativa, cep);
    }

    public Cliente cadastraCliente()
    {
        Console.Write("Insira o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Insira o cpf: ");
        string cpf = Console.ReadLine();

        Console.Write("Insira o email: ");
        string email = Console.ReadLine();

        Console.Write("Insira o telefone: ");
        int telefone = Convert.ToInt32(Console.ReadLine());

        Endereco endereco = cadastraEndereco();

        return new Cliente(nome, cpf, email, endereco, telefone);
    }

    public Vendedor cadastraVendedor()
    {
        Console.Write("Insira o salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a matrícula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Insira o cpf: ");
        string cpf = Console.ReadLine();

        Console.Write("Insira o email: ");
        string email = Console.ReadLine();

        Console.Write("Insira o telefone: ");
        int telefone = Convert.ToInt32(Console.ReadLine());

        Endereco endereco = cadastraEndereco();

        return new Vendedor(salario, matricula, nome, cpf, email, endereco, telefone);
    }

    IFormaPagamento selecionaFormaPagamento()
    {
        Console.Write("Selecione a forma de pagamento" +
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
        Console.Write("Selecione o tipo da venda (1 = Venda Normal, 2 = Venda Online): ");
        string tipoVenda = Console.ReadLine();

        if (tipoVenda == "1")
        {
            var random = new Random();
            int id = random.Next(100000000, 999999999);

            IFormaPagamento formaPagamento = selecionaFormaPagamento();

            return new Venda(valor, formaPagamento, produtos, cliente, vendedor);
        }

        else
        {
            var random = new Random();
            int id = random.Next(100000000, 999999999);

            IFormaPagamento formaPagamento = selecionaFormaPagamento();
            ITipoEntrega entrega = selecionaTipoEntrega();

            entrega.despachar();

            return new VendaOnline(valor, formaPagamento, produtos, cliente, vendedor, entrega);
        }
    }

    public Loja cadastraLoja()
    {
        Console.Write("Insira o CNPJ: ");
        string cnpj = Console.ReadLine();

        Console.Write("Insira o Nome Fantasia: ");
        string nomeFantasia = Console.ReadLine();

        Console.Write("Insira o Nome do Proprietário: ");
        string nomePropietario = Console.ReadLine();

        Endereco endereco = cadastraEndereco();
        Estoque estoque = new Estoque();

        return new Loja(cnpj, nomeFantasia, nomePropietario, endereco, estoque);
    }

    public ITipoEntrega selecionaTipoEntrega()
    {
        Console.Write("Selecione a forma de envio" +
            "(1 = Entrega Expressa, 2 = Entrega Padrão): ");

        string tipoEntrega = Console.ReadLine();

        if (tipoEntrega == "1")
            return new EntregaExpressa();
        else
            return new EntregaPadrao();
    }

    public void programa()
    {
        Cli cli = new Cli();
        List<Loja> listaLojas = new List<Loja>();
        List<Cliente> listaClientes = new List<Cliente>();
        List<Vendedor> listaVendedor = new List<Vendedor>();

        while (true)
        {
            Console.WriteLine("\n-- Menu principal --"
            + "\n1 - Cadastrar uma loja"
            + "\n2 - Cadastrar um cliente"
            + "\n3 - Cadastrar um vendedor"
            + "\n4 - Cadastrar um produto"
            + "\n5 - Realizar uma venda"
            + "\n6 - Ler arquivo de save"
            + "\n7 - Salvar"
            + "\n0 - Sair do programa");

            string escolha = Console.ReadLine();

            if (escolha == "0")
                break;

            else if (escolha == "1")
            {
                listaLojas.Add(cli.cadastraLoja());
            }
            
            else if (escolha == "2")
            {
                listaClientes.Add(cli.cadastraCliente());
            }

            else if (escolha == "3")
            {
                listaVendedor.Add(cli.cadastraVendedor());
            }

            else if (escolha == "4")
            {
                Console.WriteLine("Em qual loja deseja cadastrar o produto? ");
                for (int i = 0; i < listaLojas.Count; i++)
                {
                    Console.WriteLine($"{i} - {listaLojas[i].NomeFantasia}");
                }
                int indiceLoja = Convert.ToInt32(Console.ReadLine());

                listaLojas[indiceLoja].Estoque.EntrarProduto(cli.cadastraProduto());

                // List<string> coisas = listaLojas[indiceLoja].Estoque.ListarEstoque();
                // foreach (string coisa in coisas)
                // {
                //     Console.WriteLine(coisa);
                // }
            }

            else if (escolha == "5")
            {
                List<Produto> carrinhoCompras = new List<Produto>();
                
                Console.WriteLine("Em qual loja deseja realizar a venda? ");
                for (int i = 0; i < listaLojas.Count; i++)
                {
                    Console.WriteLine($"{i} - {listaLojas[i].NomeFantasia}");
                }
                int indiceLoja = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine("-- Produtos --");
                    List<string> produtos = listaLojas[indiceLoja].Estoque.ListarEstoque();
                    foreach (string p in produtos)
                    {
                        Console.WriteLine(p);
                    }
                    int indiceProduto = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Produto produto = listaLojas[indiceLoja].Estoque.CompraProduto(indiceProduto);
                        carrinhoCompras.Add(produto);
                    }
                    catch
                    {
                        foreach (Produto p in carrinhoCompras)
                        {
                            Console.WriteLine("Carrinho:\n");
                            Console.WriteLine(" - " + p.Modelo);
                        }

                        break;
                    }
                }

                double precoTotal = 0;

                foreach (Produto produto in carrinhoCompras)
                {
                    precoTotal += produto.Preco;
                }

                Console.WriteLine("Escolha um cliente: ");
                foreach (Cliente cliente in listaClientes)
                {
                    Console.WriteLine(cliente.getNome());
                }
                Cliente clienteEscolhido = listaClientes[Convert.ToInt32(Console.ReadLine())];

                Console.WriteLine("Escolha um vendedor: ");
                foreach (Vendedor vendedor in listaVendedor)
                {
                    Console.WriteLine(vendedor.getNome());
                }
                Vendedor vendedorEscolhido = listaVendedor[Convert.ToInt32(Console.ReadLine())];

                Console.WriteLine($"Preco total: {precoTotal}");
                Console.WriteLine($"Cliente: {clienteEscolhido.getNome()}");
                Console.WriteLine($"Vendedor: {vendedorEscolhido.getNome()}");

                Venda tipoVenda = selecionaTipoVenda(precoTotal, carrinhoCompras, clienteEscolhido, vendedorEscolhido);
                tipoVenda.ToString();
            }

            else if (escolha == "6")
            {
                Console.Write("Insira o nome do arquivo: ");
                string nome = Console.ReadLine();
                listaLojas.Add(cli.getArquivoLoja(nome));
            }

            else if (escolha == "7")
            {
                foreach (Loja loja in listaLojas)
                {
                    cli.salvaArquivo(loja);
                }
            }
        }
    }
}
