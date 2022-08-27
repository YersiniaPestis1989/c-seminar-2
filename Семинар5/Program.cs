// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
int size = 12;
int[] numbers = new int[size];
int sumPositive = 0;
int sumNegative = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
if(numbers[i] > 0)
sumPositive += numbers[i];
else
sumNegative += numbers[i];
}
Console.WriteLine($"Сумма положительных элементов равна {sumPositive}\n" + //\n это символ перевода текста на другую строку
$"Сумма отрицательных равна {sumNegative}");

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-9, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}


//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int size = 5;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = -numbers[i];
}
PrintArray(numbers);

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-9, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Вариант1
int size = 5;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

Console.Write("Введите искомое число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < numbers.Length; i++)
{
if(numbers[i] == searchNumber)
{
Console.WriteLine("Yes");
break;
}
else if (i == numbers.Length - 1)
{
Console.WriteLine("No");
}
}

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-9, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
// Вариант 2
int size = 5;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

Console.Write("Введите искомое число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());
bool existNumber = false;

for(int i = 0; i < numbers.Length; i++)
{
if(numbers[i] == searchNumber)
{
existNumber = true;
break;
}
}

if(existNumber) // как сравненеи - само по себе булевая переменная, можно сократить условие, вместо неравенства
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-9, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
// Вариант 3
int size = 5;
int[] numbers = new int[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

Console.Write("Введите искомое число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < numbers.Length; i++)
{
if(numbers[i] == searchNumber)
{
Console.WriteLine("Yes");
return;
}
}
Console.WriteLine("No");

void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-9, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}


//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.




//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.




//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
int size = 123;
int[] numbers = new int[size];
int min = 10;
int max = 99;
int count = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
if(numbers[i] >= min && numbers[i] <= max)
count++;
}
Console.WriteLine(count);


void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 120);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}



//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int size = 7;
int[] numbers = new int[size];
int[] pairs;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

if(numbers.Length % 2 == 0) //проверяем четность\нечетность количества элементов массива
{
pairs = new int[numbers.Length / 2];
}
else
{
pairs = new int[numbers.Length / 2 + 1];
pairs[pairs.Length - 1] = numbers[numbers.Length / 2];
}

for(int i = 0; i < numbers.Length / 2; i++)
{
pairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
PrintArray(pairs);


void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}




