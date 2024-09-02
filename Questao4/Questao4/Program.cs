using System;

class Program
{
    static void Main()
    {
        // Valores de faturamento por estado
        decimal sp = 67836.43M;
        decimal rj = 36678.66M;
        decimal mg = 29229.88M;
        decimal es = 27165.48M;
        decimal outros = 19849.53M;

        // Calcular o faturamento total
        decimal total = sp + rj + mg + es + outros;

        // Calcular o percentual de cada estado
        decimal percentualSP = (sp / total) * 100;
        decimal percentualRJ = (rj / total) * 100;
        decimal percentualMG = (mg / total) * 100;
        decimal percentualES = (es / total) * 100;
        decimal percentualOutros = (outros / total) * 100;

        // Exibir os resultados
        Console.WriteLine($"Percentual de representação por estado:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }
}
