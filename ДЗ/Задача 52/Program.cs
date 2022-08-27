// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
int arrayStr = new Random().Next(0, 10);
int arrayColumn = new Random().Next(0, 10);
int [,] array = new int[arrayStr, arrayColumn];
FillArray(array);
PrintArray(array);
double average = 0;
SearchAverage(array);

void SearchAverage(int[,] matr)
{
 for (int j = 0; j < matr.GetLength(1); j++)
  {
   for (int i = 0; i < matr.GetLength(0); i++)
   {
    average = average + matr[i, j];
   }
   Console.WriteLine("Среднее арифметическое элементов в столбце " + j + " — " + (average)/matr.GetLength(0));
   average = 0;
  }
}

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