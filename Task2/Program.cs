//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);

if (number.Length > 2)
{
    Console.WriteLine($"Третья цифра в числе {num} - {number[2]}. ");
}
else
{ 
    Console.WriteLine($"В числе {num} меньше трех цифр. ");
}
