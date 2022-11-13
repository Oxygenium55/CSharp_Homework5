/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] MakeArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(0, 100);
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

int Diff(int[]array)
{
    int min = array[0];
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];
        else if(array[i] > max)
        max = array[i];
    }
    int different = max - min;
    return different;
}

Console.Write("Введите длину массива: ");
int number = int.Parse(Console.ReadLine());
int[] arr = MakeArray(number);
PrintArray(arr);
int result = Diff(arr);
Console.WriteLine($"Разница между максимальным элементом массива и минимальным: {result}");