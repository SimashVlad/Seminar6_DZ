// // Задача 43. Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Здравствуйте. это консольное прилажение поможет найти Вам точки прересечения прямых");

double[] crossPoint = new double[2];
double[,] Values = new double[2, 2];

void InputValues()  // принимает значения
{
    for (int i = 0; i < Values.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значение {i + 1}-го уравнения (y = k * x + b):");
        for (int j = 0; j < Values.GetLength(1); j++)
        {
            if (j == 0) Console.WriteLine($"Введите значение k: ");
            else Console.WriteLine($"Введите значение b: ");
            Values[i, j] = int.Parse(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] Values)
{
    crossPoint[0] = (Values[1, 1] - Values[0, 1]) / (Values[0, 0] - Values[1, 0]);
    crossPoint[1] = crossPoint[0] * Values[0, 0] + Values[0, 1];
    return crossPoint;
}

void OutputAnswer(double[,] Values)
{
    if (Values[0, 0] == Values[1, 0] && Values[0, 1] == Values[1, 1])
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if (Values[0, 0] == Values[1, 0] && Values[0, 1] != Values[1, 1])
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {
        Decision(Values);
        Console.WriteLine($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputValues();
OutputAnswer(Values);