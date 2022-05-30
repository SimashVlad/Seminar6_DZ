// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



Console.Clear();
Console.Write($"Введите сколько чисел Вам необходимо набрать: ");
int m = int.Parse(Console.ReadLine());
int[] arrayNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        arrayNumbers[i] = int.Parse(Console.ReadLine());
    }
}


int SumNumber(int[] arrayNum)
{
    int count = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (arrayNum[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Вы ввели чисел больше 0: ({SumNumber(arrayNumbers)})");