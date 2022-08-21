//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите  число:  ");
        string numbers = Console.ReadLine();
        //char[]arr = numbers.ToString().ToCharArray();
        int i;
        int summ = 0;
        int n = numbers.Length;
        for (i = 0; i < n ; i++)
        {
            summ = summ + Convert.ToInt32(numbers[i].ToString());
        }
        Console.Write("сумма чисел=    ");
        Console.Write(summ);
    }
}
