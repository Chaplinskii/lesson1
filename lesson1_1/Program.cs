// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет


// System.Console.WriteLine("Введите первое целое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе целое число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 * num2 == num1)
// {
//     System.Console.WriteLine("да");
// }
// else
//     System.Console.WriteLine("нет");

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int i= -num;
// while (i < num)
// {
//     Console.Write (i +", ");
//     i = i+1;
// }
// System.Console.WriteLine(i);

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// System.Console.WriteLine("Введите трехзначное  число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     num = num *(-1);
// }
// int i2 = num % 10;
// while (num > 10)
// {
//     num = num / 10;
// }
// System.Console.WriteLine(num + i2);

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if (firstNumber > secondNumber)
//         {
//             System.Console.WriteLine("первое число больше");
//         }
//         if (firstNumber < secondNumber)
//         {
//             System.Console.WriteLine("второе число больше");
//         }
//         if (firstNumber == secondNumber)
//         {
//             System.Console.WriteLine("числа равны");
//         }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) 
//     {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = -6;
//             secondNumber = -4;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// using System;
// using System.ComponentModel.DataAnnotations;

// public class Answer {

//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
//     int numMax=a;
//     if (numMax < b)
//     {

//         numMax=b;
//     }
//     if (numMax < c)
//     {

//         numMax=c;
//     }
//     return numMax;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = -8;
//            b = -9;
//            c = -7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }
// using System;
// using Microsoft.VisualBasic;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//     float i= number % 2;
//     if (i ==0)
//     {
//         System.Console.WriteLine("четное");
//     }
//     else 
//     {
//         System.Console.WriteLine("нечетное");
//     }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = -6;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

using System;

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже
        for (int i = 1; i <= number; i++)
    if (i % 2 == 0)
        Console.Write(i +" ");
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}