//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число ");
int one = Int32.Parse(Console.ReadLine());
Console.Clear();
int[]hollyday = {6, 7};
if(one == hollyday[0] ^ one == hollyday[1])
{
    Console.WriteLine("Да, это выходной");
}
else
{
    Console.WriteLine("Нет, это не выходной");
}
