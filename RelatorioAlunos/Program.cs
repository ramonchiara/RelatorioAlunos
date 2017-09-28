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
            Aluno[] alunos = new Aluno[3];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Entre com os dados do aluno {0}", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("P1: ");
                double p1 = double.Parse(Console.ReadLine());
                Console.Write("P2: ");
                double p2 = double.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, p1, p2);

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
