public class Animal
{

    public Animal()
    {
    }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public virtual void emitirSom()
    {
        Console.WriteLine("Rrrrrr");
    }

}