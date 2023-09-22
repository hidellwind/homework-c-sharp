class Program4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину последовательности:");
        int length = int.Parse(Console.ReadLine());

        int minElement = int.MaxValue;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            if (number < minElement)
            {
                minElement = number;
            }
        }

        Console.WriteLine("Наименьший элемент: " + minElement);
    }
}
