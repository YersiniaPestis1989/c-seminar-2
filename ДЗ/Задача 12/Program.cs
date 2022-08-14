//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
string number1 = Console.ReadLine();
int length = number1.Length;
if(length >= 3)
{ 
int one = Int32.Parse(number1);
Console.Clear();
Console.WriteLine("Третья цифра в числе — " + number1[2]);
}
else
{
Console.WriteLine("Третьего числа нет!");    
}
