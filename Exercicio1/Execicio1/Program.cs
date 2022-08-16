

internal class Program
{
    private static void Main(string[] args)
    {         
        Console.WriteLine("Digite um valor para A: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para B: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para C: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Área do triângulo: " + ((a*c)/2));

        Console.WriteLine("Área do círculo: " + (Math.PI * (c*c)));

        Console.WriteLine("Área do Trapézio: " + (((a + b) * c )/ 2));

        Console.WriteLine("Área do quadrado: " + (b*b));

        Console.WriteLine("Área do retângulo: " + (a*b));

    }
}