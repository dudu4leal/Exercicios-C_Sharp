public class Gato : Animal
{
    public Gato(string nome) : base(nome)
    {
        
    }

    public override void emitirSom()
    {
        Console.WriteLine("MIAU MIAU MIAU");
    }

}