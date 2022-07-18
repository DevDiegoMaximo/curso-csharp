using System;
using System.Collections.Generic;
using Curso.Fundamentos;
using Curso.EstruturasDeControle;
using Curso.ClassesEMetodos;
using Curso.Colecoes;
using Curso.OrientaçãoObjetos;
using Curso.MetodosEFuncoes;
using Curso.Excessoes;
using Curso.Api;
using Curso.TopicosAvancados;
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
                { "Parametros Nomeados", ParametrosNoemados.Executar},
                { "Getters Setters", GetSet.Executar},
                { "Props", Props.Executar},
                { "Read Only", ReadOnly.Executar},
                { "Enum", ExemploEnum.Executar},
                { "Struct", Struct.Executar},
                { "Struct vs Classe", StructVsClasse.Executar},
                { "Valor vs Referencia", ValorVsReferencia.Executar},
                { "Parametros por Referencia", ParametrosPorReferencia.Executar},
                { "Parametros padrão", ParametroPadrao.Executar},
                { "Array", ColecoesArray.Executar},
                { "List", ColecoesList.Executar},
                { "Array list", ColecoesArrayList.Executar},
                { "Set", ColecoesSet.Executar},
                { "Queue", ColecoesQueue.Executar},
                { "Igualdade", Igualdade.Executar},
                { "Stack", ColecoeStack.Executar},
                { "Dictionary", ColecoesDictionary.Executar},
                { "Heranca OO", Heranca.Executar},
                { "Construtor This OO", ConstrutorThis.Executar},
                { "Encaps OO", OrientaçãoObjetos.Encapsulamento.Executar},
                { "Polimorfismo OO", Polimorfismo.Executar},
                { "Classe Abstrata OO", ClasseAbstrata.Executar},
                { "Interface OO", Interface.Executar},
                { "Sealed OO", Sealed.Executar},
                { "labda", exercicioLambda.Executar},
                { "labda com delegate", LambdaComDelegate.Executar},
                { "Usando delegate", UsandoDelegate.Executar},
                { "delegate func anonima", DelegateFuncAnom.Executar},
                { "delegate como param", DelegateComoParametros.Executar},
                { "metodo de extenção extensao sla", MetodosDeExtensao.Executar},
                { "Primeira Excessao", PrimeiraExcessao.Executar},
                { "Excessao personalizada", ExcessoesPersonalizadas.Executar},
                { "Primeiro Arquivo", PrimeiroArquivo.Executar},
                { "Lendo Arquivos", LendoArquivos.Executar},
                { "Exemplo File Info", ExemploFileInfo.Executar},
                { "Diretorios", Diretorios.Executar},
                { "Exemplo Diretory Info", ExemploDirectoryInfo.Executar},
                { "Exemplo DateTime", ExemploDateTime.Executar},
                { "LINQ 1", LINQ1.Executar},
                { "LINQ 2", LINQ2.Executar},
                { "Nullables", Nullables.Executar},
                { "Dynamics", Dynamics.Executar},
                { "Genericos", Genericos.Executar},
            });
             central.SelecionarExecutar();
        }
    }
}
