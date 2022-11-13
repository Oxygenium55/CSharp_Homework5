/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int[] MakeArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        amount = amount + 1;
    }
    return amount;
}

Console.Write("Введите длину массива: ");
int number = int.Parse(Console.ReadLine());
int[] arr = MakeArray(number);
PrintArray(arr);
int result = EvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в массиве: {result}");
