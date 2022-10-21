// На входе 3х значное число, результат 2я цифра данного числа

int number=GetRandomNumer(100,1000);
int result=PrintSecondDigit(number);
Console.WriteLine(number);
Console.WriteLine(result);

// Удаляет 2е число из цифры
int PrintSecondDigit(int number)
{
    number=number/10;
    int result=number%10;
    return result;
}

// Выдает рандомное число в заданном диапазоне
int GetRandomNumer(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}
