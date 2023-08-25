using System.Globalization;

namespace exercicio01;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

        for (int i = 0; i < n; i++){
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma = 0.0;

        for(int i = 0; i < n; i++)
        {
            soma += vect[i];
        }

        double media = soma / n;

        Console.Write("Média das alturas: " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}

