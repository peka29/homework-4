// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int f(int n)
{
    int summ = 0;
    while (n > 0)
    {
        summ = summ + n % 10;
        n = n / 10;
    }
    return summ;
}
Console.Clear();
Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр в числе будет {f(a)}");