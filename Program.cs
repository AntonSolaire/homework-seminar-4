// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double degree (int a, int b) 
// {
//     double res = 1;
//     res = Math.Pow(a,b);
//     return res;
// }

// Console.WriteLine("Введите А:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите B:");
// int b = Convert.ToInt32(Console.ReadLine());
// double result = degree(a,b);
// Console.WriteLine(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int Sum (int num) 
// {
//     int result = 0;
//     int diff = 0;
//     while (num>0)
//     {
//         diff = num % 10;
//         result += diff;
//         num = num / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Sum(a);
// Console.WriteLine(result);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] CreateRandomArray ()
{
    int [] myArray = new int [8];
    for (int i=0; i<myArray.Length; i++)
    {
        myArray[i] = new Random().Next(0, 99);
    }
    return myArray;
}

void showArray (int [] array)
{
    Console.Write("Полученный массив ->: [");
    int i=0;
    for (i = 0; i<(array.Length-1); i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write(array[i]);
    Console.WriteLine("]");
}

int[] newArray = CreateRandomArray ();
showArray(newArray);

