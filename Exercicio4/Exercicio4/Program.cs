using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (EhPerfeito(num))
        {
            Console.WriteLine("O número é perfeito! A soma de seus divisores é igual a ele mesmo.");
        } else
        {
            Console.WriteLine("Não é perfeito!");
        }
    }

    public static Boolean EhPerfeito(int numero)
    {
        //Já leva em consideração a divisão por 1.
        int soma = 1;
        ArrayList divisores = new ArrayList();

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }

        if (divisores.Count == 0)
        {
            Console.WriteLine("O número inserido é primo.");
            return false;
        }

        foreach (Object item in divisores)
        {
            soma += Convert.ToInt32(item);
        }

        if (soma == numero)
        {
            return true;
        } else
        {
            return false;
        }
    }

}