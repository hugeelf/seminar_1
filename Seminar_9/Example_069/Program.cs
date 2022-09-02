// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит 
// число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int SquresOfDigits(int b, int c)
{
    if (c == 0) return 1;
    else return SquresOfDigits(b,c-1) *b;
}



int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int c = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(SquresOfDigits(b,c)); 