// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplicationResults(int[,] matrixOne, int[,] matrixTwo, int m)
{
    int[,] matrixMultiplication = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

    int[] multi = new int[m];

    for(int i = 0; i < matrixMultiplication.GetLength(0); i++)
    {
        for(int j = 0; j < matrixMultiplication.GetLength(1); j++)
        {
            for(int r = 0; r < m; r++)
            {
                multi[r] = matrixOne[i, r] * matrixTwo [r, j];
            }

            for(int s = 0; s < multi.Length; s++)
            {
                matrixMultiplication[i, j] += multi[s];
            }
        }
    }
    
    return matrixMultiplication;
}

void Main()
{
    int l = ReadInt("Введите число строк первой матрицы: ");
    int m = ReadInt("Введите число столбцов первой матрицы и строк второй матрицы: ");
    int n = ReadInt("Введите число столбцов второй матрицы: ");
    int[,] matrixFirst = FillMatrix(l, m, 0, 10);
    int[,] matrixSecond = FillMatrix(m, n, 0, 10);
    PrintMatrix(matrixFirst);
    Console.WriteLine();
    PrintMatrix(matrixSecond);
    Console.WriteLine();
    Console.WriteLine("Результыты умножения первой матрицы на вторую: ");
    int[,] matrixMultiplicationResalt = MatrixMultiplicationResults(matrixFirst, matrixSecond, m);
    PrintMatrix(matrixMultiplicationResalt);
}



Main();