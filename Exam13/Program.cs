// На входе любое число, результат 3я цифра данного числа, либо СМС =его нет"

internal class Program
{
    private static void Main(string[] args)
    {
        int number = GetRandomNumer(10, 10000);
        Console.WriteLine(number);
        PrintThirdDigit(number);

        // Выбирает 3ю цифру из числа
        void PrintThirdDigit(int number)
        {
            string strNumber = Convert.ToString(number);
            int strLen = strNumber.Length;

            if (strLen < 3)
                Console.WriteLine("3й цифры нет");
            else
            {
               strNumber=strNumber.Substring(2, 1);
               Console.WriteLine(strNumber);
            }
                
        }

        // Выдает рандомное число в заданном диапазоне
        int GetRandomNumer(int minValue, int maxValue)
        {
            Random random = new Random();
            int randomNumber = random.Next(minValue, maxValue);
            return randomNumber;
        }
    }
}