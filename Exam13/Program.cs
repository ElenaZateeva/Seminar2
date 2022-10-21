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
            int leng = number.length;

            if (leng < 3)
                string result = "3й цифры нет";
            else
            {
                string strNumber = Convert.ToString(number);
                // int[] array=new int[3];
                //for (int i = 0; i < array.Length; i++)
                //{
                string result = strNumber.ToCharArray[3];
                // }
            }


          //  return result;
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