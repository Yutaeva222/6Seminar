// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// void SwapArrayTwo(int[] arr)
// {
//     int swap;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         swap = arr[arr.Length - i - 1];
//         arr[arr.Length - i - 1] = arr[i];
//         arr[i] = swap;
//     }
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }
// Console.WriteLine("Введите число десятичной системы: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int temp = a;
// int index =0;
// while(temp > 0)
// {
//     index++;
//     temp /= 2;
// }
// int[] arr = new int[index];
// for (int i = 0; i < arr.Length; i++)
// {
//    arr[i] = a % 2;
//    a /= 2;
// }
// SwapArrayTwo(arr);
// PrintArray(arr); 

// Вариант у Сапрыкина Дениса.
// void zadacha40()
// {
// int number = 45;
// string result = " ";
// while (number >0)
// {
//     result = number %2 + result;
//     number/=2;
// }
// Console.WriteLine(result);
// }
// zadacha40();

// Вариант #2 у Сапрыкина Дениса.
int number = 30;
string result = Convert.ToString(number, 2);
Console.WriteLine(result);