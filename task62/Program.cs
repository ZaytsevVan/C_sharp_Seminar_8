// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrix()
{
    int[,] tempMatrix = new int[4, 4];
    int count = 1;
    
    for(int j = 0; j < tempMatrix.GetLength(1); j++)
    {
        tempMatrix[0, j] = count;
        count++;
    }

    for(int i = 1; i < tempMatrix.GetLength(0); i++)
    {
        tempMatrix[i, tempMatrix.GetLength(1) - 1] = count;
        count++;
    }

    for(int j = tempMatrix.GetLength(1) - 2; j > -1; j -= 1)
    {
        tempMatrix[tempMatrix.GetLength(0) - 1, j] = count;
        count++;
    }

    for(int i = tempMatrix.GetLength(0) - 2; i > 0; i -= 1)
    {
        tempMatrix[i, 0] = count;
        count++;
    }

    for(int j = 1; j < tempMatrix.GetLength(1) - 1; j++)
    {
        tempMatrix[1, j] = count;
        count++;
    }

    for(int j = tempMatrix.GetLength(1) - 2; j > 0; j -= 1)
    {
        tempMatrix[tempMatrix.GetLength(0) - 2, j] = count;
        count++;
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

void Main()
{
    int[,] matrix = FillMatrix();
    PrintMatrix(matrix);
}

Main();