using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_02___Emanuela
{
    class Fornecedor: Socio
    {
        public Fornecedor()
        {

        }
        private static Random ran = new Random();
        public string nome { get; set; }
        public string cnpj { get; set; }
        public int tipoDeProduto { get; set; }
        public int qtdFornecidaMes { get; set; }
        public double valorProduto { get; set; }
        public double valorFinal { get; set; }
        public static string Cnpj()
        {
            string cnpj = "";
            for (int i = 1; i < 19; i++)
            {
                if(i == 16)
                {
                    cnpj += "-";
                }
                else if (i == 11)
                {
                   cnpj += "/";
                }
                else if (i == 3)
                {
                   cnpj += ".";
                }
                else if (i == 7)
                {
                    cnpj += ".";
                }
                else
                {
                    cnpj += ran.Next(0, 10);
                }
            }
            return cnpj;
        }
        public static int TipoDeProduto()
        {
            return ran.Next(1, 7);
        }
        public static int DefineQuantidadeFornecida()
        {
            return ran.Next(20, 80);
        }
        public override void DefineDados()
        {
            nome = Gerador.NomeEmpresa();
            cnpj = Cnpj();
            tipoDeProduto = TipoDeProduto();
            qtdFornecidaMes = DefineQuantidadeFornecida();
            valorProduto = DefineValorProduto();
            valorFinal = DefineValorFinal();
           
            
        }
        public double DefineValorProduto()
        {
            switch (tipoDeProduto)
            {
                case 1:
                    valorProduto = 5.45;
                    break;
                case 2:
                    valorProduto = 6.78;
                    break;
                case 3:
                    valorProduto = 1.43;
                    break;
                case 4:
                    valorProduto = 2.68;
                    break;
                case 5:
                    valorProduto = 3.78;
                    break;
                case 6:
                    valorProduto = 2.96;
                    break;
                default:
                    valorProduto = 0.0;
                    break;

            }
            return valorProduto;
        }
        public double DefineValorFinal()
        {
            valorFinal = valorProduto * qtdFornecidaMes;
            return valorFinal;
        }
            
        public override void MostraDados()
        {
            Console.WriteLine("Fornecedor: {0} | {1} ", nome, cnpj);
        }
        public void MostraQuantidadeFornecida ()
        {
            Console.WriteLine("{0} | {1} | {2:c} | {3:c}", tipoDeProduto, qtdFornecidaMes, valorProduto, valorFinal);
        }

    }
}
