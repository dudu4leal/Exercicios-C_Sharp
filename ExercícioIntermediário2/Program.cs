using System;

while (true)
{

    Console.WriteLine("Bem-vindo ao Banco! Deseja criar sua conta? [S/N]");

    string resposta = Console.ReadLine().ToUpper();
    while (resposta != "S" && resposta != "N")
    {
        Console.WriteLine("Resposta inválida. Digite novamente [S/N]").Toupper();
        resposta = Console.ReadLine();
    }


    if (resposta == "N")
    {
        Console.WriteLine("Volte quando quiser criar uma conta!");
        break;
    }
    else if (resposta == "S")
    {
        ContaBancaria contaBancaria = new ContaBancaria();
        Console.WriteLine("Conta criada com sucesso! Seja bem-vindo!");
        Console.WriteLine($"Numero da sua conta {contaBancaria.NumeroConta}");

        while (true)
        {

            Console.WriteLine("O que vamos fazer?");
            Console.WriteLine("[1] Verificar seu saldo");
            Console.WriteLine("[2] Realizar depósito");
            Console.WriteLine("[3] Realizar um saque");
            Console.WriteLine("[4] Sair do sistema");

            string input = Console.ReadLine();
            int resposta2 = Convert.ToInt32(input);


            while (resposta2 != 1 && resposta2 != 2 && resposta2 != 3 && resposta2 != 4)
            {
                Console.WriteLine("Resposta inváçida. Digite novamente");
                input = Console.ReadLine();
                resposta2 = Convert.ToInt32(resposta2);
                
            }


            if (resposta2 == 1)
            {
                contaBancaria.VerificarSaldo();
            }
            else if (resposta2 == 2)
            {
                Console.WriteLine("Quanto você deseja depositar?");
                string valorDeposito = Console.ReadLine();
                double valor = double.Parse(valorDeposito);

                contaBancaria.Depositar(valor);
            }
            else if (resposta2 == 3)
            {
                Console.WriteLine("Quanto você deseja sacar?");
                string valorSaque = Console.ReadLine();
                double valor = double.Parse(valorSaque);

                contaBancaria.Sacar(valor);
            }
            else if (resposta2 == 4)
            {
                Console.WriteLine("Saindo do sistema...");
                break;
            }
        }
        break;
    }

}