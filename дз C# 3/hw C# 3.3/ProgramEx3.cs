 internal class ProgramEx3
{
    static void Main(string[] args)
    {
        int m = 10;
        int n = 10;

        bool[,] petriDish = new bool[m, n];

        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                petriDish[i, j] = random.Next(2) == 0;
            }
        }

        while (true)
        {
            Console.Clear();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(petriDish[i, j] ? "O " : ". ");
                }
                Console.WriteLine();
            }

            bool[,] newPetriDish = new bool[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int neighbors = CountNeighbors(petriDish, i, j);

                    if (petriDish[i, j])
                    {
                        if (neighbors < 2 || neighbors > 3)
                        {
                            newPetriDish[i, j] = false;
                        }

                        else
                        {
                            newPetriDish[i, j] = true;
                        }
                    }
                    else
                    {
                        if (neighbors == 3)
                        {
                            newPetriDish[i, j] = true;
                        }
                        
                        else
                        {
                            newPetriDish[i, j] = false;
                        }
                    }
                }
            }

            petriDish = newPetriDish;

            System.Threading.Thread.Sleep(100);
        }
    }

    static int CountNeighbors(bool[,] petriDish, int x, int y)
    {
        int count = 0;
        int m = petriDish.GetLength(0);
        int n = petriDish.GetLength(1);

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i == 0 && j == 0)
                    continue;

                int neighborX = (x + i + m) % m;
                int neighborY = (y + j + n) % n;

                if (petriDish[neighborX, neighborY])
                    count++;
            }
        }

        return count;
    }
}