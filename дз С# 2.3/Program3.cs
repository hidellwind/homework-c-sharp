class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число:");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;
        int i = 2;

        while (i < number)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
            i++;
        }

        if (isPrime)
        {
            Console.WriteLine("Число " + number + " является простым.");
        }
        else
        {
            Console.WriteLine("Число " + number + " не является простым.");
        }
    }
}