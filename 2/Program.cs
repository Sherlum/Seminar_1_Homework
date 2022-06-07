// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int max = 0;
Console.WriteLine("Введите первое число");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);

Console.WriteLine("Введите второе число");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);

Console.WriteLine("Введите третье число");
string paramString3 = Console.ReadLine();
int paramInt3 = int.Parse(paramString3);

if (paramInt1 > paramInt2)
{
    max = (paramInt1);
}
else
{
    max = (paramInt2);
}
if (max < paramInt3)
{
    max = (paramInt3);
}

Console.WriteLine($"{paramInt1}, {paramInt2}, {paramInt3} -> {max}");