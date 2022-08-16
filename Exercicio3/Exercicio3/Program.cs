using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um Valor de tempo em horas para Otimista: ");
        double otimista = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um Valor de tempo em horas para Pessimista: ");
        double pessimista = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um Valor de tempo em horas para Provavel: ");
        double provavel = double.Parse(Console.ReadLine());
        
        double media = (((otimista + pessimista + (4 * provavel)) / 6));        

        Console.WriteLine($"A duração média desta atividade de ser de: {media:f2}h");
    }
}