// Задача 45. Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования. САПРЫКИН

int size = 10;
int[] number = new int[size];
int[] other = new int[size];
FillArray(number);
PrintArray(number);
Console.ReadKey();

for (int i = 0; i < number.Length; i++)
{
    other[i] = number[i];
}
Console.WriteLine();
PrintArray(other);

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 10);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}