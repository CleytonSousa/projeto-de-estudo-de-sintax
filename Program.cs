using System;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            listaAluno lista = new listaAluno();
            string resposta = "s";
            do {
                Aluno aluno = new Aluno();
                Console.WriteLine("Informe o nome do aluno: ");
                aluno.nome = Console.ReadLine();

                Console.WriteLine("Informe a idade do aluno: ");
                aluno.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a nota do aluno: ");
                aluno.nota = Double.Parse(Console.ReadLine());

                lista.adicionar(aluno);

                Console.WriteLine("Deseja inserir novo aluno? (s/n): ");
                aluno.nome = Console.ReadLine();

                if (resposta == "n")
                {
                    Console.WriteLine(lista.totalizar());
                }
            } while (resposta == "s");
        }
    }
}
