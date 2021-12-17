using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("avalie meu atendimento c nota de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota)
            {
                case 0:
                    Console.WriteLine("horoso");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("masomenos hein");
                    break;
                case 3:
                    Console.WriteLine("da p melolar");
                    break;
                case 4:
                    Console.WriteLine("Ta quase vo ");
                    break;
                case 5:
                    Console.WriteLine("perfeito");
                    break;
                default:
                    Console.WriteLine("invalido");
                    break;
            }
        }
    }
}
