public class Pessoa
{

    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Cumprimento()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}!");
    }

    public void DizerIdade()
    {
        Console.WriteLine($"Eu tenho {Idade} anos");
    }

}