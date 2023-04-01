// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа: ");
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int pozitiv = 0;
for (int m = 0; m < size.Length; m++)
{
    if (size[m] > 0)
    {
        pozitiv++;
    }
}
Console.WriteLine($"{pozitiv}");
