/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Сколько чисел хотите ввести? ");
int numbers = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; i < numbers; i++)
{
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb > 0) count++;
}

Console.WriteLine($"количество положительных чисел среди введенных: {count}");