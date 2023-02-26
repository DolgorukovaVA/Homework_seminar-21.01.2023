// Найти сумму чисел одномерного массива, стоящих на нечетной позиции
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()??"");

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 50);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, равна {sum} ");
    Console.WriteLine();
}

PrintArray(FillArray(size));
