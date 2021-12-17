using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
   public class OperadoresUnarios
    {
        public static void Executar()
        {
            var nota = 8.0; 
            string Resultado = nota >= 7.0 ? "aprovado" : "Reprovado";
            Console.WriteLine(Resultado);
        }
    }
}
