using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        bool loop = true;

        while(loop)
        {
            Console.WriteLine("Digite um valor entre 1 e 3: ");
            int entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    Console.WriteLine("bom dia!");
                    loop = false;
                    break;
                case 2:
                    Console.WriteLine("Boa tarde");
                    loop = false;
                    break;
                case 3:
                    Console.WriteLine("Boa noite");
                    loop = false;
                    break;
                default:
                    Console.WriteLine("O valor " + entrada + " é invalido!");
                    break;
            }
        }

        

    }  
}