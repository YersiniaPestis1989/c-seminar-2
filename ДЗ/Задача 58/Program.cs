// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
int arrayStr1 = new Random().Next(1, 10);
int arrayColumn1 = new Random().Next(1, 10);
int [,] array1 = new int[arrayStr1, arrayColumn1];
int arrayStr2 = new Random().Next(1, 10);
int arrayColumn2 = new Random().Next(1, 10);
int [,] array2 = new int[arrayStr2, arrayColumn2];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
Multiply(array1, array2);


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
void Multiply(int[,]matr1, int[,]matr2)
{
  
  if( matr1.GetLength(0)!= matr2.GetLength(0) && matr1.GetLength(1)!= matr2.GetLength(1))
  {
    Console.Write("Размеры матриц не совпадают");
  }
  else
  {
    int[,] matrixMulti = new int[matr1.GetLength(0)-1, matr1.GetLength(1)-1];
    for (int i = 0; i < matrixMulti.GetLength(0); i++)
 {
 for (int j = 0; j < matrixMulti.GetLength(1); j++)
   {
  // matrixMulti[i, j] = matr1[i, j]*matr2[i, j];
  for (int k = 0; k < matr2.GetLength(0); k++)
  {matrixMulti[i, j] += matr1[i, k]*matr2[k, j];
      Console.Write($"{matrixMulti[i, j]} ");}
   }
  Console.WriteLine();
  }
  }
}