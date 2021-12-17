using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int subtrair(int a, int b)
        {
            return a - b;
        }
        public int multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 10);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.subtrair(26,10));
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(4).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(4).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);

        }
    }
}
