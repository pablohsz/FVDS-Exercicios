internal class Program
{
    private static void Main(string[] args)
    {

        /*
        Faça um algoritmo que leia vários números double até que o usuário digite 0 (zero)
        para encerrar a leitura. Enquanto lê os números, o algoritmo vai calculando o que 
        for necessário para, após ler os números, imprimir: a soma e a média desses números,
        o maior e o menor número digitado.
         */

        double input, soma = 0, media, maior, menor;
        int cont = 0;
        

        Console.WriteLine("Digite um número:");
        input = Convert.ToDouble(Console.ReadLine());
        maior = input;
        menor = input;
        while(input != 0)
        {
            ++cont;
            soma += input;
            if(input > maior)
            {
                maior = input;
            } else
            {
                if (input < menor)
                {
                    menor = input;
                }
            }
            Console.WriteLine("Digite um número:");
            input = Convert.ToDouble(Console.ReadLine());
        }

        media = soma / (double)cont;
        Console.WriteLine("Foram lidos {0} números.", cont);
        Console.WriteLine("A soma dos números lidos é {0:0.00}.", soma);
        Console.WriteLine("A média dos números lidos é {0}.", media);
        Console.WriteLine("O maior número é: {0}", maior);
        Console.WriteLine("O menor número é: {0}", menor);
        Console.ReadKey();
    }
}