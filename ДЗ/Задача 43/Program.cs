// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите А");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите C");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите C");
double k2 = Convert.ToDouble(Console.ReadLine());
bool eqK = k2==k1;
bool eqB = b2==b1;
double x = 0;
double y = 0;
if(eqK || (eqB && eqK))
{
    Console.WriteLine("Прямые не пересекаются в одной точке");
}
else {
    x = (b2-b1)/(k1-k2);
    y = (k1*b2 -k2*b1)/(k1-k2);
   Console.WriteLine("Точка пересечения этих прямых имеет координаты: x = {0},  y = {1}", x, y);

}