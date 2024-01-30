// Задание 1. Совместная работа
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// using System.Diagnostics.Contracts;

// Console.Clear();
// Console.Write("Введите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n); // модуль числа
// while (n < 100 || n > 999)
// {
//     Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 100;
// int n3 = n % 10;
// // 523 : 10 = 52 (ост. 3)
// // 5 * 100 + 2 * 10 + 3 * 1 = 523
// Console.WriteLine(n1 * 10 + n3);
// Console.WriteLine($"{n1}{n3}");

// Console.Clear();
// Console.Write("Введите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n); // модуль числа
// while (n < 100 || n > 999)
// {
//     Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 100;
// int n2 = (n/10)%10;
// int n3 = n % 10;
// int result = 1;
// for (int i =0; i<n3;i++)
//     result *=n2;
// Console.WriteLine($"{n2}^{n3}={result}");

// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n % m == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine($"no, {n % m}");

//     Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n);
// if (n < 100)
//     Console.WriteLine("Третьей цифры нет");
// else{
//     int x = n % 1000;
//     // 45291 : 1000 = 45 (ост. 291)
//     Console.WriteLine(x / 100);
// }