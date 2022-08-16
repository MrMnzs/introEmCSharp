internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());

        int m = 0;
        while (m < n)
        {
            m++;
            Console.WriteLine($"contagem: { m }");
            Console.WriteLine($"o seu dobro: { m * m}");
            Console.WriteLine($"o seu triplo: { m * m * m}");
            Console.WriteLine(" ");
        }
    }
}