/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/
int GetNumber(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int GetSum(int fromM, int toN, int sum)
{ 
    if (fromM <= toN) {
        sum += fromM;
        fromM += 1;
        return GetSum(fromM, toN, sum);
    } else return sum;
}

int M = GetNumber("Введите число M = ");
int N = GetNumber("Введите число N = ");
Console.WriteLine($"Сумма элементов равна {GetSum(M, N, 0)}");
