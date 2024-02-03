// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denumenator = c + d;
//     double result = numenator / denumenator;
//     return result;
// }

// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);

void PrintSquares(int limit)
{
    int i =1;
    while (i<=limit)
    {
Console.Write($"{i*i} ");
i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);