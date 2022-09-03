// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
        int arrayStr1 = new Random().Next(0, 10);
int arrayColumn1 = new Random().Next(0, 10);
int [,] array1 = new int[arrayStr1, arrayColumn1];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FindIndexMin(array1);
PrintArray(array1);


void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
   {
   for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i,j] = new Random().Next(-10, 100);
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
            int[,] matrixMin = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];

            for (int i = 0; i < matr.GetLength(0); i++)

            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    for (int k = 0; k < matr.GetLength(1); k++)
                    {
                        if (matr[i, j] >= matr[i, k]) continue;
                        int temp = matr[i, j];
                        matr[i, j] = matr[i, k];
                        matr[i, k] = temp;
                    }
                    
                }
            }
        }