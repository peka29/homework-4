//   Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
// степень B.

int f(int n, int n1)
{
    int result = 1;
    for (int i = 0; i < n1; i++)
        result = result * n;

    return result;
}
Console.Clear();
Console.WriteLine("введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число {a} в степени {b} будет {f(a, b)}");