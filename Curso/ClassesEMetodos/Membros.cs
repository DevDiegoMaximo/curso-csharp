using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Roberto";
            fulano.Idade = "27";
            Console.WriteLine(fulano.Apresentar());
        }
    }
}
