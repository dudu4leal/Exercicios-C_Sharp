namespace ExercicioIntermediario3;

public class AgendaTelefonica
{

    public List<Contato> Contatos { get; set; } = new List<Contato>();

    public void AdicionarContato()
    {
        Contato contato = new Contato();

        Console.WriteLine("Nome: ");
        contato.Nome = Console.ReadLine();

        Console.WriteLine("Número de telefone: ");
        contato.Numero = Console.ReadLine();

        Console.WriteLine("Email: ");
        contato.Email = Console.ReadLine();

        Contatos.Add(contato);

        Console.WriteLine($"Contato de {contato.Nome} adicionado com sucesso!");
    }

    public void RemoverContato()
    {

        if (Contatos.Count == 0)
        {
            Console.WriteLine("Não há contatos cadastrados");
            return;
        }

        Console.WriteLine("Qual contato deseja remover?");

        for (int i = 0; i < (Contatos.Count); i++)
        {
            Console.WriteLine($"[{i+1}] {Contatos[i].Nome}");
        }


        while (true)
        {

            string opcao = Console.ReadLine();
            int opcaoInt;

            if (int.TryParse(opcao, out opcaoInt))
            {
                if (opcaoInt <= Contatos.Count && opcaoInt > 0)
                {
                    Contatos.RemoveAt(opcaoInt - 1);
                    Console.WriteLine("Contato removido com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Contato inválido. Digite novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite novamente.");
            }
            
        }
    }

    public void BuscarContato()
    {
        Console.WriteLine("Digite o nome do contato: ");
        string nomeContato = Console.ReadLine();
        bool encontrado = false;

        foreach (var contato in Contatos)
        {
            if (contato.Nome == nomeContato)
            {
                Console.WriteLine($"Nº do {contato.Nome}: {contato.Numero}");
                Console.WriteLine($"Email do {contato.Nome}: {contato.Email}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"O contato {nomeContato} não existe");
        }

    }

}