using Singleton.Models;
using System;

namespace Singleton
{
    class Program
    {
        /*
            Objetivo: Permitir a criação de uma única instancia de uma classe e 
            fornecer um modo de recupera-lá.

        */

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
