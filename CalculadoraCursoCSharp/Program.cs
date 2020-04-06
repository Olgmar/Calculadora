using System;

namespace CalculadoraCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string tmp;
            int op;

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite outro numero: ");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;
 
                resultado = num1 + num2;
                Console.WriteLine("Soma: " + resultado);

                resultado = num1 - num2;
                Console.WriteLine("Subtracao: " + resultado);

                resultado = num1 * num2;
                Console.WriteLine("Multiplicacao: " + resultado);

                resultado = num1 / num2;
                Console.WriteLine("Divisao: " + resultado);
        }
    }
}
