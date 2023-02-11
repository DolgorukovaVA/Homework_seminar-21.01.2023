//Показать кубы чисел, заканчивающиеся на четную цифру

int N = new Random().Next(1, 10);
Console.WriteLine($"N = {N}");

int number = 1;
Console.WriteLine("Кубы чисел, заканчивающиеся на четную цифру:");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) Console.Write(cube + " ");
    number++;
}
Console.WriteLine();
