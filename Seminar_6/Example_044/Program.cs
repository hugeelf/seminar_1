// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonache(int number)
{   
    int a = 0;
    int b = 1;
    int c = 0;
    Console.Write($"{c} {1} ");
    for (int i = 0; i<number; i++)
    {
        c=a+b;
        a=b;
        b=c;
        
        Console.Write($"{c} ");
    }
}
int number = 12;
Fibonache(number);