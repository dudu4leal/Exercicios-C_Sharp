using System;

Pessoa pessoa = new();

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite a sua idade: ");
string idade = Console.ReadLine();

pessoa.Nome = "Eduardo";
pessoa.Idade = Int32.Parse(idade);

pessoa.Cumprimento();
pessoa.DizerIdade();
