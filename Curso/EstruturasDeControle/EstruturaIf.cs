using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    public class EstruturaIf
    {   public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;
            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Ta se comportando? S/N");
            entrada = Console.ReadLine();
            if (entrada == "S" || entrada == "s")
            {
                bomComportamento = true;
            }
            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!!!");
            }
        }
    }
}
