// Вывод случайного числа [10,99] и вывод на печать наибольшего. Н., 78-> 8.
 
int randomNumber = GetRandomNumer(100, 1000);  // от 10 до 99
Console.Write($"Рандомное число - {randomNumber}");
int maxValue = FindMaxValue(151);
Console.WriteLine(maxValue);

int FindMaxValue(int numberA);
{
    int max = numberA % 10;
    numberA = numberA / 10;

    while (numberA > 0)
    {
        int lastNumber = numberA % 10;
        if (lastNumber > max)
        {
            max = lastNumber;
        }
        numberA = numberA / 10;
    }
    return max;
}


// Выдает рандомное число в заданном диапазоне
int GetRandomNumer(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}




