// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()?? "");
int i = number;
int result = 0;
while( i != 0)
{
    i = i/10;
    result++;
}
Console.WriteLine("Количество цифр в числе  " + number + "  =  " + result);

