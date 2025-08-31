using System;
using ExercicioIntermediario3;


AgendaTelefonica agendaTelefonica = new AgendaTelefonica();

agendaTelefonica.CarregarContatos();

while (true)
{
    Console.WriteLine("\nAGENDA TELEFONICA\n");

    Console.WriteLine("[1] Buscar contato");
    Console.WriteLine("[2] Adicionar contato");
    Console.WriteLine("[3] Remover contato");
    Console.WriteLine("[4] Sair do sistema");


    Console.WriteLine("Selecione sua opção: ");
    string opcao = Console.ReadLine();
    int intOpcao;

    while (!int.TryParse(opcao, out intOpcao) || intOpcao < 1 || intOpcao > 4)
    {
        Console.WriteLine("Opção inválida. Digite novamente");
        opcao = Console.ReadLine();
    }


    if (intOpcao == 1)
    {
        agendaTelefonica.BuscarContato();
    }
    else if (intOpcao == 2)
    {
        agendaTelefonica.AdicionarContato();
    }
    else if (intOpcao == 3)
    {
        agendaTelefonica.RemoverContato();
    }
    else if (intOpcao == 4)
    {
        Console.WriteLine("Fechando a aplicação...");
        agendaTelefonica.SalvarContatos();
        break;
    }

}