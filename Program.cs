
int[] scores = { 60, 80, 40, 80, 90 };

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

Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));

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

Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));

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

System.Console.WriteLine(FindMax(scores));


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

Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));


