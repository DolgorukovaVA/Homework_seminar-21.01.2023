// Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine()??"");
int size = 10;
int min = 1;
int max = 50;
string Result = "отсутствует";

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

bool FindNumber(int[] array, int Number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true;
    }
    return false;
}

void PrinArray(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(size, min, max);
PrinArray(array);
if (FindNumber(array, Number)) Result = "присутствует";
Console.WriteLine("  ");
Console.WriteLine($"Число {Number} {Result} в массиве");
Console.WriteLine();

