

public class ContaBancaria
{

    public string NumeroConta { get; set; }

    public double Saldo { get; private set; } = 0;

    public ContaBancaria()
    {
        Random random = new Random();
        NumeroConta = random.Next(100000, 1000000).ToString();
    }

    public void Depositar(double valor)
    {

        if (valor <= 0)
        {
            Console.WriteLine("Não foi possível realizar o depósito. Valor inválido");
        }
        else
        {
            Saldo += valor;
            Console.WriteLine($"Depósito realizado com sucessso!\nNovo saldo: R${Saldo}");
        }


    }

    public void Sacar(double valor)
    {

        if (valor <= 0)
        {
            Console.WriteLine("Não foi possível realizar o saque. Valor inválido");
        }
        else
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso!\nNovo saldo: R${Saldo}");
            }   
        }

    }

    public void VerificarSaldo()
    {
        Console.WriteLine($"Saldo em conta: R${Saldo}");
    }

}