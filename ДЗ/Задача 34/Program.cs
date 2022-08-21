// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int size = 5;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
//bool Even = numbers[i] % 2 == 0; пр попытке ввести булевую переменную в условия, выдает ошибку "The name 'i' does not exist in the current context"
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
    sum = sum + 1;
}
}

Console.WriteLine("Количество четных чисел в массиве равно " + sum);
void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.WriteLine(array[i] + " ");
}
}

