

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}


Console.Clear();
Console.WriteLine(@"Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3 7 22 2 78] -> 76");

int TaskNumber = EnterTaskNumber();

if (TaskNumber == 34)
{
    Console.WriteLine(@"Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2");
    Console.WriteLine();
    Console.Write("Введите количество чисел в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Кол-во четных чисел в массиве: " + count);
}
else if (TaskNumber == 36)
{
    Console.WriteLine(@"Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0");
    Console.WriteLine();

    Console.Write("Введите количество чисел в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int summa = 0;
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i % 2 == 1)
            summa += array[i];
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + summa);

}
else if (TaskNumber == 38)
{
    Console.WriteLine(@"Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3 7 22 2 78] -> 76");
    Console.WriteLine();

    Console.Write("Введите количество чисел в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[n];
    int i_min = 0;
    int i_max = 0;
    for (int i = 0; i < n; i++)
    {
        int num = Convert.ToInt32(new Random().NextDouble() * 100);

        array[i] = num;
        if (array[i] < array[i_min])
            i_min = i;
        if (array[i] > array[i_max])
            i_max = i;

    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Разница между максимальным и минимальным элементов массива равна " + (array[i_max] - array[i_min]));

}
