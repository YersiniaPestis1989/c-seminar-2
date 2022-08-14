//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;
if(length == 5)
{
if (number[0]==number[4] && number[1]==number[3])
{
    Console.Write("Это палиндром");
}
else
{
    Console.Write("Это не палиндром");
}
}
else
{
    Console.Write("Это не пятизначное число, до свидания!");
}
