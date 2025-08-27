
using System;

Produto produto = new();

produto.Nome = "PlayStation 5";
produto.Preco = 2500.00;
produto.QuantidadeEmEstoque = 100;

Console.WriteLine($"Produto: {produto.Nome}");
Console.WriteLine($"Valor do {produto.Nome}: R${produto.Preco}");
Console.WriteLine($"Quantidade em estoque: {produto.QuantidadeEmEstoque}");

Console.WriteLine($"Chegaram {produto.Nome} na loja hoje?");
int novosProdutos = Convert.ToInt32(Console.ReadLine());
produto.AdicionarItens(novosProdutos);

Console.WriteLine($"Quantos {produto.Nome} foram vendidos hoje?");
int produtosVendidos = Convert.ToInt32(Console.ReadLine());
produto.RemoverItens(produtosVendidos);

Console.WriteLine($"{produto.Nome} em estoque no final do dia: {produto.QuantidadeEmEstoque}");






