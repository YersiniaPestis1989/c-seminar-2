//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
string number1 = Console.ReadLine();
int length = number1.Length;
if(length == 3)
{ 
int one = Int32.Parse(number1);
Console.Clear();
int thirdseconNumber = one % 100;
int seconNumber = thirdseconNumber / 10;
Console.WriteLine("Вторая цифра в числе: " + seconNumber);
}
else
{
Console.WriteLine("Вы ввели не трехзначное число, пока!");    
}
