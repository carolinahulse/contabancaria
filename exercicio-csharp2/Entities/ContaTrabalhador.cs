using System;
using System.Collections.Generic;
using System.Text;
namespace exercicio_csharp2.Entities
{
    class ContaTrabalhador : Conta
    {
        public double Limite { get; set; }

        public ContaTrabalhador()
        {
        }
        public ContaTrabalhador(int numero, string titularConta, double saldoConta, double limite) : base(numero, titularConta, saldoConta)
        {
            Limite = limite;
        }
        public void Emprestimo(double quantia)
        {
            if (quantia <= Limite)
            {
                SaldoConta = SaldoConta + quantia;
            }
        }
    }
}
