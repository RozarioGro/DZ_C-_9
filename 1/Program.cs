/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
using static System.Console;
Clear();
Write("Enter M: ");
int M = Convert.ToInt32(ReadLine());
Write("Enter N: ");
int N= Convert.ToInt32(ReadLine());
WriteLine(Sum(M,N));
int Sum(int a, int b)
{
    int max;
    int min;
    if ( a > b)
    {
        max = a;
        min = b;
    }
    else
    {
        max = b;
        min = a;
    }

    if (a == b)  return b;
    
    return b + Sum(min, max -1);
}