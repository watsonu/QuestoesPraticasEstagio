using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Faturamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = "faturamento.json"; // Substitua pelo caminho do seu arquivo

            
            var dados = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(File.ReadAllText(arquivo));

            // Extrair os valores de faturamento
            var faturamentos = dados.Where(f => f.Valor > 0).Select(f => f.Valor).ToList();

            // Calcular a média, menor e maior valor
            double media = faturamentos.Average();
            double menorValor = faturamentos.Min();
            double maiorValor = faturamentos.Max();

            
            int diasAcimaMedia = faturamentos.Count(f => f > media);

            // Exibir os resultados
            Console.WriteLine($"Menor valor de faturamento: R$ {menorValor:F2}");
            Console.WriteLine($"Maior valor de faturamento: R$ {maiorValor:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
        }
    }

    // Classe para representar os dados de faturamento diário
    class FaturamentoDiario
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}