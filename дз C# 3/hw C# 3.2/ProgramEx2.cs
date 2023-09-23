internal class ProgramEx2
{
    static void Main(string[] args)
    {
        int[,] matrix1 = GenerateRandomMatrix(2, 3);
        int[,] matrix2 = GenerateRandomMatrix(2, 3);

        int[,] sumMatrix = AddMatrices(matrix1, matrix2);

        Console.WriteLine("Первая матрица:");
        PrintMatrix(matrix1);

        Console.WriteLine("Вторая матрица:");
        PrintMatrix(matrix2);

        Console.WriteLine("Сумма матриц:");
        PrintMatrix(sumMatrix);

        static int[,] GenerateRandomMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next();
                }
            }

            return matrix;
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            int[,] sumMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return sumMatrix;
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
