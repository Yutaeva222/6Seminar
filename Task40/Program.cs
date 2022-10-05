// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите сторону А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a+b>c && a+c>b && b+c>a)
{
    Console.WriteLine("Да, с такими сторонами треугольник существует!");
}
else
{
    Console.WriteLine("Нет, с такими сторонами треугольника не существует!");
}
