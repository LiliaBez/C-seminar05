/*Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным элементов массива.*/

//функции FindMaxNum и FindMinNum, наверное, можно сделать в одной, но
//на семинаре говорили, что лучше, если одна функция выводит один результат..

int size = 5;
double[] array = FillArray(size);
PrintArray(array);
Console.WriteLine($"Максимальный элемент массива: {FindMaxNum(array)}");
Console.WriteLine($"Минимальный элемент массива: {FindMinNum(array)}");
Console.WriteLine($"Разница между ними равна: {FindMaxNum(array) - FindMinNum(array)}");



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
        if (array[i] > max)
        {
        max = array[i];
        }
    }
    return max;
}

double FindMinNum (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
        min = array[i];
        }
    }
    return min;
}