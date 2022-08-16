internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um Valor para A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um Valor para B: ");
        int b = int.Parse(Console.ReadLine());

        if (a%b==0)
        {
            Console.WriteLine($"Esses valores {a} e {b} são multiplos entre eles: ");
        }
        else
        {
            Console.WriteLine($"Esses valores {a} e {b} não são multiplos entre eles: ");
        }        
    }
}