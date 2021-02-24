using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_02___Emanuela
{
    class Cliente
    {
        public Cliente ()
        {

        }
        public string nome { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }
        public double saldo { get; set; }

        public virtual void DefineDados()
        {
            nome = Gerador.NomePessoa();
            cpf = Gerador.Cpf();
            idade = Gerador.Idade();
            saldo = Gerador.Saldo();
            
        }
        public virtual void MostraDados()
        {
            Console.WriteLine("Cliente: {0} | {1} | {2} | {3:c}", nome, cpf, idade, saldo);
        }
    }
}
