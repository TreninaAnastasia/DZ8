// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 4;
int colimns = 8;

int[,] array = NewArray(rows, colimns);
PrintArray(array);
Console.WriteLine();
FindSum(array);

int[,] NewArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindSum (int[,]  array)
{
    int minsum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
        sum += array[i,j];
        }
        if ( i == 0) minsum = sum;
        else if (sum < minsum) 
        {
            minsum = sum;
            index = i;
        }
     }
    Console.WriteLine($"Строка с минимальной суммой элементов: {index + 1} "); 
}