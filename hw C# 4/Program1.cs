using System;

class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        string[] words = SplitSentence(sentence);
        PrintWords(words);
    }

    static string[] SplitSentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        return words;
    }

    static void PrintWords(string[] words)
    {
        Console.WriteLine("Разделенные слова:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}