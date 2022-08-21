// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
Console.WriteLine();
int sum = 0;
for (int i = 1; i < numbers.Length; i = i + 2)
{
    sum = sum + numbers[i];
}
Console.Write("Сумма чисел с нечетным индексом равна " + sum);

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}
// Более длинный вариант с условием
/*int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
Console.WriteLine();
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0) 
    sum = sum + numbers[i];
}
Console.Write("Сумма чисел с нечетным индексом равна " + sum);

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}*/