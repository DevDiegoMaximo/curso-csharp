using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public class Pessoa
    {
        public string Nome;
        public string Idade;

        public string Apresentar() 
        {
            return string.Format($"olá me chamo {Nome} e tenho {Idade} sexo");
        }
    }
}
