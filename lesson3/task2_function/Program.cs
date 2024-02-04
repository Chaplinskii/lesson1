// Задача1
// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denumenator = c + d;
//     double result = numenator / denumenator;
//     return result;
// }

// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);

// Задача2
// void PrintSquares(int limit)
// {
//     int i =1;
//     while (i<=limit)
//     {
// Console.Write($"{i*i} ");
// i++;
//     }
// }

// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);

// Задача3
// void ZeroEventElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }
// void PrintArray(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }
// int [] array={1,2,3,4,5};
// ZeroEventElements(array);
// PrintArray(array);



// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//         //Введите сюда свое решение
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] < maxRange && numbers[i] > minRange)
//             {
//                 int count = count + 1;
//             }
//         }
//         return count;
//     }

//     public static void PrintResult(int[] array)
//     {

//         //Введите сюда свое решение
//         int result = CountItemsRange(array, 10, 90);
//         Console.Write(result);
//     }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//         int count=0;
//       for (int i=0; i<numbers.Length; i++){
//         if (numbers[i]%2==0){
//             count++;
//         }
//       }
//       return count;
//     }
    
//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//       int result = CountEvenItems(array);
//         Console.Write(result);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
      double min =numbers[0];
      for (int i=0; i<numbers.Length; i++){
        if (min > numbers[i]){
          min = numbers[i];
        }
      }
      return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        //Напишите свое решение здесь
      double max= numbers[0];
      for (int i=0; i<numbers.Length; i++){
        if (max < numbers[i]){
          max = numbers[i];
        }
      }
      return max;
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        //Напишите свое решение здесь
      double result = FindMax(array) - FindMin(array);
        Console.Write(result);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}