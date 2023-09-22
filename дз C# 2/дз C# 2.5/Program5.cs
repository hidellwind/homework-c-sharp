
internal class Program5
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Игра \"Угадай-ка\"");

        Random r = new Random();

        int iiNumber = r.Next(1, 101);
        int count = 0;
        int userNumber;
        string? userStr;

        for (; ; )
        {
            Console.WriteLine("Введите число: ");

            count++;
            userStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userStr))
            {
                Console.WriteLine($"Загаданным числом было: {iiNumber}");

                break;

            }
            userNumber = Convert.ToInt32(userStr);
            if (userNumber < iiNumber)
            {
                Console.WriteLine("Введеное число меньше заданного. Попробуйте еще раз.");

            }
            else if (userNumber > iiNumber)
            {
                Console.WriteLine("Введеное число больше загаданного. Попробуйте еще раз.");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Число  угадано! Число попыток: {count}.");
                Console.ReadKey();
            }


        }

    }
}