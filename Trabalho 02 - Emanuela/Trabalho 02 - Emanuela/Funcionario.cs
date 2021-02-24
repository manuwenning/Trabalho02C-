using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_02___Emanuela
{
    class Funcionario : Socio
    {
        public Funcionario()
        {

        }
        private static Random ran = new Random();
        public double salarioPorHora { get; set; }
        public string cargo { get; set; }
        public double saldoFuncionario { get; set;}
        public double BatePonto(int hrEntrada, int hrSaida)
        {
            int saldoHoras = hrSaida - hrEntrada;
            return saldoHoras * salarioPorHora;
        }
        public virtual double DefineSaldoFuncionario()
        {
            saldoFuncionario = 0;
            for (int i = 0; i < 30; i++)
            {
                int saldoHoras = ran.Next(7, 10);
                saldoFuncionario += saldoHoras * salarioPorHora;
            }
            return saldoFuncionario;

        }
        public override void DefineDados()
        {
            nome = Gerador.NomePessoa();
            cpf = Gerador.Cpf();
            idade = Gerador.Idade();
            

        }
        public void DefineCargoSalario()
        {
            cargo = Cargo();
            salarioPorHora = 8.50;
            if (cargo == "Gerente de loja")
            {
                salarioPorHora = salarioPorHora * 3;
            }
            else if (cargo == "Supervisor")
            {
                salarioPorHora = salarioPorHora * 2;
            }
            else if (cargo == "Auxiliar de serviços gerais")
            {
                salarioPorHora = salarioPorHora * 1.5;
            }
            else
            {

            }
            saldoFuncionario = DefineSaldoFuncionario();

        }
        public override void MostraDados()
        {
            Console.WriteLine("Funcionário: {0} | {1} | {2} anos | {3:c}", nome, cpf, idade, saldoFuncionario);
        }
        public void MostraCargoSalario()
        {
            Console.WriteLine("{0} | R$ {1} /hora", cargo, salarioPorHora);
        }
        public static string Cargo()
        {
            int escolha = ran.Next(1, 51);
            string cargo;

            switch (escolha)
            {
                case 1:
                    cargo = "Gerente de loja";
                    break;
                case 2:
                    cargo = "Supervisor";
                    break;
                case 3 - 5:
                    cargo = "Auxiliar de serviços gerais";
                    break;
                case 6 - 50:
                    cargo = "Operador de caixa";
                    break;
                default:
                    cargo = "Operador de caixa";
                    break;
            }
            return cargo;
        }

    }
}
