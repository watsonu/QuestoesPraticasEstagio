using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        if (numero < 0) return false;

        int a = 0;
        int b = 1;

        while (a < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a == numero;
    }
}
