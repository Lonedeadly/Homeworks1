

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}

Console.Clear();
Console.WriteLine(@"Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    // 456 -> 5
    // 782 -> 8
    // 918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    // 645 -> 5
    // 78 -> третьей цифры нет
    // 32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    // 6 -> да
    // 7 -> да
    // 1 -> нет
    
Задача 1129: Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов, после чего дробная часть копеек отбрасывается.
Требуется определить: через сколько лет вклад составит не менее Y рублей.
    //100 10 200 -> 8
    //13 20 60 -> 9
    
Задача 1128: В первый день спортсмен пробежал X километров. В каждый последующий день он увеличивал пробег на 15% от предыдущего дня. 
По данному числу Y требуется определить номер дня, в который пробег спортсмена составил не менее Y километров.
    //10 20 -> 6
    //1 1000 -> 51");

int TaskNumber = EnterTaskNumber();
if (TaskNumber == 10)
{
    Console.WriteLine(@"Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    // 456 -> 5
    // 782 -> 8
    // 918 -> 1");
    Console.Write("Введите трехзначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a / 100 <= 0 || a / 100 >= 10)
    {
        Console.Write("Введите трехзначное число: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Вторая цифра числа: " + Convert.ToString((a / 10) % 10));
}
else if (TaskNumber == 13)
{
    Console.WriteLine(@"Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    // 645 -> 5
    // 78 -> третьей цифры нет
    // 32679 -> 6");
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a < 0) a = a * -1;
    if (a <= 99)
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
    else
    {
        int res = a;
        int count = 0;
        while (res / 10 > 0)
        {
            res = res / 10;
            count++;
        }
        count++;
        Console.WriteLine("Кол-во цифр в числе: " + count);
        int inc = 1;
        while (count > 3)
        {
            inc = inc * 10;
            count--;
        }
        Console.WriteLine("Третья цифра числа: " + Convert.ToString((a / inc) % 10));
    }
}
else if (TaskNumber == 15)
{
    Console.WriteLine(@"Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    // 6 -> да
    // 7 -> да
    // 1 -> нет");
    Console.Write("Введите цифру дня недели: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a < 1 || a > 7) Console.WriteLine("Ты по-моему перепутал @ПашаТехник");
    else if (a == 6 || a == 7) Console.Write("Выходной");
    else Console.Write("Рабочий");
}
else if (TaskNumber == 1129)
{
    Console.WriteLine(@"Задача 1129: Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов, после чего дробная часть копеек отбрасывается.
Требуется определить: через сколько лет вклад составит не менее Y рублей.
    //100 10 200 -> 8
    //13 20 60 -> 9");
    Console.Write("Сумма вклада: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ежегодный процент: ");
    int p = Convert.ToInt32(Console.ReadLine());
    Console.Write("Сколько нужно накопить? ");
    double y = Convert.ToInt32(Console.ReadLine());

    int years = 0;
    double temp = x;
    while (temp <= y)
    {
        temp = temp + (temp * p) / 100;
        years++;
        Console.WriteLine("Год: " + years + " сумма: " + temp);
    }
    Console.WriteLine("Требуется лет " + years);
}
else if (TaskNumber == 1128)
{
    Console.WriteLine(@"Задача 1128: В первый день спортсмен пробежал X километров. В каждый последующий день он увеличивал пробег на 15% от предыдущего дня. 
По данному числу Y требуется определить номер дня, в который пробег спортсмена составил не менее Y километров.
    //10 20 -> 6
    //1 1000 -> 51");
    Console.Write("В первый день спортсмен пробежал (км): ");
    int x = Convert.ToInt32(Console.ReadLine());
    int p = 15;
    Console.Write("Сколько этот дурачок должен пробежать (км), чтобы узнать о существовании пива? ");
    int y = Convert.ToInt32(Console.ReadLine());

    int day = 1;
    double temp = x;
    while (temp <= y)
    {
        temp = temp + (temp * p) / 100;
        day++;
        Console.WriteLine("День: " + day + " км: " + temp);
    }
    Console.WriteLine("Требуется дней " + day);
}
