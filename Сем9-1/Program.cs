//Показать натуральные числа от N до 1, N задано
Console.WriteLine("Введите число элементов ");
int N = Convert.ToInt32(Console.ReadLine());
Foo(N);
void Foo(int n)
{
if (n > 0)
    {
        Console.Write("{0} ", n);
        Foo(n - 1);
    }
}