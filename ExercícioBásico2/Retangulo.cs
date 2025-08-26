public class Retangulo
{
    public double Base { get; set; }

    public double Altura { get; set; }

    public string CalculaArea()
    {
        return $"A base do retangulo é {Base * Altura}";
    }

    public string CalculaPerimetro()
    {
        return $"O perímetro do retangulo é {2 * (Base + Altura)}";
    }

}