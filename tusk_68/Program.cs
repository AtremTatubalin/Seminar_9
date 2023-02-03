/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Clear();

int GetUserNumber(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int FunctionAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n != 0) && (m == 0))
    {
        return FunctionAckerman(n - 1, 1);
    }
    else return FunctionAckerman(n - 1, FunctionAckerman(n, m - 1));
}

int m = GetUserNumber("Введите m: ");
int n = GetUserNumber("Введите n: ");

Console.WriteLine(FunctionAckerman(n, m));