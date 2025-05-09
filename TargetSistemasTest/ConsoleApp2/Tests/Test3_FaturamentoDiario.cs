using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp2.Tests;

public class FaturamentoDia
{
    [JsonPropertyName("dia")]
    public int Dia { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}

public static class Test3_FaturamentoDiario
{
    public static void Executar()
    {
        var dados = JsonSerializer.Deserialize<List<FaturamentoDia>>(File.ReadAllText("dados.json"));

        var diasComFaturamento = dados?.Where(d => d.Valor > 0).ToList() ?? [];

        if (!diasComFaturamento.Any())
        {
            Console.WriteLine("Nenhum dia com faturamento registrado.");
            return;
        }

        var menor = diasComFaturamento.Min(d => d.Valor);
        var maior = diasComFaturamento.Max(d => d.Valor);
        var media = diasComFaturamento.Average(d => d.Valor);
        var diasAcimaDaMedia = diasComFaturamento.Count(d => d.Valor > media);

        Console.WriteLine("[Exercicio 3]");
        Console.WriteLine($"Menor faturamento: R${menor:F2}");
        Console.WriteLine($"Maior faturamento: R${maior:F2}");
        Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
    }
}
