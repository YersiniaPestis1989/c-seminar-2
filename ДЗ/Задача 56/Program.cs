        // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
        int arrayStr = new Random().Next(0, 10);
        int arrayColumn = new Random().Next(0, 10);
        int[,] array = new int[arrayStr, arrayColumn];
        FillArray(array);
        PrintArray(array);
        int sumStr = 0;
        FindIndexMin(array);

        void FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(-10, 100);
                }
            }
        }

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
        void FindIndexMin(int[,] matr)
        {
            int sumStr = 0;
            int indexMinRow = 0;
            int[,] matrixMin = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sumStr = sumStr + matr[i, j];
                    if (0 >= sumStr){indexMinRow = i;}
                }
            Console.WriteLine("Сумма строки " + i + " — " + sumStr); 
            sumStr = 0;
            }
            Console.WriteLine("Строка с наименьшей суммой элементов — " + indexMinRow);
        }
