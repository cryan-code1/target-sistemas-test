namespace ConsoleApp2.Tests;

public static class Test4_FaturamentoPorEstado
{
    public static void Executar()
    {
        var faturamentos = new Dictionary<string, decimal>
        {
            { "SP", 67836.43m },
            { "RJ", 36678.66m },
            { "MG", 29229.88m },
            { "ES", 27165.48m },
            { "Outros", 19849.53m }
        };

        decimal total = faturamentos.Values.Sum();

        Console.WriteLine("[Exercicio 4] Percentual por estado:");
        foreach (var estado in faturamentos)
        {
            decimal percentual = estado.Value / total * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
        Console.WriteLine();
    }
}
