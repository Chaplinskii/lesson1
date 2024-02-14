// Задайте массив из вещественных чисел с ненулевой дробной частью
// void inputArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(20 * new Random().NextDouble() - 10, 2); // (-10; 10)
//         // NextDouble() - генерирует число в диапазоне (0; 1)
//         // Math.Round(число, кол-во знаков после запятой)
//         // x (0; 1)
//         // 20 * x (0; 20)
//         // 20 * x - 10 (-10; 10)
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n]; // [0.0, 0.0, 0.0, ..., 0.0]
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Задание 1.
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// void inputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(50, 151); // [50, 151]
//         }
//     }
// }
/*
1 2 3 4
5 6 7 8
9 10 11 12

*/

// void printMatrix(int[,] matrix){
// // matrix.GetLength(0) - количество строк
// // matrix.GetLength(1) - количество столбцов
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i, j]} \t");
//             // \n - переход на новую строчку
//             // \t - табуляция
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// inputMatrix(matrix);
// printMatrix(matrix);

// Решение
// void inputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10); // [1, 11]
//         }
//     }
// }
// /*
// 1 2 3 4
// 5 6 7 8
// 9 10 11 12

// */

// void printMatrix(int[,] matrix)
// {
//     // matrix.GetLength(0) - кол-во строк
//     // matrix.GetLength(1) - кол-во столбцов
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//             // \n - переход на новую строчку
//             // \t - табуляция
//         }
//         Console.WriteLine();
//     }
// }


// void replaceElements(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i += 2)
//     { // i++ <=> i = i + 1
//         for (int j = 0; j < matrix.GetLength(1); j += 2)
//         {
//             matrix[i, j] *= matrix[i, j];
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// inputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// printMatrix(matrix);
// replaceElements(matrix);
// Console.WriteLine("\nКонечный массив: ");
// printMatrix(matrix);

// Задание 2.
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// void inputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10); // [1, 11]
//         }
//     }
// }

// void printMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// int sumElements(int[,] matrix)
// {
//     int x = matrix.GetLength(0), y = matrix.GetLength(1);
//     int result = 0;
//     if (x < y)
//     {
//         for (int i = 0; i < x; i++)
//             result += matrix[i, i];
//     }
//     else
//     {
//         for (int i = 0; i < y; i++)
//             result += matrix[i, i];
//     }
//     return result;
// }


// Console.Clear();
// Console.Write("Введите размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// inputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// printMatrix(matrix);
// Console.WriteLine($"Сумма элементов главной диагонали равна {sumElements(matrix)}");

// Задание 3. Совместная работа
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

// void inputMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i, j] = new Random().Next(1, 10); // [1, 11]
//         }
//     }
// }

// void printMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// double[] searchAvg(int[,] matrix, double[] array){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         double sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             sumRow += matrix[i, j];
//         }
//         array[i] = Math.Round(sumRow / matrix.GetLength(1), 2);
//         // int / int = int
//         // int / double = double
//         // double / int = double
//     }
//     return array;
// }


// Console.Clear();
// Console.Write("Введите размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// double[] avgArray = new double[size[0]];
// inputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// printMatrix(matrix);
// Console.WriteLine($"Сред. ариф. каждой строки: [{string.Join(", ", searchAvg(matrix, avgArray))}]");


// Задание1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.
// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//         int element = 0;
//       if (ValidatePosition(array, x, y)==true){
//         element = array[x-1, y-1];

//       }
//       return element;


//     }

// // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//       if (x>array.GetLength(0)){
//         Console.WriteLine("Позиция по рядам выходит за пределы массива");
//         return false;
//       }

//       if (y>array.GetLength(1)){
//         Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//         return false;
//       }
//       return true;
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         //Напишите свое решение здесь
//       if (ValidatePosition(numbers, x, y)==true){
//       Console.WriteLine(FindElementByPosition(numbers, x, y));
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }


// Задание2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// using System;
// using System.Globalization;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         //Напишите свое решение здесь
//         int[,] matrix = SwapFirstLastRows(array);
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]} \t");

//                 // \n - переход на новую строчку
//                 // \t - табуляция
//             }
//             Console.WriteLine();
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         //Напишите свое решение здесь

//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             SwapItems(array, i);
//         }
//         return array;
//     }

//     // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         //Напишите свое решение здесь
//         // int j = array.GetLength(0) - 1;
//         // int temp = array[j, i];
//         // array[j, i] = array[0, i];
//         // array[0, i] = temp;
//         int temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;

//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь
//         PrintArray(numbers);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        //Напишите свое решение здесь
        int[] arr = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {

                sum += array[i, j];
            }

            arr[i] = sum;
            // Console.Write(arr[i]);
        }

        return arr;

    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        //Напишите свое решение здесь

        int Min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (Min > array[i])
            {
                Min = array[i];
            }
        }
        int index = Array.IndexOf(array, Min);
        return index;
    }
    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        Console.WriteLine(MinIndex(SumRows(numbers)));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив

            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}

// Быстрая сортировка
// T[] Concat<T>(params T[][] arrays){ // [1, 2, 3] [3, 4] [5, 6, 7, 8]
//     var result = new T[arrays.Sum(a => a.Length)]; // [0, 0, 0, 0, 0, 0, 0, 0]
//     // arrays = [[1, 2, 3], [3, 4], [5, 6, 7, 8]]
//     // a = [1, 2, 3] -> 3
//     int offset = 0;
//     foreach(T[] array in arrays){
//         array.CopyTo(result, offset); // [1, 2, 3, 3, 4, 5, 6, 7, 8]
//         offset += array.Length; // offset = 3 + 2 = 5
//     }
//     return result;
// }


// int[] quickSort(int[] array){
//     if (array.Length < 2){
//         return array;
//     }
//     else{
//         int pivot = array[0];
//         int count = 0;
//         foreach (int element in array){
//             if (element < pivot)
//                 count++;
//         }
//         int[] less = new int[count];
//         int j = 0;
//         for (int i = 0; i < array.Length; i++){
//             if (array[i] < pivot){
//                 less[j] = array[i];
//                 j++;
//             }
//         }
//         count = 0;
//         foreach (int element in array){
//             if (element > pivot)
//                 count++;
//         }
//         int[] greater = new int[count];
//         j = 0;
//         for (int i = 0; i < array.Length; i++){
//             if (array[i] > pivot){
//                 greater[j] = array[i];
//                 j++;
//             }
//         }
//         count = 0;
//         foreach (int element in array){
//             if (element == pivot)
//                 count++;
//         }
//         int[] pivotArray = new int[count];
//         for (int i = 0; i < count; i++){
//             pivotArray[i] = pivot;
//         }
//         int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
//         return result;
//     }
// }



// Console.Clear();
// Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array))}]");
// int[] array = {7, 4, 1, 3, 5, 2, 8, 6};
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
