using System;

class Program
{
    static void Main()
    {

        int totalPoints = 0;

        Console.Write("Введите количество баллов по первому предмету: ");
        int pointsSubject1 = int.Parse(Console.ReadLine());
        totalPoints += pointsSubject1;

        Console.Write("Введите количество баллов по второму предмету: ");
        int pointsSubject2 = int.Parse(Console.ReadLine());
        totalPoints += pointsSubject2;

        Console.Write("Введите количество баллов по третьему предмету: ");
        int pointsSubject3 = int.Parse(Console.ReadLine());
        totalPoints += pointsSubject3;

        double average = (double)totalPoints / 3;

        Console.WriteLine($"Сумма баллов: {totalPoints}");
        Console.WriteLine($"Средний балл: {average}");

        Console.ReadKey();
    }
}