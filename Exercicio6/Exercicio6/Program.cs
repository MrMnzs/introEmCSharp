internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        int fator = 1;
        int cont;

        Console.WriteLine("digite um Valor: ");
        num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("");
        }
        else if ((num == 0) || (num == 1))
        {
            Console.WriteLine("");
        }
        else
        {
            for (cont = num; cont >= 1; cont--)
            {
                fator *= cont;
            }
            Console.WriteLine($"Fatorial de {num} é {fator}");
        }       
    }
}