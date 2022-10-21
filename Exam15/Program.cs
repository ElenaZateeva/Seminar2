// На входе число 1-7 с определением дня недели (выходной или нет)

Console.WriteLine("Введите число дня недели от 1 до 7: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A == 6 | A == 7)
    Console.WriteLine("Выходные ");
else
    Console.WriteLine("Рабочий день ");

