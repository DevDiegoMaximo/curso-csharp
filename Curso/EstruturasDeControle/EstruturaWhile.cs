using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
   public class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncotnrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncotnrado)
            {
                Console.WriteLine("insira seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numeroSecreto == palpite)
                {
                    numeroEncotnrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if(palpite > numeroSecreto)
                {
                    Console.WriteLine("um pouco menos.. tente denovo");
                    Console.WriteLine("tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("mais maior.... tenta outro");
                    Console.WriteLine("tentativas restants: {0}", tentativasRestantes);
                }

            }
        }
    }
}
