

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}


Console.Clear();
Console.WriteLine(@"Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243
    // 2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]");

int TaskNumber = EnterTaskNumber();

if (TaskNumber == 25)
{
    Console.WriteLine(@"Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243
    // 2, 4 -> 16");
    Console.Write("Введите число А: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    Console.Write("Введите число B: ");
    int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    Console.WriteLine();

    Console.WriteLine("Число " + A + " в степени " + B + " равен " + Math.Pow(A, B));
}
else if (TaskNumber == 27)
{
    Console.WriteLine(@"Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12");
    Console.Write("Введите число: ");
    string Number = Console.ReadLine();
    int Summa = 0;
    int length = Number.Length;
    for (int i = 0; i < length; i++)
    {
        int temp = int.Parse(Convert.ToString(Number[i]));
        Summa = Summa + temp;
    }

    Console.WriteLine();
    Console.Write("Сумма цифр числа " + Number + " равна " + Summa);
}
else if (TaskNumber == 29)
{
    Console.WriteLine(@"Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]");
    Console.WriteLine();
    int[] ArrayNumbers = new int[8];
    for (int i = 0; i < ArrayNumbers.Length; i++)
    {
        ArrayNumbers[i] = new Random().Next(0, 100);
    }

    Console.WriteLine("[" + String.Join(", ", ArrayNumbers) + "]");

}
