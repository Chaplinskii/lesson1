﻿Console.Clear();
// Задача1
// int[,] CreateMatrix(int rowCount, int columsCount)
// {
//     int[,] matrix = new int[rowCount, columsCount];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             matrix[i, j] = rnd.Next(1, 11);

//         }
//     }
//     return matrix;
// }
// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write($"{matrix[i, j]} ");

//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);

// Задача2
// int[,] CreateMatrix(int rowCount, int columsCount)
// {
//     int[,] matrix = new int[rowCount, columsCount];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             matrix[i, j] = rnd.Next(1, 1000);

//         }
//     }
//     return matrix;
// }
// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write($"{matrix[i, j]} ");

//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = CreateMatrix(3, 4);
// ShowMatrix(matrix);
// foreach (int e in matrix)
// {
//     if (IsInteresting(e) == true)
//     {
//         Console.WriteLine(e);
//     }
// }
// bool IsInteresting(int value)
// {
//     int sumOfDigits = GetSumOfDigits(value);
//     if (sumOfDigits % 2 == 0)
//     {
//         return true;
//     }
//     return false;
// }
// int GetSumOfDigits(int value)
// {
//     int sum = 0;

//     while (value > 0)
//     {
//         sum = sum + value % 10;
//         value = value / 10;
//     }
//     return sum;
// }

// Задача3
// string GetLettersString(string s)
// {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if (char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }
// string str = Console.ReadLine()!;
// string result = GetLettersString(str);
// Console.WriteLine(result);

Console.WriteLine("Ввведите значение: ");
string str = Console.ReadLine();
int GetNumbersString(string str){
    string digit = "";
    int[] numbers = new int [5];
    foreach (char e in str){
        if (char.IsAsciiDigit(e)==true){
            
        }
    }
}
