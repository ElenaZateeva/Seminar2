//Создание массива, заполнение рандомными числами и вывод на печать
// Поиск заданного числа FIND среди чисел массива

int[] array = new int[10];  // массив из 10 элементов
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);


//Заполнение массива случайными числами
void FillArray(int[] collection)
{
    int lengh = collection.Length;
    int index = 0;
    while (index < lengh)
    {
        collection[index] = new Random().Next(1, 10);  //диапазон от 1 до 10
        index++;
    }
}

//Вывод на печать массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
 }

//нахождение в массиве конкретного числа FIND
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
