// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А");
int Xa = Convert.ToInt32(Console.ReadLine());
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
int Xb = Convert.ToInt32(Console.ReadLine());
int Yb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками: {result}");
