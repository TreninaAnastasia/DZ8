//  Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int rowsFirst = Prompt("Введите количество строк 1 матрицы");
int colimnsFirst = Prompt("Введите количество столбцов 1 матрицы");

int rowsSecond = Prompt("Введите количество строк 2 матрицы");
int colimnsSecond = Prompt("Введите количество столбцов 2 матрицы");

int[,] firstArray = NewArray(rowsFirst, colimnsFirst);
int[,] secondArray = NewArray(rowsSecond, colimnsSecond);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
FindProduct(firstArray, secondArray);



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

void FindProduct (int [,] a, int [,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) {Console.WriteLine("Матрицы нельзя перемножить");}
    int [,] product = new int [a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int e = 0; e < b.GetLength(0); e ++ )
            {
                product[i,j] += a[i,e] * b[e,j];
            }
        }
    }
    Console.WriteLine(product);
}

