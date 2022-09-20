/*Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным элементов массива.*/

//Я еще работаю над ней, надеюсь успею до Вашей проверки))

int size = 5;
double[] array = FillArray(size);
PrintArray(FillArray(size));
PrintArray(FindMaxNum(array));



double[] FillArray(int size)
{
    double[] array = new double [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write($"[{string.Join (", ", array)}]"); 
    Console.WriteLine();
}

double FindMaxNum (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max);
        max = array[i];
    }
    return max;
}
