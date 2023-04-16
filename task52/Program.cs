// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
//                                              1 4 7 2
//                                              5 9 2 3
//                                              8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
    Console.Clear();
    int row = UserInput("Введите количество строк");
    int col = UserInput("Введите количество столбцов");
    int minVal = UserInput("Введите минимальное значение");
    int maxVal = UserInput("Введите максимальное значение");
    int[,] array = GetArray(row, col, minVal, maxVal);
    PrintArray(array);
    FindSumNum(array);
}

int UserInput(string text)
{
    Console.Write($"{text}: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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
//                                              1 4 7 2
//                                              5 9 2 3
//                                              8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindSumNum(int[,] array)
{

    double[] average = new double[array.GetLength(1)] ;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average[j]+=array[i,j];
        }
        average[j]= double.Round(average[j] / array.GetLength(0), 1);
    }
    Console.WriteLine();
    Console.WriteLine(String.Join ("\t", average));
}
Main();