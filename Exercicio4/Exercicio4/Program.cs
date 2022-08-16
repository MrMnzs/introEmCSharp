internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digiti qual a sua nota neste trabalho: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Parabéns você está Aprovado!!!");
        }
        else if (nota < 7 && nota >= 4)
        {
            Console.WriteLine("A Recuperação vai ser boa!!!");
        }
        else 
        {
            Console.WriteLine("Deu Ruim você foi Rerprovado!!!");
        }            
    }
}