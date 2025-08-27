public class Aluno
{

    public string Nome { get; set; }

    public string Matricula { get; set; }

    public List<double> Notas { get; set; } = new List<double>();

    public string calcularMedia()
    {

        double soma = 0;

        for (int i=0; i < (Notas.Count); i++)
        {
            soma += Notas[i];
        }

        double media = soma / Notas.Count;


        if (media < 6)
        {
            return $"Aluno: {Nome}\nMatrícula: {Matricula}\nMédia do {Nome}: {media:F2}\nSituação: recuperação.";
        }
        else
        {
            string situacao = "Aprovado";
            return $"Aluno: {Nome}\nMatrícula: {Matricula}\nMédia do {Nome}: {media:F2}\nSituação: aprovado!";
        }

    }

}