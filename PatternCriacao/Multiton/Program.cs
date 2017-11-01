using Multiton.Enum;
using Multiton.Models;
using System;

namespace Multiton
{
    class Program
    {
        /*
            Objetivo: Permitir a criação de uma quantidade limitada de instâncias de determinada classe e
            fornecer um modo para recuperá-las.
        */
        static void Main(string[] args)
        {
            Tema temaFire = Tema.GetInstance(Temas.FIRE);
            Console.WriteLine($"Tema {temaFire.Nome}");
            Console.WriteLine($"Cor da Fonte {temaFire.FontColor.Name}");

            Tema temaFire2 = Tema.GetInstance(Temas.FIRE);

            Console.WriteLine("\n---------------\n");

            Console.WriteLine("Comparando as referências");
            Console.WriteLine(temaFire == temaFire2);

            Console.ReadKey();
        }
    }
}
