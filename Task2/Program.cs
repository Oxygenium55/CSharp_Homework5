/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] MakeArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(-100, 100);
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

int OddNumbers(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        summ = summ + array[i];
    }
    return summ;
}

Console.Write("Введите длину массива: ");
int number = int.Parse(Console.ReadLine());
int[] arr = MakeArray(number);
PrintArray(arr);
int result = OddNumbers(arr);
Console.WriteLine($"Сумма нечетных чисел в массиве: {result}");
