internal class ProgramEx1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк в матрице:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в матрице:");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next();
            }
        }

        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("Сумма элементов матрицы: " + sum);
    }
}