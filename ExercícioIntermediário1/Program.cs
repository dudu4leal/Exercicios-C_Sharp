using System;

Cachorro cachorro = new Cachorro("Polly");

Console.WriteLine(cachorro.Nome);
cachorro.emitirSom();

Animal animal = new Animal("Tartaruga");

Console.WriteLine(animal.Nome);
animal.emitirSom();

Gato gato = new Gato("Maurice");
Console.WriteLine(gato.Nome);
gato.emitirSom();
