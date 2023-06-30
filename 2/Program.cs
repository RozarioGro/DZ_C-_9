/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
using System;
using static System.Console;
Clear();
Write("Enter M: ");
int M = Convert.ToInt32(ReadLine());
Write("Enter N: ");
int N= Convert.ToInt32(ReadLine());
int res = Akerman(M,N);
Write($"Resulte: {res}");




int Akerman(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return Akerman(a - 1,1);
    else return Akerman(a - 1,Akerman(a,b - 1));
    
}