// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите первое число");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.WriteLine("Введите второе число");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.WriteLine($"Вы ввели числа {paramInt1} и {paramInt2}");

    if (paramInt1 == paramInt2)
     Console.Write($"{paramInt1} = {paramInt2}");
else
{
            if (paramInt1 > paramInt2)
            {
            Console.Write($"Число {paramInt1} > Числа {paramInt2}");
            }
        else
        {
        Console.Write($"Число {paramInt1} < Числа {paramInt2}");
        }
}