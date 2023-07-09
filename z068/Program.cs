// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> Ackerman(m,n) = 9
// m = 3, n = 2 -> Ackerman(m,n) = 29


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
   
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    
    else return Ackerman(m - 1, Ackerman(m, n - 1));
    
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
System.Console.WriteLine($"Значение функции Аккермана: {Ackerman(m, n)}");




