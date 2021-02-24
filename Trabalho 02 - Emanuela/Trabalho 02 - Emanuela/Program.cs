using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace Trabalho_02___Emanuela
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> cli = new List<Cliente>();
            for (int i = 0; i < 5; i++)
            {
                Cliente temp = new Cliente();
                temp.DefineDados();
                cli.Add(temp);
            }
            List<Socio> soc = new List<Socio>();
            for (int i = 0; i < 2; i++)
            {
                Socio temp = new Socio();
                temp.DefineDados();
                soc.Add(temp);
            }
            List<Funcionario> func = new List<Funcionario>();
            for (int i = 0; i < 5; i++)
            {
                Funcionario temp = new Funcionario();
                temp.DefineDados();
                temp.DefineCargoSalario();
                func.Add(temp);
            }
            List<Fornecedor> forn = new List<Fornecedor>();
            for (int i = 0; i < 5; i++)
            {
                Fornecedor temp = new Fornecedor();
                temp.DefineDados();
                forn.Add(temp);
            }
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("\n1- Adicionar\n2 - Remover\n3 - Comprar\n4 - Bater Cartão\n5 - Alterar\n" +
                    "6 - Calcular Lucros\n7 - Sair\n");
                int escolhaMenu = int.Parse(CR());
                switch (escolhaMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("ADICIONAR");
                        Console.WriteLine("\nO que você deseja adicionar?\n");
                        Console.WriteLine("1 - Cliente\n2 - Cliente Sócio\n3 - Funcionário\n4 - Fornecedor\n");
                        int escolhaCase1 = int.Parse(CR());
                        bool escolhaAdicionar = true;
                        string cpf;
                        while (escolhaAdicionar)
                        {
                            switch (escolhaCase1)
                            {
                                case 1:
                                    Console.WriteLine("\nDigite o CPF do cliente (apenas números):\n");
                                    cpf = CR();
                                    cpf = CPFormat(cpf);
                                    for (int i = 0; i < cli.Count; i++)
                                    {
                                        if (cpf == cli[i].cpf)
                                        {
                                            Console.WriteLine("Erro! CPF já cadastrado...");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                            break;

                                        }
                                        else
                                        {
                                            Cliente temp = new Cliente();
                                            temp.cpf = cpf;
                                            Console.WriteLine("\nAgora digite o nome, idade e saldo do cliente:\n");
                                            temp.nome = CR();
                                            temp.idade = int.Parse(CR());
                                            temp.saldo = double.Parse(CR());
                                            cli.Add(temp);
                                            Console.WriteLine("\nCliente adicionado com sucesso!\n");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("\nDigite o CPF do cliente sócio (apenas números):\n");
                                    cpf = CR();
                                    cpf = CPFormat(cpf);
                                    for (int i = 0; i < soc.Count; i++)
                                    {
                                        if (cpf == soc[i].cpf)
                                        {
                                            Console.WriteLine("Erro! CPF já cadastrado...");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;

                                        }
                                        else
                                        {
                                            Socio temp = new Socio();
                                            temp.cpf = cpf;
                                            Console.WriteLine("\nAgora digite o nome, idade, saldo e ações do cliente sócio:\n");
                                            temp.nome = CR();
                                            temp.idade = int.Parse(CR());
                                            temp.saldo = double.Parse(CR());
                                            temp.qtdAcoes = double.Parse(CR());
                                            soc.Add(temp);
                                            Console.WriteLine("\nCliente sócio adicionado com sucesso!\n");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }

                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("\nDigite o CPF do Funcionário (apenas números):\n");
                                    cpf = CR();
                                    cpf = CPFormat(cpf);
                                    for (int i = 0; i < func.Count; i++)
                                    {
                                        if (cpf == func[i].cpf)
                                        {
                                            Console.WriteLine("Erro! CPF já cadastrado...");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;

                                        }
                                        else
                                        {
                                            Funcionario temp = new Funcionario();
                                            temp.cpf = cpf;
                                            Console.WriteLine("\nAgora digite o nome, idade, cargo e saldo do funcionário:\n");
                                            temp.nome = CR();
                                            temp.idade = int.Parse(CR());
                                            temp.cargo = CR();
                                            temp.saldo = double.Parse(CR());
                                            func.Add(temp);
                                            Console.WriteLine("\nFuncionário adicionado com sucesso!\n");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    break;

                                case 4:
                                    Console.WriteLine("\nDigite o CNPJ do Fornecedor (apenas números):\n");
                                    cpf = CR();
                                    cpf = CNPJFormat(cpf);
                                    for (int i = 0; i < forn.Count; i++)
                                    {
                                        if (cpf == forn[i].cpf)
                                        {
                                            Console.WriteLine("Erro! CNPJ já cadastrado...");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                            break;

                                        }
                                        else
                                        {
                                            Fornecedor temp = new Fornecedor();
                                            temp.cnpj = cpf;
                                            Console.WriteLine("\nAgora digite o nome da empresa, tipo de produto(número 1-6) e a quantidade:\n");
                                            temp.nome = CR();
                                            temp.tipoDeProduto = int.Parse(CR());
                                            temp.qtdFornecidaMes = int.Parse(CR());
                                            forn.Add(temp);
                                            Console.WriteLine("\nFornecedor adicionado com sucesso!\n");
                                            escolhaAdicionar = false;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("\nOpção inválida...\n");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;


                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("REMOVER");
                        Console.WriteLine("\nO que você deseja remover?\n");
                        Console.WriteLine("1 - Cliente\n2 - Cliente Sócio\n3 - Funcionário\n4 - Fornecedor\n");
                        int escolhaCase2 = int.Parse(CR());
                        int remove;
                        switch (escolhaCase2)
                        {
                            case 1:
                                Console.WriteLine("\nLista de Clientes\n");
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    Console.Write("Cliente {0}:", (i + 1));
                                    cli[i].MostraDados();
                                }
                                Console.WriteLine("\nQual cliente deseja remover?\n");
                                remove = int.Parse(CR());
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    cli[remove - 1] = new Cliente();
                                    Console.WriteLine("\nCliente removido com sucesso!\n");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("\nLista de Clientes Sócios\n");
                                for (int i = 0; i < soc.Count; i++)
                                {
                                    Console.Write("Cliente Sócio {0}:", (i + 1));
                                    soc[i].MostraDados();
                                    soc[i].MostraAcoes();
                                }
                                Console.WriteLine("\nQual cliente sócio deseja remover?\n");
                                remove = int.Parse(CR());
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    soc[remove - 1] = new Socio();
                                    Console.WriteLine("\nCliente sócio removido com sucesso!\n");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("\nLista de Funcionários\n");
                                for (int i = 0; i < func.Count; i++)
                                {
                                    Console.Write("Funcionário {0}:", (i + 1));
                                    func[i].MostraDados();
                                    func[i].MostraCargoSalario();
                                }
                                Console.WriteLine("\nQual funcionário deseja remover?\n");
                                remove = int.Parse(CR());
                                for (int i = 0; i < func.Count; i++)
                                {
                                    func[remove - 1] = new Funcionario();
                                    Console.WriteLine("\nFuncionário removido com sucesso!\n");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                                }
                                break;
                            case 4:
                                Console.WriteLine("\nLista de Fornecedores\n");
                                for (int i = 0; i < forn.Count; i++)
                                {
                                    Console.Write("Fornecedor {0}:", (i + 1));
                                    forn[i].MostraDados();
                                    forn[i].MostraQuantidadeFornecida();
                                }
                                Console.WriteLine("\nQual fornecedor deseja remover?\n");
                                remove = int.Parse(CR());
                                for (int i = 0; i < forn.Count; i++)
                                {
                                    forn[remove - 1] = new Fornecedor();
                                    Console.WriteLine("\nFornecedor removido com sucesso!\n");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida...\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("COMPRA");
                        Console.WriteLine("\nQuem está efetuando a compra?\n");
                        Console.WriteLine("1 - Cliente\n2 - Cliente Sócio\n");
                        int escolhaCase3 = int.Parse(CR());
                        switch (escolhaCase3)
                        {
                            case 1:
                                Console.WriteLine();
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    Console.Write("Cliente {0}:", (i + 1));
                                    cli[i].MostraDados();
                                }
                                Console.WriteLine("\nDigite o CPF do cliente que está efetuando a compra (apenas números):\n");
                                cpf = CR();
                                cpf = CPFormat(cpf);
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    if(cpf == cli[i].cpf)
                                    {
                                        Console.WriteLine("\nQual o valor da compra?\n");
                                        double valor = double.Parse(CR());
                                        cli[i].saldo += valor;
                                        Console.WriteLine("\nCompra realizada com sucesso!\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nCPF inválido...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }

                                }
                                break;

                            case 2:
                                Console.WriteLine();
                                for (int i = 0; i < soc.Count; i++)
                                {
                                    Console.Write("Cliente Sócio {0}:", (i + 1));
                                    soc[i].MostraDados();
                                }
                                Console.WriteLine("\nDigite o CPF do cliente sócio que está efetuando a compra (apenas números):\n");
                                cpf = CR();
                                cpf = CPFormat(cpf);
                                for (int i = 0; i < soc.Count; i++)
                                {
                                    if (cpf == cli[i].cpf)
                                    {
                                        Console.WriteLine("\nQual o valor da compra?\n");
                                        double valor = double.Parse(CR());
                                        valor = valor - (valor * 0.2);
                                        Console.WriteLine("Valor com desconto: {0:c}", valor);
                                        cli[i].saldo += valor;
                                        Console.WriteLine("\nCompra realizada com sucesso!\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nCPF inválido...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                }
                                break;
                                
                            default:
                                Console.WriteLine("\nOpção inválida!\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("CARTÃO PONTO");
                        Console.WriteLine();
                        for (int i = 0; i < func.Count; i++)
                        {
                            Console.Write("Funcionário {0}:", (i + 1));
                            func[i].MostraDados();
                        }
                        Console.WriteLine("\nDigite o CPF do funcionário que deseja bater o ponto (apenas números):\n");
                        cpf = CR();
                        cpf = CPFormat(cpf);
                        for (int i = 0; i < func.Count; i++)
                        {
                            if (cpf == func[i].cpf)
                            {
                                Console.WriteLine("\nDeseja bater o ponto mensal ou diário?\n");
                                Console.WriteLine("1 - Mensal\n2 - Diário\n");
                                int escolhaCase4 = int.Parse(CR());
                                switch (escolhaCase4)
                                {
                                    case 1:
                                        func[i].saldoFuncionario += func[i].DefineSaldoFuncionario();
                                        func[i].MostraDados();
                                        func[i].MostraCargoSalario();
                                        Console.WriteLine("\nPonto registrado!\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine("\nInsira a hora de entrada e a hora de saída(hora cheia, apenas números):\n");
                                        int hrEntrada = int.Parse(CR());
                                        int hrSaida = int.Parse(CR());
                                        func[i].saldoFuncionario += func[i].BatePonto(hrEntrada, hrSaida);
                                        Console.WriteLine("\nPonto registrado!\n");
                                        func[i].MostraDados();
                                        func[i].MostraCargoSalario();
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("\nOpção inválida...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;

                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nCPF inválido...\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("ALTERAR");
                        Console.WriteLine("\nO que você deseja alterar?\n");
                        Console.WriteLine("1 - Cliente\n2 - Cliente Sócio\n3 - Funcionário\n4 - Fornecedor\n");
                        int escolhaCase5 = int.Parse(CR());
                        switch (escolhaCase5)
                        {
                            case 1:
                                Console.WriteLine("\nLista de Clientes:\n");
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    Console.Write("Cliente {0}: ", (i + 1));
                                    cli[i].MostraDados();
                                }
                                Console.WriteLine("\nDigite o CPF do cliente que deseja alterar (apenas números):\n");
                                cpf = CR();
                                cpf = CPFormat(cpf);
                                for (int i = 0; i < cli.Count; i++)
                                {
                                    if (cpf == cli[i].cpf)
                                    {
                                        cli[i] = new Cliente();
                                        Console.WriteLine("\nInsira o nome, CPF(apenas números), idade e saldo do cliente:\n");
                                        cli[i].nome = CR();
                                        cli[i].cpf = CR();
                                        cli[i].cpf = CPFormat(cli[i].cpf);
                                        cli[i].idade = int.Parse(CR());
                                        cli[i].saldo = double.Parse(CR());
                                        Console.WriteLine("\nAlteração realizada!\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nCPF inválido...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("\nLista de Clientes Sócios:\n");
                                for (int i = 0; i < soc.Count; i++)
                                {
                                    Console.Write("Cliente Sócio {0}: ", (i + 1));
                                    soc[i].MostraDados();
                                    soc[i].MostraAcoes();
                                }
                                Console.WriteLine("\nDigite o CPF do cliente sócio que deseja alterar (apenas números):\n");
                                cpf = CR();
                                cpf = CPFormat(cpf);
                                for (int i = 0; i < soc.Count; i++)
                                {
                                    if (cpf == soc[i].cpf)
                                    {
                                        soc[i] = new Socio();
                                        Console.WriteLine("\nInsira o nome, CPF(apenas números), idade, saldo e quantidade de ações:\n");
                                        soc[i].nome = CR();
                                        soc[i].cpf = CR();
                                        soc[i].cpf = CPFormat(soc[i].cpf);
                                        soc[i].idade = int.Parse(CR());
                                        soc[i].saldo = double.Parse(CR());
                                        soc[i].qtdAcoes = double.Parse(CR());
                                        Console.WriteLine("Alteração realizada!");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nCPF inválido...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("\nLista de Funcionários:\n");
                                for (int i = 0; i < func.Count; i++)
                                {
                                    Console.Write("Funcionário {0}: ", (i + 1));
                                    func[i].MostraDados();
                                    func[i].MostraCargoSalario();
                                }
                                Console.WriteLine("\nDigite o CPF do funcionário que deseja alterar (apenas números):\n");
                                cpf = CR();
                                cpf = CPFormat(cpf);
                                for (int i = 0; i < func.Count; i++)
                                {
                                    if (cpf == func[i].cpf)
                                    {
                                        func[i] = new Funcionario();
                                        Console.WriteLine("\nInsira o nome, CPF(apenas números), idade, saldo e cargo:\n");
                                        func[i].nome = CR();
                                        func[i].cpf = CR();
                                        func[i].cpf = CPFormat(soc[i].cpf);
                                        func[i].idade = int.Parse(CR());
                                        func[i].saldoFuncionario = double.Parse(CR());
                                        func[i].cargo = CR();
                                        Console.WriteLine("\nAlteração realizada!\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nCPF inválido...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine("\nLista de Fornecedores:\n");
                                for (int i = 0; i < forn.Count; i++)
                                {
                                    Console.Write("Fornecedor {0}: ", (i + 1));
                                    forn[i].MostraDados();
                                    forn[i].MostraQuantidadeFornecida();
                                }
                                Console.WriteLine("\nDigite o CNPJ do fornecedor que deseja alterar (apenas números):\n");
                                cpf = CR();
                                cpf = CNPJFormat(cpf);
                                for (int i = 0; i < forn.Count; i++)
                                {
                                    if (cpf == forn[i].cpf)
                                    {
                                        forn[i] = new Fornecedor();
                                        Console.WriteLine("\nDigite o nome, CNPJ (apenas números), tipo de produto (1-6) e quantidade " +
                                            "fornecida nesse mês:\n");
                                        forn[i].nome = CR();
                                        forn[i].cnpj = CR();
                                        forn[i].cnpj = CNPJFormat(forn[i].cnpj);
                                        forn[i].tipoDeProduto = int.Parse(CR());
                                        forn[i].qtdFornecidaMes = int.Parse(CR());
                                        Console.WriteLine("\nFornecedor removido com sucesso!\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nCPF inválido...\n");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida...\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("BALANÇA COMERCIAL");
                        Console.WriteLine("\nReceitas:");
                        double receita = 0;
                        for (int i = 0; i < cli.Count; i++)
                        {
                            receita += cli[i].saldo;
                        }
                        for (int i = 0; i < soc.Count; i++)
                        {
                            receita += soc[i].saldo;
                        }
                        Console.WriteLine("{0:c}", receita);
                        Console.WriteLine("\nAcionistas:");
                        double acoes = 0;
                        for (int i = 0; i < soc.Count; i++)
                        {
                            acoes += soc[i].qtdAcoes;
                        }
                        Console.WriteLine("Total de ações: {0:##,##}%", acoes);
                        Console.WriteLine("\nDespesas:");
                        double despesa = 0;
                        for (int i = 0; i < func.Count; i++)
                        {
                            despesa += func[i].saldoFuncionario;
                        }
                        for (int i = 0; i < forn.Count; i++)
                        {
                            despesa += forn[i].valorFinal;
                        }
                        Console.WriteLine("{0:c}", despesa);
                        double saldoFinal = receita - despesa;
                        Console.WriteLine("\nSaldo Final: {0:c}", saldoFinal);
                        double porcent = 0;
                        double caixa = 0;
                        if (saldoFinal > 0)
                        {
                            porcent = (acoes / 100) * receita;
                            caixa = (receita - porcent) - despesa;
                            Console.WriteLine("Porcentagem total dos acionistas: -{0:c}", porcent);

                        }
                        else if (saldoFinal < 0)
                        {
                            porcent = (acoes / 100) * despesa;
                            caixa = receita - (despesa - porcent);
                            Console.WriteLine("Porcentagem total dos acionistas: +{0:c}", porcent);
                        }
                        Console.WriteLine("\nCAIXA: {0:C}", caixa);
                        Console.WriteLine("\nTecle enter para voltar ao menu...\n");
                        CR();
                        for (int i = 0; i < cli.Count; i++)
                        {
                            cli[i].saldo = 0;
                        }
                        for (int i = 0; i < soc.Count; i++)
                        {
                            soc[i].saldo = 0;
                        }
                        for (int i = 0; i < func.Count; i++)
                        {
                            func[i].saldoFuncionario = 0;
                        }
                        for (int i = 0; i < forn.Count; i++)
                        {
                            double estoque = Convert.ToDouble(forn[i].qtdFornecidaMes); 
                            estoque = estoque/2;
                            estoque = Math.Ceiling(estoque);
                            forn[i].qtdFornecidaMes = Convert.ToInt32(estoque);
                        }
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("\nObrigada por usar este programa! Encerrando...\n");
                        Thread.Sleep(3000);
                        Console.Clear();
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida...\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;

                }
            }


        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static string CPFormat(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
        public static string CNPJFormat(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"00\.000\.000\/0000\-00");
        }
      
    }
}
