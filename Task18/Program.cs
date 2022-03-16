// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int quarterNumber = 1;

switch (quarterNumber)
{
    case 1:
    {
        Console.WriteLine("X > 0, Y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("X < 0, Y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("X < 0, Y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("X > 0, Y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Не является номером четверти");
        break;
    }
}
