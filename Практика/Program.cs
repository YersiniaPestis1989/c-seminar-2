// Выводит случайное чило [10, 99] и показывает наибольшую цифру числа

/*int randomNumber = GetRandomNumber(10, 99);
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;
int maxDigit = Max(firstDigit, secondDigit);

Console.WriteLine(maxDigit);


int GetRandomNumber(int min, int max)
{
return new Random().Next(min, max + 1);// указываем +1, так как это метода возвращает на единицу меньше от указанного максимума
}

int Max(int a, int b)
{
int max = 0;
if(a > b)
{
max = a;
}
else
{
max = b;
}
return max;
}
*/
//__________________________________________________________________________________________________________________________________


// Выводит случайное трехзначное число и удаляет вторую цифру этого числа
/*int randomNumber = GetRandomNumber(10, 999);
Console.WriteLine(randomNumber);

Console.WriteLine(DeleteSecondNumber(randomNumber));
int DeleteSecondNumber(int number)
{
int firstDigit = randomNumber / 100;
int lastDigit = randomNumber % 10;
return firstDigit * 10 + lastDigit;
}

int GetRandomNumber(int min, int max)
{
return new Random().Next(min, max + 1);// указываем +1, так как это метода возвращает на единицу меньше от указанного максимума
}
*/
//__________________________________________________________________________________________________________________________________



// Принимает на вход два числа и выводит, является ли первое число картным второму. Если число 1 некратно 2, то выводим остаток от деления
/*
int firstNumber = ReadInt("Первое число: ");
int secondNumber = ReadInt("Второе число: ");

int remainderOfDividion = firstNumber % secondNumber;
if(remainderOfDividion == 0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine("Числа не кратны, остаток от деления - " + remainderOfDividion);
}
int ReadInt(string message)
{
    Console.Write(message);
    
return Convert.ToInt32(Console.ReadLine()); 
}
*/
//__________________________________________________________________________________________________________________________________

// число одновременно кратное двум.
/*  int number = ReadInt("Введите первое число: ");
int firstDivider = 7;
int secondDivider = 23;

if(Multiple(number, firstDivider) && Multiple(number, secondDivider))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

bool Multiple(int a, int b)
{
return a % b == 0;
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}*/
   //__________________________________________________________________________________________________________________________________ 
  // Прога принимает два числа и проверяет, является ли одно число квадратом другого
/*int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

if(SqrNumber(firstNumber) == secondNumber || SqrNumber(secondNumber) == firstNumber)
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}

int SqrNumber(int number)
{
return number * number;
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}*/
//__________________________________________________________________________________________________________________________________
//Принимаем на вход координаты точки (икс и игрек), причем оба не равны 0 и выдаем номер четверти плоскости , в которой находится точка
/*int x = ReadInt("Введите координату X: ");
int y = ReadInt("Введите координату Y: ");

if(x == 0 || y == 0)
{
Console.WriteLine("Четверть определить невозможно");
return;
}

if (x > 0 && y > 0)
{
Console.WriteLine("Четверть 1");
}
else if(x < 0 && y > 0)
{
Console.WriteLine("Четверть 2");
}
else if(x < 0 && y < 0)
{
Console.WriteLine("Четверть 3");
}
else if(x > 0 && y < 0)
{
Console.WriteLine("Четверть 4");
}


int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}*/
//__________________________________________________________________________________________________________________________________
//по заданному диапозону четверти показывает диапазон возможных координат точек

/*int numberQuarter = ReadInt("Введите номер четверти ");
switch (numberQuarter)
{
    case 1:
    Console.WriteLine("x > 0, y > 0");
    break;
    case 2:
    Console.WriteLine("x < 0, y > 0");
    break;
    case 3:
    Console.WriteLine("x < 0, y < 0");
    break;
    case 4:
    Console.WriteLine("x > 0, y < 0");
    break;
    default:
    Console.WriteLine("Четвертей всего четыре");
    break;
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}*/
    
//__________________________________________________________________________________________________________________________________
//принимает на вход координаты 2 точек и находит расстоение между ними в 2д пространстве(через теорему пифагора)
/*int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int lengthX = x2 - x1;
int lengthY = y2 - y1;
double distance = Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}) -> {distance}");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}*/
//________________________________________________________________________________________________________________________
//Принимает на вход число и выдает таблицу квадратов числе от 1 до этого числа
/*int number = ReadInt("Введите число: ");
int i = 1;

while(i <= number)
{
Console.Write(Sqr(i) + " ");
i++;
}

int Sqr(int a)
{
return a * a;
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}*/
//________________________________________________________________________________________________________________________
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z1 = ReadInt("Введите Z точки A: ");
int z2 = ReadInt("Введите Z точки B: ");
int lengthX = x2 - x1;
int lengthY = y2 - y1;
int lengthZ = z2 - z1;
double distance = Math.Sqrt(lengthX * lengthX + lengthY * lengthY + lengthZ * lengthZ);
Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {distance}");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}*/
//________________________________________________________________________________________________________________________
