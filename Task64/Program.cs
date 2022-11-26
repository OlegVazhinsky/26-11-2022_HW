/*

Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

int GetNumber(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void ShowNumber(int number)
{ 
    if (number != 0) {
        Console.WriteLine(number);
        number -= 1;
        ShowNumber(number);
    }
}

int number = GetNumber("Введите число - ");
ShowNumber(number);