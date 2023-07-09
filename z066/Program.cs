// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    if (M > N) 
    {
        return 0;
    }
    return M + SumNumbers(M + 1, N);
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
System.Console.WriteLine($"Сумма натуральных элементов равна: {SumNumbers(M, N)}");
