

int EnterTaskNumber()
{
    Console.WriteLine();
    Console.Write("Проверить задачу под номером: ");
    int TaskNumber = Convert.ToInt32(Console.ReadLine()); //Номер задачи
    Console.Clear();

    return TaskNumber;
}


Console.Clear();
Console.WriteLine(@"Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 4

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");

int TaskNumber = EnterTaskNumber();

if (TaskNumber == 41)
{
    Console.WriteLine(@"Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    //0, 7, 8, -2, -2 -> 2
    //1, -7, 567, 89, 223-> 4");
    Console.WriteLine();

    Console.Write("Кол-во чисел: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int[] array = new int[m];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Кол-во чисел > 0: " + count);
}
else if (TaskNumber == 43)
{
    Console.WriteLine(@"Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
    Console.WriteLine();

    Console.Write("Введите b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x};{y})");

}
