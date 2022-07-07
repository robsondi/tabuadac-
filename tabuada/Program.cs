using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int formula, contador, numero;
            Console.WriteLine("\n\n************ tabuada ****************");
            Console.WriteLine("\nDigite um  numero para obter a tabuada :");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (contador = 1; contador <= 10; ++contador)

            {
                formula = numero * contador;
                Console.WriteLine(numero + " x " + contador + " = " + formula);

            }
           
        }
    }
}
