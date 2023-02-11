// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine()?? "");
int result;
result = A;
for(int i=1; i<B; i++)
{
    result *= A; 
}
Console.WriteLine(A + " ^  " + B + "  =  " + result);

