// Console.Clear();
// Console.Write("Введите имя: ");
// string name=Console.ReadLine()!;
// // Console.WriteLine($"Привет, {name}!");
// Console.WriteLine(name[0]);
// Console.WriteLine(name.Length);

using System.Runtime.Serialization.Formatters;

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// // char->string->int
// int result = 0;
// for (int i = 0; i < number.Length; i++)
// {
//     result += int.Parse(number[i].ToString());
// }
// Console.WriteLine(result);

//Задача1
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n]; // [0,0,0, ... ,0]
// // double [] array = new double[n]; // [0.0,0.0,...,0.0]
// // string [] array = new string [n]; // ["","", ... , ""]
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); //[-10, 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите искомый элемент: ");
// int element = int.Parse(Console.ReadLine()!);
// string result = "Нет";
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == element)
//         result = "Да";
// }
// Console.WriteLine(result);

//Задача2
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

// Console.Clear();

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


//Задача3
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); //[1, 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int[] resultArray = new int[array.Length / 2];
// for (int i = 0; i < array.Length / 2; i++)
// {
//     resultArray[i] = array[i] * array[array.Length - 1 - i];
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");


//Задача4
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 

// Console.Clear();
// int n = 456;
// int[] array = new int[3];
// array[0] = n % 10;
// array[1] = (n % 100) / 10;
// array[2] = n / 100;
// Console.WriteLine($"[{string.Join(" ", array)}]");

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        //Введите сюда свое решение
        minRange=10;
        maxRange=90;
        
    }

    public static void PrintResult(int[] array)
    {

        //Введите сюда свое решение
        for (int i = 0; i < array.Length; i++)
        {
            int numbers;
            array[i] = numbers;
        }
        UserInputToCompileForTest.CountItemsRange(numbers);
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;


        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        }
        else
        {
            // Если аргументов на входе нет
            array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}