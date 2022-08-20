//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];
FillArray(numbers);
PrintArray(numbers);

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, N+1);
    }
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
