// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой длины.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CheckArray(int[] arr)
{
    int max = arr[0];
    int summ = 0;
    int indMax = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max = arr[i];
            indMax = i;
            summ = summ + arr[i];
        }
    }
    summ = summ - arr[indMax];
    if (arr[indMax] < summ)
    {
        Console.WriteLine ("Этот треугольник существует!");
    }
    else 
    Console.WriteLine ("Этот треугольник не может существовать!");
}

int[] array = new int [3];
FillArray(array);
CheckArray(array);
