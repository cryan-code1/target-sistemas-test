namespace ConsoleApp2.Tests;

public class Test5_InverterString
{
    public static void Executar()
    {
        string texto = "Exemplo de string";
        char[] caracteres = texto.ToCharArray();
        string invertido = "";

        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            invertido += caracteres[i];
        }

        Console.WriteLine($"[Exercicio 5] String invertida: {invertido}");
    }
}