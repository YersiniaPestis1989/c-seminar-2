// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
int size = 5;
double[] numbers = new double[size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
Console.WriteLine();
double max = numbers[0];
double min = numbers[0];
FindMaxMinNumbres(numbers);
Console.WriteLine("Минимальное число " + min);
Console.WriteLine("Максимальное число " + max);
Console.WriteLine("Разница между минимальным и максимальным числами равна  " + (max - min));

void FindMaxMinNumbres(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
    if (numbers[i] < min)
            min = numbers[i];
    if (numbers[i] > max)
            max = numbers[i];
}
}
void FillArrayRandomNumbres(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = Convert.ToDouble(new Random().Next(100, 1000) / 10.0);
}
}

void PrintArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}
/*Random rand = new Random();
  double[] numbers = new double[10];


 void FillArrayRandomNumbres(double[] array)
 {
    for (int i = 0; i < numbers.Length; i++)
    numbers[i] = rand.NextDouble();
 } 

for (int i = 0; i < numbers.Length; i++)
{
            Console.Write(numbers[i] + " ");
            }*/