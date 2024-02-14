// Задание 1. Совместная работа
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 

// Console.Clear();
// Console.Write("Кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// char[] chars = new char[n];
// for (int i = 0; i < chars.Length; i++){
//     Console.Write("Введите элемент массива: ");
//     chars[i] = char.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
// Console.WriteLine(string.Join("", chars));
// string result = "";
// foreach (char element in chars){
//     result += element;
// }
// Console.WriteLine(result);

// Задание 2. Работа в сессионных залах
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// char[] chars = new char[str.Length];
// for (int i = 0; i < str.Length; i++){
//     chars[i] = str[i];
// }
// Console.WriteLine($"Результат: [{string.Join(", ", chars)}]");

// Задание 3. Совместная работа
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

// bool checkVowel(char ch, char[] vowels){
//     foreach (char element in vowels){
//         if (element == ch)
//             return true;
//     }
//     return false;
// }


// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// char[] vowels = {'a', 'e', 'o', 'i', 'y', 'u'};
// int count = 0;
// for (int i = 0; i < str.Length; i++){
//     if (checkVowel(str[i], vowels))
//         count++;
// }
// Console.WriteLine(count);

