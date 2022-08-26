//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a1 = num % 100;
int a2 = a1 / 10;
Console.WriteLine($"Вторая цифра числа {num} - {a2}.");