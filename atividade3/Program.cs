using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n;
        double media = 0;
        Console.WriteLine("Digite quantos numeros deseja ler: ");
        Int32.TryParse(Console.ReadLine(), out n);
        Double[] num = new Double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite o" + (i + 1) + "° número: ");
            Double.TryParse(Console.ReadLine(), out num[i]);
            media += num[i];
        }
        media = media / n;
        Console.WriteLine("A media dos valores é: " + media);

    }
}
