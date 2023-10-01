using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:");
        string inputPhrase = Console.ReadLine();

        string[] words = SplitWords(inputPhrase);
        string reversedPhrase = ReverseWords(words);

        Console.WriteLine("Предложение в рандомной последовательности:");
        Console.WriteLine(reversedPhrase);
    }

    static string[] SplitWords(string inputPhrase)
    {
        string[] words = inputPhrase.Split(' ');
        return words;
    }

    static string ReverseWords(string[] words)
    {
        Array.Reverse(words);
        string reversedPhrase = string.Join(" ", words);
        return reversedPhrase;
    }
}