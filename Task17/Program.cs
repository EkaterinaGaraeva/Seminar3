// Задача 17. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите X и Y");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть");
}

else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть");
}

else if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть");
}

else if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}

else
{
    Console.WriteLine("Ноль");
}