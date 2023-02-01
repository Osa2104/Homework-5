//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76


int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine($" -> {GetDiffMinMax(arr)}");

int GetDiffMinMax(int[] array)
{
    int result = 0;
    int _Max = arr[0], _Min = arr[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (arr[i] > _Max)
        _Max = arr[i];

        if (arr[i] < _Min)
        _Min = arr[i];
    }
    result = _Max - _Min;
    return result;
}

int [] GetRandomArray(int length)
{
    int[] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random(). Next (0, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach(int item in arr)
    {
        System.Console.Write(item + " ");
    }
}