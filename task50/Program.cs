// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его 
//индексы первого найденого числа или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void Main()
{
    Console.Clear();
    int row = UserInput("Введите количество строк");
    int col = UserInput("Введите количество столбцов");
    int minVal = UserInput("Введите минимальное значение");
    int maxVal = UserInput("Введите максимальное значение");
    int[,] array = GetArray(row, col, minVal, maxVal);
    PrintArray(array);
    int number = UserInput("Введите искомый элемент ");
    FindElem(array, number);
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
void FindElem(int[,] array, int number)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                Console.WriteLine($"индекс найденого числа ({i}, {j})");
                flag = true;
            }

        }
    }
    if (flag == false)  Console.WriteLine($"Такого числа в массиве нет");
    
}
Main();