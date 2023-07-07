// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int rows = Prompt("Введите количество строк");
int colimns = Prompt("Введите количество столбцов");

int[,] array = NewArray(rows, colimns);
PrintArray(array);
Console.WriteLine();
int[] newArray = GetRowArray(array);
SortArray(newArray);



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
int[] GetRowArray(int[,] array)
{
    int[] result = new int [array.Length];
    int index = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[index] = array [i,j];
            index ++;
        }
    }
    return result;
}
void SortArray(int [] array)
{
    int inarray = 0;
    for (int j =  0; j < array.Length; j++)
    {
        for (int i = j + 1; i < array.Length; i++)
        {       
            if (array[i] >= array[j])
            {
                inarray = array[i];
                array[i] = array [j];
                array[j] = inarray;
        
            }
        }
        Console.Write($"{inarray} ");
    }
    Console.WriteLine();
}
