using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            while (true)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                if (nome == "")
                {
                    break;
                }
                Console.Write("P1: ");
                double p1 = double.Parse(Console.ReadLine());
                Console.Write("P2: ");
                double p2 = double.Parse(Console.ReadLine());

                Aluno novo = new Aluno(nome, p1, p2);
                alunos.Add(novo);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Alunos Aprovados");
            Console.WriteLine("================");
            foreach (Aluno a in alunos)
            {
                if (a.Aprovado)
                {
                    Console.WriteLine("{0} - {1}", a.Nome, a.Media);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Alunos Reprovados");
            Console.WriteLine("=================");
            foreach (Aluno a in alunos)
            {
                if (!a.Aprovado)
                {
                    Console.WriteLine("{0} - {1}", a.Nome, a.Media);
                }
            }
        }
    }
}
