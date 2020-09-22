using System;

namespace P3ValidationAlgorithm
{
    class Program
    {
        static int numero;
        static void Main(string[] args)
        {
           System.Console.WriteLine("escrive la lonjitud de tu array");
           numero = Convert.ToInt32(Console.ReadLine());
           
           for (int i = 1; i <= numero; i++)
           {
               System.Console.Write($"1,");
           }
           System.Console.Write(numero);
        }
    }
}
