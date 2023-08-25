using System.Globalization;

namespace exercicio02;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Produto[] vect = new Produto[n];

        for(int i = 0; i < n; i++)
        {
            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vect[i] = new Produto(nome, preco);
        }

        double soma = 0.0;

        for(int i = 0; i < n; i++)
        {
            soma += vect[i].Preco;
        }

        double media = soma / n;

        Console.Write("Média de preços: R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}

