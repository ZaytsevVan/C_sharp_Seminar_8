// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for(int i = 0; i < matrixForPrint.GetLongLength(0); i++)
    {
        for(int j = 0; j < matrixForPrint.GetLongLength(1); j++)
        {
            Console.Write(matrixForPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void CompareTheSumOfRowElements(int[,] matrix)
{   
    int [] array = new int[matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];
        }
    }

    int min = array[0];

    for(int k = 1; k < array.Length; k++)
    {
        if(min > array[k]) min = array[k];
    }

    for(int k = 1; k < array.Length; k++)
    {
        if(min == array[k])
        Console.WriteLine($"Номер строки с наименьшей суммой элементов {k + 1}.");
    }

}

void Main()
{
    int m = ReadInt("Введите число строк: ");
    int n = ReadInt("Введите число столбцов: ");
    if(m == n)
    {
        Console.WriteLine("Введите прямоугольный массив, число строк не должно совпадать с количеством столбцов!");
    }
    else
    {
        int[,] matrix = FillMatrix(m, n, 0, 9);
        PrintMatrix(matrix);
        CompareTheSumOfRowElements(matrix);
    }
}

Main();