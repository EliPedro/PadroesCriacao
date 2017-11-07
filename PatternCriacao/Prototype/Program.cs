using Prototype.Models;
using Prototype.Models.Interfaces;
using System;

namespace Prototype
{
    /*
        Objetivo: Possibilitar a criação de novos objetos apartir da cópia de objetos existentes 
     */ 
     
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Google Award";
            var vencimeto = DateTime.Now;

            var campanha = new Campanha(nome, vencimeto);
            Console.WriteLine(campanha.ToString());
            Console.WriteLine("------------- Cópia -------------");
            Console.WriteLine(campanha.Clone());
            Console.ReadKey();
        }
    }
}
