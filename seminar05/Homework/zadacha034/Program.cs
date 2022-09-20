/*Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.*/

int size = 5;
int[] array = FillArray(size);
PrintArray(array);

Console.WriteLine($"Количество чётных чисел в данном массиве: {CountEven(array)}");


int[] FillArray (int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(100, 1000);
   }
   return array;
}


void PrintArray (int[] array)
{
    Console.Write($"[{string.Join (", ", array)}]"); 
    Console.WriteLine();
}

int CountEven (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            count++;
            Console.WriteLine(array[i]);
        }
    }
    return count;    
}


