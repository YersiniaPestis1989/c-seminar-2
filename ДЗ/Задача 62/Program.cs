internal class Program
{
    private static void Main(string[] args)
    {
        // Заполните спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 1 2 3 4
        // 12 13 14 5
        // 11 16 15 6
        // 10 9 8 7
        int n = 4;
        int m = 4;
        int[,] array = new int[n, m];
    
        int str = 0;
        int col = 0;
        int dx = 1;
        int dy = 0;
        int dirChanges = 0;
        int visits = m;

        for (int i = 0; i < array.Length; i++)
        {
            array[str, col] = i + 1;
            if (--visits == 0)
            {
                visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
            }

            col += dx;
            str += dy;
        }
        PrintArray(array);
        void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
    }
}