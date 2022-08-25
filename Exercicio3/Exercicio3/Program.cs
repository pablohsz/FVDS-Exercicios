/*
 * Faça um programa para listar todos os divisores de um número ou dizer que 
 * o número é primo caso não existam divisores.
 */

using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        ArrayList divisores = new ArrayList();

        Console.WriteLine("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }

        if (divisores.Capacity == 0)
        {
            Console.WriteLine("O número é primo");
        }
        else
        {
            Console.WriteLine("O número não é primo");
            Console.WriteLine("São divisores dele: ");
            foreach (Object item in divisores)
            Console.Write(" {0}", item);
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}