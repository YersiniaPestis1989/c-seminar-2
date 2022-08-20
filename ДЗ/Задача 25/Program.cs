// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Вариант без цикла
/*Console.WriteLine("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
double Multiple = Math.Pow(firstNumber, secondNumber);
Console.WriteLine("Первое число в степени второго числа равно " + Multiple);*/
//Вариант с циклом
Console.WriteLine("Введите число А ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int i = 0;
int res = 1;
while (i < secondNumber)
    
    { 
        res = res * firstNumber;
        i++;
    }
Console.Write("Число А в степени В равно " + res);
