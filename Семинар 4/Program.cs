// прога принимает на вход число и выдает сумму от 1 до этого числа
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = 1;
while(i <= number)
{
sum += i++;
}

Console.WriteLine(sum); */
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i<= number; i++) // переменная i существует только в этом цикле
{
sum += i;
}

Console.WriteLine(sum);*/




// прога принимает число и выдает кол-во цифр в числе МОЙ ВАРИАНТ
/*Console.WriteLine("Введите число ");
string text = Console.ReadLine();
int lenght = text.Length;
Console.WriteLine(lenght);

ВАРИАНТ ПРЕПОДА
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = 0;
while(number > 0)
{
number /= 10;
countDigit++;
}

Console.WriteLine(countDigit);
*/




//Принимает на вход число и выдает произведение числен от 1 до этого числа
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Multiple = 1;
for (int i = 1; i<= number; i++)
{
    Multiple = Multiple * i; // Multiple +=;
}
Console.WriteLine(Multiple);*/
//Прога, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
/*int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 2);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}*/
