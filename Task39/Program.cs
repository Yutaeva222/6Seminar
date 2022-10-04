// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний
// элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] SwapArray(int[] arr)
{
    int[] tempArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArr[arr.Length - 1 - i] = arr[i];
    }
    return tempArr;
}
int [] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(SwapArray(array));
