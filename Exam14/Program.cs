// Принимает на вход число и проверяет на кратность 7 и 23
int number=161;
CheckNumber(number);

void CheckNumber(int number1)
{
    int result1=number1%7;
    int result2=number1%23;
    if(result1==0 & result2==0)
        Console.WriteLine("кратно");
    else
        Console.WriteLine(result1);
}

