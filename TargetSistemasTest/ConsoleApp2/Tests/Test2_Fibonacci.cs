namespace ConsoleApp2.Tests;

public static class Test2_Ficonacci
{
    public static void Executar()
    {
        int numeroAlvo = 21;
        int anterior = 0, atual = 1;

        while (atual < numeroAlvo)
        {
            int temp = atual;
            atual = anterior + atual;
            anterior = temp;
        }

        string resultado = (atual == numeroAlvo || numeroAlvo == 0)
            ? "pertence à sequência de Fibonacci."
            : "não pertence à sequência de Fibonacci.";

        Console.WriteLine($"[Exercicio 2] O número {numeroAlvo} {resultado}\n");
    }
}