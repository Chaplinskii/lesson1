﻿// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 3;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);
// // Console.WriteLine(arr[5]);
// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// int[] arr3 = { 1, 2, 3, 4, 5 };

// задача 1
// int n = 10;
// int[] arr = new int[n];
// int i=0;
// while (i < arr.Length)
// {
//     arr[i] = i + 1;
//     Console.Write($"{arr[i]} ");
//     i=i+1;
// }

// Задача 2
// int[] arr = new int[10] { 2, -5, 4, 7, 8, 35, 1, 3, -8, 5 };
// int i = 0;
// while (i < arr.Length)
// {
//     if (arr[i] % 2 == 0)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     i=i+1;
// }

// Задача 3 (гири)
int n = 5;
int[] array = { 9, -4, 7, 3, 2 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);