using System;
using System.Collections.Generic;
using System.Text;
namespace exercicio_csharp2.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string TitularConta { get; private set; }
        public double SaldoConta { get; protected set; }

        public Conta()
        {
        }
        public Conta(int numero, string titularConta, double saldoConta)
        {
            Numero = numero;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }
        public void Saque(double quantia)
        {
            SaldoConta = SaldoConta - quantia;
        }
        public void Deposito(double quantia)
        {
            SaldoConta = SaldoConta + quantia;
        }
    }
}
