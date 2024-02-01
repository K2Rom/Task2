//  Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.





void FillArray(int i, int[] arrayInt)
{
    Random rnd = new();
    if (i < arrayInt.Length)
    {
        arrayInt[i] = rnd.Next(100);
        FillArray(i + 1, arrayInt);
    }
    return;
}

void DirectPrintingArray(int index, int[] arrayInt)
{
    if (index < arrayInt.Length)
    {
        Console.Write($"{arrayInt[index]} ");
        DirectPrintingArray(index + 1, arrayInt);
    }
}

void ReversePrintingArray(int index, int[] arrayInt)
{
    if (index >= 0)
    {
        Console.Write($"{arrayInt[index]} ");
        ReversePrintingArray(index - 1, arrayInt);

    }
}


Console.Clear();
Console.Write("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());


int[] arrayInt = new int[size];
int i = 0;
FillArray(i, arrayInt); // заполнение массива случайными числами

Console.Write("Прямая последовательность чисел    ");
DirectPrintingArray(0, arrayInt);
Console.WriteLine();

Console.Write("Инверсная последовательность чисел ");
ReversePrintingArray(arrayInt.Length - 1, arrayInt);
Console.WriteLine();


