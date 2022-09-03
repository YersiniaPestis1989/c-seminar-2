internal class Program
{
    private static void Main(string[] args)
    {
        // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
        // добавляя индексы каждого элемента.
        // массив размером 2 x 2 x 2
        // 12(0,0,0) 22(0,0,1)
        // 45(1,0,0) 53(1,0,1)
        int arrayStr = new Random().Next(0, 10);
        int arrayColumn = new Random().Next(0, 10);
        int arrayCol = new Random().Next(0, 10);
        int[,,] array = new int[arrayStr, arrayColumn, arrayCol];
        FillArray(array);
        PrintArray(array);

        void FillArray(int[,,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {

                    for (int k = 0; k < matr.GetLength(2); k++)
                    {
                        int RandomNumber = new Random().Next(10, 100);
                        int m = 0;
                        foreach (var item in matr)
                            if (item == RandomNumber) m++;
                            else matr[i, j, k] = RandomNumber;

                    }
                }
            }
        }

        void PrintArray(int[,,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    for (int k = 0; k < matr.GetLength(2); k++)
                    {
                        Console.Write($"{matr[i, j, k]} ({i}, {j}, {k}); ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}