public class Produto
{

    public string Nome { get; set; }

    public double Preco { get; set; }

    public int QuantidadeEmEstoque { get; set; }

    public void AdicionarItens(int qtdItens)
    {

        QuantidadeEmEstoque += qtdItens;

    }

    public void RemoverItens(int qtdItens)
    {
        QuantidadeEmEstoque -= qtdItens;

    }   

    }
