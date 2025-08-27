using System;

Aluno aluno = new();

Console.WriteLine("Qual o nome do aluno?");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Qual a matrícula do aluno?");
aluno.Matricula = Console.ReadLine();

Console.WriteLine("Quantas notas serão avaliadas?");
int qtdNotas = Convert.ToInt32(Console.ReadLine());

for (int i=0; i < qtdNotas; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª nota:");
    aluno.Notas.Add(double.Parse(Console.ReadLine()));
}

Console.WriteLine(aluno.calcularMedia());

