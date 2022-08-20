// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
  while( number> 0)
  {
    result += number % 10;
    number /= 10;       
   }
            
Console.WriteLine("Сумма всех цифр числа = " + result);
            
