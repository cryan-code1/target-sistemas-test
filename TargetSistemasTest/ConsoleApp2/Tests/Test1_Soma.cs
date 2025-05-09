namespace ConsoleApp2.Tests;

public static class Test1_Soma
{
    public static void Executar()
    {
        int soma = 0;
        for (int k = 1; k <= 13; k++)
        {
            soma += k;
        }

        Console.WriteLine($"[Exercicio 1] Soma final: {soma}\n");
    }
}