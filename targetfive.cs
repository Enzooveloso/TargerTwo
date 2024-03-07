using System;
class Target
{
    static void Main(string[] args)
    {    Console.WriteLine("Digite a palavra que sera invertida");
        string original = Console.ReadLine();

        string invercao = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
           invercao += original[i];
        }

        Console.WriteLine($"String invertida: {invercao}");

    }
}