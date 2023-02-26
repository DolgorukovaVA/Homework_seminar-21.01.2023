// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Random rnd = new Random();             
int[] array = new int[8];              
int sum = 0;                         
for (int i = 0; i < array.Length; i++) 
{
    array[i] = rnd.Next(0, 99);        
    if (i % 2 != 0)                    
    {
        sum = sum + array[i];        
    }
}
var result = string.Join(", ", array);
Console.WriteLine(" ");           
Console.WriteLine($"[{result}]");
Console.WriteLine($"Сумма чисел на нечетных: {sum}");
