using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
   public class ElseIfElse
    {   
        public static void Executar()
        {
            Console.WriteLine("digite sua nota: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Ta parbens");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("so passou mesmo");
            }
            else if(nota >=5.0)
            {
                Console.WriteLine("quase hein ladrão");
            }
            else
            {
                Console.WriteLine("vc rodou...");
            }
        }
    }
}
