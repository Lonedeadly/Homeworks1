

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}

Console.Clear();
Console.WriteLine(@"Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    // a = 5; b = 7->max = 7
    // a = 2 b = 10->max = 10
    // a = -9 b = -3->max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    // 4 -> да
    // -3 -> нет
    // 7 -> нет
    
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8");

int TaskNumber = EnterTaskNumber();
if (TaskNumber == 2)
{
    Console.WriteLine(@"Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    // a = 5; b = 7->max = 7
    // a = 2 b = 10->max = 10
    // a = -9 b = -3->max = -3");

    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int max = a;
    if (b > max)
    {
        max = b;
    }
    Console.WriteLine("Наибольшее число: " + max);
}
else if (TaskNumber == 4)
{
    Console.WriteLine(@"Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22");

    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    Console.WriteLine("Наибольшее число: " + max);
}
else if (TaskNumber == 6)
{
    Console.WriteLine(@"Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    // 4 -> да
    // -3 -> нет
    // 7 -> нет");

    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }
}
else if (TaskNumber == 8)
{
    Console.WriteLine(@"Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8");

    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    int i = 1;
    while (i <= a)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
        i++;
    }
}
