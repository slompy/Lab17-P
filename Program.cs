
using System.Runtime.InteropServices;

int[] scores = new int[7];
scores = Console.ReadLine()!;

int SumArray(int[] numbers)
{
    Console.Write("Сумма чисел: ");
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}


int CountAtLeast(int[] numbers, int limit)
{
    Console.Write("Подсчёт элементов по условию: ");
    int count = 0;

    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }

    return count;
}



int FindMax(int[] numbers)
{
    Console.Write("Самое большое число: ");
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    return max;
}




int FindMin(int[] numbers)
{
    Console.Write("Самое малое число: ");
    int min = numbers[0];

    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
}



int FindIndex(int[] numbers, int target)
{
    Console.Write("Индекс найденного числа: ");
    int index = -1;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }

    return index;
}



