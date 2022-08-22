/*

Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон



*/
void IsATriangle(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (b + c))
    {
        Console.WriteLine("Это треугольник");
    }
    else
    {
        Console.WriteLine("Не треугольиник");
    }
}
Console.WriteLine("Введите длину 1 стороны");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите длину 2 стороны");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите длину 3 стороны");
int c = Math.Abs(Convert.ToInt32(Console.ReadLine()));

IsATriangle(a, b, c);
