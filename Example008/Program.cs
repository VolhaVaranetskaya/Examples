﻿// Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3);
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 10;
int b1 = 18;
int c1 = 54;
int a2 = 21;
int b2 = 119;
int c2 = 5;
int a3 = 74;
int b3 = 158;
int c3 = 16;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);