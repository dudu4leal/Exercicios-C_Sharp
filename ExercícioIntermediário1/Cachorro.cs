public class Cachorro : Animal
{
    
    public Cachorro(string nome) : base(nome)
    {
        
    }

    public override void emitirSom()
    {
        Console.WriteLine("RUF RUF RUF!");
    }



}