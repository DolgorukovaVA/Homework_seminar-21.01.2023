//Показать кубы чисел, заканчивающихся на четную цифру

int N = new Random().Next(1, 10);
Console.WriteLine($"N = {N}");

int number = 1;
Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру:");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) System.Console.Write(cube + " ");
    number++;
}
Console.WriteLine();
