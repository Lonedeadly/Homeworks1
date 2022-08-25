

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}


Console.Clear();
Console.WriteLine(@"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

int TaskNumber = EnterTaskNumber();

if (TaskNumber == 66)
{

    int progressia(int m, int n)
    {
        if (n == m)
            return m;

        return progressia(m - 1, n) + m;
    }

    Console.WriteLine(@"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    //M = 1; N = 15 -> 120
    //M = 4; N = 8. -> 30");
    Console.WriteLine();

    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());

    if (m < n)
    {
        int temp = m;
        m = n;
        n = temp;
    }

    Console.WriteLine("Сумма натуральных числе: " + progressia(m, n));

}
else if (TaskNumber == 68)
{
    Console.WriteLine(@"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 3, n = 2 -> A(m,n) = 29");
    Console.WriteLine();

    int akkermana(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return akkermana(m - 1, 1);
        return akkermana(m - 1, akkermana(m, n - 1));
    }

    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(akkermana(m, n));
}
