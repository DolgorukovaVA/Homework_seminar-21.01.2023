// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число:   ");
int N = Convert.ToInt32(Console.ReadLine()?? "");
int GetNumbersComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetNumbersComposition(N)}");
