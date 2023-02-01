//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine($" -> {GetSumOddPlace(arr)}");

int GetSumOddPlace(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i %2 == 0)
        {
            result += arr[i];
        }
    }
    return result;
}


int [] GetRandomArray(int length)
{
    int[] result = new int [length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random(). Next (-100, 100);
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