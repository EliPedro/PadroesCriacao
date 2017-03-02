using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Configuracao.GetInstance();

            Console.WriteLine("---- Propriedades ----");
            Console.WriteLine("Time-Zone - {0}", config.GetPropriedade("time-zone"));
            Console.WriteLine("Currency-Code - {0}", config.GetPropriedade("currency-code"));

            Console.ReadKey();
        }
    }
}
