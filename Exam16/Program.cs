// На входе 2 числа, проверяем: является ли одно квадратом 2-го

Console.WriteLine("Ведите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquare(a, b);
if (result)
    Console.WriteLine("ДА ");
else
    Console.WriteLine("НЕТ ");

// Является ли квардатом одно число от другого
bool CheckSquare(int firstNumber, int secondNumber)
{
    int square1 = firstNumber * firstNumber;
    int square2 = secondNumber * secondNumber;
    return square1 == secondNumber | square2 == firstNumber;
}