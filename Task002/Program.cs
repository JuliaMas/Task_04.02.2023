//Написать программу копирования массива
int [] arr = new int[10];
void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr [index] = new Random().Next(100,999);
        index++;
    }
}
void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
void CopyArr(int[] arr)
{
    int[] arr2 = (int[])arr.Clone();
    foreach(int item in arr2)
    {
        Console.Write(item + " ");
    }
}


FillArray(arr);
PrintArray(arr);
Console.WriteLine();
CopyArr(arr);



