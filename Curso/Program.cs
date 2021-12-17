using System;
using System.Collections.Generic;
using Curso.Fundamentos;
using Curso.EstruturasDeControle;
using Curso.ClassesEMetodos;

namespace Curso
{
     class Program
    {
        public static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){
                { "Primeiro Programa - Fundamentos", Programa.Executar},
                { "Comentários - Fundamentos", Comentarios.Executar},
                { "Operadores Ternarios - Fundamentos", OperadoresUnarios.Executar},
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                { "Else If", ElseIfElse.Executar},
                { "Estrutura Switch", EstruturaSwitch.Executar},
                { "Estrutura While", EstruturaWhile.Executar},
                { "Estrutura DoWhile", DoWhile.Executar},
                { "Estrutura For", EstruturaFor.Executar},
                { "Estrutura ForEach", forEach.Executar},
                { "Estrutura Break", UsandoBreak.Executar},
                { "Estrutura Continue", UsandoContinue.Executar},
                { "Membros", Membros.Executar},
                { "Construtores", Construtores.Executar},
                { "Metodos com Retorno", MetodosComRetorno.Executar},
                { "Metodos Estaticos", MetodosEstaticos.Executar},
                { "Atributos Estaticos", AtributosEstaticos.Executar},
                { "Desafio Atributos", DesafioAtributos.Executar},
                { "Params", Params.Executar},
                { "Parametros nomados", ParametrosNomeados.Executar},
            });
             central.SelecionarExecutar();
        }
    }
}
