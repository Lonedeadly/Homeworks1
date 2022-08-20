

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}


Console.Clear();
Console.WriteLine(@"Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да

Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    // 3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125");
int TaskNumber = EnterTaskNumber();
if (TaskNumber == 19)
{
    Console.WriteLine(@"Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да");
    Console.Write("Введите пятизначное число: ");
    string num = Console.ReadLine();

    bool CheckPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (num[i] != num[length - i - 1])
                return false;
        }
        return true;
    }

    if (CheckPalindrome(num) == true)
        Console.Write("Да");
    else
        Console.Write("Нет");
}
else if (TaskNumber == 21)
{
    Console.WriteLine(@"Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));

    Console.WriteLine("Расстояние между точками равно " + distance);
}
else if (TaskNumber == 23)
{
    Console.WriteLine(@"Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    // 3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " ");
    }
}
