
internal class Program2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Сколько карт у Вас на руках?");

        Console.WriteLine("Введите число:");
        int cardNumber = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < cardNumber; i++)
        {
            Console.WriteLine("Введите номинал карты:");
            string? currentCard = Console.ReadLine();
            switch (currentCard)
            {
                case "2":
                    sum += 2;
                    break;
                case "3":
                    sum += 3;
                    break;
                case "4":
                    sum += 4;
                    break;
                case "5":
                    sum += 5;
                    break;
                case "6":
                    sum += 6;
                    break;
                case "7":
                    sum += 7;
                    break;
                case "8":
                    sum += 8;
                    break;
                case "9":
                    sum += 9;
                    break;
                case "10":
                case "J":
                case "Q":
                case "K":
                case "T":
                    sum += 10;
                    break;
            }
        }
        Console.WriteLine($"Сумма Ваших карт: {sum}");
    }

}