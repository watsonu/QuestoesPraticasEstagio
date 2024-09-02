using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string paraInverter = Console.ReadLine();
        string invertida = StringInvertida(paraInverter);
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string StringInvertida(string str)
    {
        // Converte a string em um array de caracteres
        char[] carateresDaString = str.ToCharArray();
        string invertida = String.Empty;

        for (int i = carateresDaString.Length - 1; i >= 0; i--)
        {
            invertida += carateresDaString[i];
        }

        return invertida;
    }
}
