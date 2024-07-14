﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
//Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int m = ReadInt("Введите число M: ");
    int n = ReadInt("Введите число N: ");
    PrintNumber(m, n);
    System.Console.WriteLine();
}

void PrintNumber(int m,int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    System.Console.Write(n + " ");

}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();