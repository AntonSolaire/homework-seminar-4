// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double degree (int a, int b) 
{
    double res = 1;
    res = Math.Pow(a,b);
    return res;
}

Console.WriteLine("Введите А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());
double result = degree(a,b);
Console.WriteLine(result);


