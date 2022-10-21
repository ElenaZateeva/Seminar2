// Выводит случайное 3х значное число, удалает 2ю цифру из него. Н, 456 ->46

int number=GetRandomNumer(100,1000);
int result=DeleteSecondDigit(number);
Console.WriteLine(number);
Console.WriteLine(result);

// Удаляет 2е число из цифры
int DeleteSecondDigit(int number)
{
    int lastValue=number%10;
    number=number/100;
    int result=number*10+lastValue;
    return result;
}

// Выдает рандомное число в заданном диапазоне
int GetRandomNumer(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}

