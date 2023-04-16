// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void Main()
{
    Console.Clear();
    int row = UserInput("Введите количество строк");
    int col = UserInput("Введите количество столбцов");
    int minVal = UserInput("Введите минимальное значение");
    int maxVal = UserInput("Введите максимальное значение");
    double[,] array = GetArray(row, col, minVal, maxVal);
    PrintArray(array);
}

int UserInput(string text)
{
    Console.Write($"{text}: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = double.Round(new Random().Next(min, max +1) + new Random().NextDouble(), 2); //Запись для округления количество символов после запятой !
        }                                                                                              // double.Round(все как обычно next.в скобках 2) .
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");  //   -> \t это для отделения столбцов.
        }
        Console.WriteLine();
    }
}
Main();