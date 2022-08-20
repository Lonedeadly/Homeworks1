

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
Console.WriteLine(@"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Задача 62. Заполните спирально массив 4 на 4.");

int TaskNumber = EnterTaskNumber();

if (TaskNumber == 54)
{
    Console.WriteLine(@"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
В итоге получается вот такой массив:
    // 1 2 4 7
    // 2 3 5 9
    // 2 4 4 8");
    Console.WriteLine();
    int n = EnterNumbersRows();
    int m = EnterNumbersCols();

    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }

    ShowNArray(array);
    int temp;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int s = 0; s < m - 1; s++)
            {
                if (array[i, s] > array[i, s + 1])
                {
                    temp = array[i, s];
                    array[i, s] = array[i, s + 1];
                    array[i, s + 1] = temp;
                }
            }
        }
    }
    ShowNArray(array);
}
else if (TaskNumber == 56)
{
    Console.WriteLine(@"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка");
    Console.WriteLine();

    int n = EnterNumbersRows();
    int m = EnterNumbersCols();

    int[,] array = new int[n, m];
    int SummaStroki;
    int SummaMaxStroki = 0;
    int MaxIndex = 0;
    for (int i = 0; i < n; i++)
    {
        SummaStroki = 0;
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            SummaStroki += array[i, j];
        }
        if (i == 0) SummaMaxStroki = SummaStroki;
        if (SummaMaxStroki >= SummaStroki)
        {
            SummaMaxStroki = SummaStroki;
            MaxIndex = i;
        }
    }
    ShowNArray(array);

    Console.WriteLine("Наименьшая сумма в строке под номером: " + (MaxIndex + 1));
}
else if (TaskNumber == 58)
{
    Console.WriteLine(@"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
и
    // 1 5 8 5
    // 4 9 4 2
    // 7 2 2 6
    // 2 3 4 7
Их произведение будет равно следующему массиву:
    // 1 20 56 10
    // 20 81 8 6
    // 56 8 4 24
    // 10 6 24 49");
    Console.WriteLine();

    int n = EnterNumbersRows();
    int m = EnterNumbersCols();

    int[,] array1 = new int[n, m];
    int[,] array2 = new int[n, m];
    int[,] arrayResult = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array1[i, j] = new Random().Next(1, 10);
            array2[i, j] = new Random().Next(1, 10);
            arrayResult[i, j] = array1[i, j] * array2[i, j];
        }
    }

    ShowNArray(array1);
    ShowNArray(array2);
    ShowNArray(arrayResult);
}
else if (TaskNumber == 60)
{
    Console.WriteLine(@"Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
    // 12(0,0,0) 22(0,0,1)
    // 45(1,0,0) 53(1,0,1)");
    Console.WriteLine();

    int[,,] array = new int[3, 3, 3];
    int[] numbers = new int[3 * 3 * 3];
    int randomNumber;
    int indexNumbers = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                randomNumber = new Random().Next(10, 100);
                while (Array.IndexOf(numbers, randomNumber) >= 0)
                {
                    randomNumber = new Random().Next(10, 100);
                }
                array[i, j, k] = randomNumber;
                numbers[indexNumbers] = randomNumber;
                indexNumbers++;
                Console.Write(randomNumber + $"({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }

}
else if (TaskNumber == 62)
{
    Console.WriteLine(@"Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
    // 1 2 3 4
    // 12 13 14 5
    // 11 16 15 6
    // 10 9 8 7");
    Console.WriteLine();

    int n = EnterNumbersRows();
    int m = EnterNumbersRows();

    int[,] array = new int[n, m];

    int i = 0;
    int j = 0;
    int count = 1;

    int stepMaxI = n - 1;
    int stepMaxJ = m;

    int stepI = 1;
    int stepJ = 1;

    int vectorI = 1;
    int vectorJ = 1;

    bool NowI = false;
    while (count <= array.Length)
    {
        array[i, j] = count;
        if (NowI)
        {
            if (stepI == stepMaxI)
            {
                stepMaxI = stepMaxI - 1;
                NowI = false;
                stepI = 1;
                vectorI *= -1;
                if (vectorJ > 0)
                {
                    j++;
                }
                else
                {
                    j--;
                }
            }
            else
            if (vectorI > 0)
            {
                i++;
                stepI++;
            }
            else
            {
                i--;
                stepI++;
            }
        }
        else
        {
            if (stepJ == stepMaxJ)
            {
                stepMaxJ = stepMaxJ - 1;
                NowI = true;
                stepJ = 1;
                vectorJ *= -1;
                if (vectorI > 0)
                {
                    i++;
                }
                else
                {
                    i--;
                }
            }
            else
            if (vectorJ > 0)
            {
                j++;
                stepJ++;
            }
            else
            {
                j--;
                stepJ++;
            }
        }
        count++;
    }

    ShowNArray(array);

}
