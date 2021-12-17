using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);
            Console.WriteLine("O numero que queremos e {0}?", numero);
            for(int i = 1; i<=50; i++)
            {
                Console.WriteLine("{0} e o numero q keremos?", i);
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("nao mano...");
                }
            }
        }
    }
}
