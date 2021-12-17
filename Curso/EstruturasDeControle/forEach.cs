using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    public class forEach
    {
        public static void Executar()
        {
            var palavra = "salve";
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "Ana", "Bia", "carlos" };
            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
