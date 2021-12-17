using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
   public class DoWhile
    {
        public static void Executar()
        {
            string entrada;
            do
            {
                Console.WriteLine("qual seu nome");
                entrada = Console.ReadLine();
                Console.WriteLine("Ola {0}", entrada);
                Console.WriteLine(" Quer continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");


        }
    }
}
