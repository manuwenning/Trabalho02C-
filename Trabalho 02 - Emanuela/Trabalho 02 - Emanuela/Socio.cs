using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_02___Emanuela
{
    class Socio : Cliente
    {
        public Socio ()
        {

        }
        public double qtdAcoes { get; set; }
        public static double DefineAcoes()
        {
            Random ran = new Random();
            double qtdAcoes = ran.Next(0, 5) + ran.NextDouble();
            if (qtdAcoes > 4.95)
            {
                qtdAcoes = ran.Next(0, 5) + ran.NextDouble();
            }
            else
            {

            }
            return qtdAcoes;

        }

        public override void DefineDados()
        {
            nome = Gerador.NomePessoa();
            cpf = Gerador.Cpf();
            idade = Gerador.Idade();
            saldo = Gerador.Saldo();
            qtdAcoes = DefineAcoes();
            
        }
        public override void MostraDados()
        {
            Console.WriteLine("{0} | {1} | {2} | {3:c}", nome, cpf, idade, saldo);
        }

        public void MostraAcoes()
        {
            Console.WriteLine("{0:#.##}% de ações da empresa", qtdAcoes);
        }

    }
}
