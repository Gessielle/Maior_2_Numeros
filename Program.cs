using System;

namespace Maior_2_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double maior = 0;

            Console.WriteLine("Digite o 1º Número: ");
            numero = double.Parse(Console.ReadLine());
            if (numero > maior)
            {
                maior = numero;
            }

            Console.Write("Digite o 2º Número: ");
            numero = double.Parse(Console.ReadLine ());
            if (numero > maior)
            {
                Console.WriteLine();
                maior = numero;
            }
            Console.WriteLine("O maior número digitado é: {0} " , maior);

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine ();
            Console.WriteLine ( " Pressione ENTER para sair! ");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
