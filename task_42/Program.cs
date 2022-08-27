/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.WriteLine("Введите число: ");
int number  = Convert.ToInt32(Console.ReadLine());
Console.Write($"Десятичное число {number} равно двоичному ");
// переменные для работе в цикле
string biNumber = string.Empty;
int temp = 0;
int quot = 0;
// цикл перевода десятичного числа в двоичную через строку
while (number >= 1)
{
    quot = number / 2;
    temp = number - quot * 2;
    biNumber += temp;
    number = quot;
}

//преобразование строки в массив с его "разворотом"
char[] biNumb = biNumber.ToCharArray();
int size = biNumb.Length;

for (int i = 0; i < size / 2; i++)
{
    (biNumb[i], biNumb[size - i - 1]) = (biNumb[size - i - 1], biNumb[i]);
}
//преобразование в число
biNumber = new string(biNumb);
int newNumber = Convert.ToInt32(biNumber);

Console.WriteLine($"{newNumber}");