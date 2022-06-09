// Напишите программу, которая на вход принимает число (N) и выдает все четные числа между ними от 1
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
int i = 2;
while (i <= numberInt)
{
    Console.Write($"{i} ");
    i += 2;
}
