// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// void inputArray(int[] array)
// { // передача происходит по ссылке
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1, 1000]
// }

// bool isPrime(int x)
// {
//     for (int i = 2; i <= x / 2; i++)
//     {
//         if (x % i == 0)
//             return false;
//     }
//     return true;
// }

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// foreach (int element in array)
// {  // ТАКИМ ОБРАЗОМ НЕЛЬЗЯ ИЗМЕНИТЬ ЭЛЕМЕНТЫ МАССИВЫ!!!
//     if (isPrime(element) == true)
//         Console.Write($"{element} ");
//  } 


// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 
//  void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1, 1000]
// }

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0;
// foreach (int element in array){
//     if (element % 10 == 1 && element % 7 == 0)
//         count++;
// }
// Console.WriteLine(count);

// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 10); // [0, 9]
// }

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 8){
//     Console.Write("Вы ошиблись!\nВведите кол-во чисел: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// // 55944115 - 8 цифр
// // 5*10^7 + 5*10^6 + 9*10^5... + 5*10^0
// int resultNumber = 0, count = array.Length - 1;
// for (int i = 0; i < array.Length; i++){
//     resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count));
//     // resultNumber = 0 + 4 * 10^4 = 40000
//     // resultNumber = 40000 + 9 * 10^3 = 49000
//     // resultNumber = 49000 + 9 * 10^2 = 49900
//     // resultNumber = 49000 + 0 * 10^1 = 49900
//     // resultNumber = 49000 + 1 * 10^0 = 49901
//     count--;
// }
// Console.WriteLine(resultNumber);


void inputArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [0, 9]
}


int createNumber(int[] array){
    int resultNumber = 0, count = array.Length - 1;
    for (int i = 0; i < array.Length; i++){
        resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count));
        // resultNumber = 0 + 4 * 10^4 = 40000
        // resultNumber = 40000 + 9 * 10^3 = 49000
        // resultNumber = 49000 + 9 * 10^2 = 49900
        // resultNumber = 49000 + 0 * 10^1 = 49900
        // resultNumber = 49000 + 1 * 10^0 = 49901
        count--;
    }
    return resultNumber;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 8){
    Console.Write("Вы ошиблись!\nВведите кол-во чисел: ");
    n = int.Parse(Console.ReadLine()!);
}
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// 55944115 - 8 цифр
// 5*10^7 + 5*10^6 + 9*10^5... + 5*10^0
Console.WriteLine(createNumber(array));