/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/


int size = 10;
int[] array = FillArray(size);
PrintArray(array);
Console.WriteLine($"Сумма нечентных элементов: {FindSumOfOdd(array)}");


int[] FillArray (int size)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write($"[{string.Join (", ", array)}]"); 
    Console.WriteLine();
}

int FindSumOfOdd (int[] array)
{
    int sum = 0;
    Console.WriteLine("Числа с нечетным индексом: ");
    for (int i = 1; i < array.Length; i += 2)
    {
        Console.Write($"{array[i]}, ");
        sum = sum + array[i];
    }
    Console.WriteLine();
return sum;
}



