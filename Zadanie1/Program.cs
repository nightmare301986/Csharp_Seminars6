/*Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] Prompt(string message)
{
    System.Console.Write($"{message}  >  ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int[] arr = Prompt("Введите элементы (через пробел): ");

int count =0;
int CheckAboveZero(int count){
 count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
return count;
}

Console.WriteLine($"Количество чисел больше 0: {CheckAboveZero(count)}");