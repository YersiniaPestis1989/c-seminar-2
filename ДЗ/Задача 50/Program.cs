// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int arrayStr = new Random().Next(0, 10);
int arrayColumn = new Random().Next(0, 10);
int [,] array = new int[arrayStr, arrayColumn];
FillArray(array);
PrintArray(array);
Console.WriteLine("Размер массива таков: количество строк = {0}, количество столбцов = {1}", arrayStr, arrayColumn);
//вывожу количество строк и столбцов для удобства проверки
Console.WriteLine("Введите положение элемента в строке");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положение элемента в столбце");
int column = Convert.ToInt32(Console.ReadLine());

if (str > arrayStr || column > arrayColumn) { Console.Write("Такого числа в массиве нет");}
else {Console.WriteLine("Элемент, который вы искали равен " + array[str, column]);}

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
