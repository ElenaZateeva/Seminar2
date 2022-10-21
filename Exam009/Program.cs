// Вывод случайного числа [10,99] и вывод на печать наибольшего. Н., 78-> 8.

int randomNumber = GetRandomNumer(10, 100);  // от 10 до 99
Console.Write($"Рандомное число - {randomNumber}");
Console.WriteLine();
int maxValue = FindMaxValue(randomNumber);
Console.WriteLine(maxValue);

int FindMaxValue(int number)
{        //151
    int max = number % 10; //1
    number = number / 10;  //15 
    while (number > 0)     //15>0
    {
        int lastNumber = number % 10;  //5
        if (lastNumber > max)        //5>1
        {
            max = lastNumber;           //5
        }
        number = number / 10;           //1
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




