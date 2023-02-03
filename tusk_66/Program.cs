/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

int GetUserStartEnd(string massege)
{
    Console.Write(massege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Sum(int start, int end)
{
    if(start == end + 1)
    {
        return 0;
    }
    return start + Sum(start + 1, end);

}

int start = GetUserStartEnd("Введите начало промежутка: ");
int end = GetUserStartEnd("Введите конец промежутка: ");

int s = Sum(start, end);
Console.Write(s);
