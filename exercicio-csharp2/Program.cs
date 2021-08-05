using System;
using exercicio_csharp2.Entities;
namespace exercicio_csharp2
{
    /// <summary>
    /// exercicio feito para treinar as heranças
    /// utilizando como tema uma conta/conta trabalhador
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ContaTrabalhador conta = new ContaTrabalhador(8010, "Carolina", 100.0, 500.0);
            Console.WriteLine(conta.SaldoConta);


        }
    }
}
