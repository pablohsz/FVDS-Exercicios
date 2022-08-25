internal class Program
{
    private static void Main(string[] args)
    {
        Random gerador = new Random();
        int num, x = gerador.Next(100);

        Console.WriteLine("<><><> Um número de zero a cem foi gerado no sistema. Tente advinhar! <><><>");
        Console.Write("<> Digite seu lance: ");
        num = Convert.ToInt32(Console.ReadLine());
        while(x != num)
        {
            if (x > num)
            {
                Console.WriteLine("\nMAIOR >>>>\n");
            } else
            {
                Console.WriteLine("\nMENOR <<<<\n");
            }
            Console.Write("<> Digite seu lance: ");
            num = Convert.ToInt32(Console.ReadLine());
        } 
        Console.WriteLine("\n!!!!!!!!!!!!!!!GANHOU!!!!!!!!!!!!!!!");
        Console.ReadKey();

    }
}