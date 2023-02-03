/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();

int GetUserN(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void RowNumbers(int N)
{
    if(N == 1)
    {
        Console.WriteLine(N);
        return;
    }
    Console.Write(N + ", ");
    RowNumbers(N - 1);
}

int N = GetUserN("Введите границу ряда: ");
RowNumbers(N);