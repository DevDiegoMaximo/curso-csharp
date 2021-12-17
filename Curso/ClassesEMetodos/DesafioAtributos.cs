using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class DesafioAtributos
    {
        int a = 10;
        public static void Executar()
        {
            var seila = new DesafioAtributos();
            Console.WriteLine(seila.a);
        }
    }
}
