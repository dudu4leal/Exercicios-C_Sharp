using System;

Retangulo retangulo = new();

Console.WriteLine("Qual a base do retangulo?");
retangulo.Base = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual a altura do retangulo?");
retangulo.Altura = Convert.ToDouble(Console.ReadLine());



Console.WriteLine(retangulo.CalculaArea());

Console.WriteLine(retangulo.CalculaPerimetro());
