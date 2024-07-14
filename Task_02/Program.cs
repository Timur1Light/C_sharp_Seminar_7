﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//Пример:
// m = 2, n = 3 -> A(m,n) = 29 <-Этот пример из презентации, но он не верный, я смотрел по таблице, поэтому привел примеры из таблицы!

// m = 0, n = 0 -> A(m,n) = 1
// m = 1, n = 0 -> A(m,n) = 2
// m = 1, n = 1 -> A(m,n) = 3
// m = 2, n = 1 -> A(m,n) = 5
// m = 1, n = 2 -> A(m,n) = 4
// m = 2, n = 2 -> A(m,n) = 7 итд.


void Main()
{
    int m = ReadInt("Введите число m: ");
    int n = ReadInt("Введите число n: ");
    
    System.Console.WriteLine(FunAkerman(m, n));
}


int FunAkerman(int m,int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunAkerman(m - 1, 1);
    }
    else
    {
        return (FunAkerman(m - 1, FunAkerman(m, n - 1)));
    }
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


Main();