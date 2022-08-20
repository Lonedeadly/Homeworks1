

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}

int EnterNumbersRows()
{
    int rows = 0;
    Console.Write("Введите кол-во строк: ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    return rows;
}

int EnterNumbersCols()
{
    int col = 0;
    Console.Write("Введите кол-во колонок: ");
    col = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    return col;
}

void ShowNArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine(@"Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
    //m = 3, n = 4.
    //0,5 7 -2 -0,2
    //1 -3,3 8 -9,9
    //8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    //1 4 7 2
    //5 9 2 3
    //8 4 2 4
    //(1,7) -> такого числа в массиве нет
    
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");

int TaskNumber = EnterTaskNumber();

if (TaskNumber == 47)
{
    Console.WriteLine(@"Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
    //m = 3, n = 4.
    //0,5 7 -2 -0,2
    //1 -3,3 8 -9,9
    //8 7,8 -7,1 9");
    Console.WriteLine();

    int n = EnterNumbersRows();
    int m = EnterNumbersCols();

    double[,] array = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10 * new Random().Next(-10, 11), 2);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
else if (TaskNumber == 50)
{
    Console.WriteLine(@"Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    //1 4 7 2
    //5 9 2 3
    //8 4 2 4
    //(1,7) -> такого числа в массиве нет");
    Console.WriteLine();

    int n = EnterNumbersRows();
    int m = EnterNumbersCols();

    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер колонки: ");
    int col = Convert.ToInt32(Console.ReadLine());

    if (row > m || col > n)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine("Искомое значение: " + array[row - 1, col - 1]);
    }
}
else if (TaskNumber == 52)
{
    Console.WriteLine(@"Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");
    Console.WriteLine();

    int m = EnterNumbersRows();
    int n = EnterNumbersCols();

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Среднее арифметическое число элементов в каждой колонке");

    double result;
    int count;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;
        count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
            count++;
        }
        Console.Write(Math.Round(result / count, 2) + "\t");
    }
}
