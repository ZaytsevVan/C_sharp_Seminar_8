// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void ArrangeTheArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {   
        int count = 0;
        int indexJ = 0;
        int buffer = 0;
        while(count < matrix.GetLength(1))
        {
            int max = matrix[i, count];
            
                for(int j = count; j < matrix.GetLength(1); j++)
                    {   
                        if(max < matrix[i, j]) 
                        max = matrix[i, j];
                    }
                
        
                for(int j = count; j < matrix.GetLength(1); j++)
                    {
                        if(matrix[i, j] == max) 
                        indexJ = j; 
                    }

            buffer = matrix[i, count];
            matrix[i, count] = max;
            matrix[i, indexJ] = buffer;
            count++;
        }
    }
}

void Main()
{
    int m = ReadInt("Введите число строк: ");
    int n = ReadInt("Введите число столбцов: ");
    int[,] matrix = FillMatrix(m, n, 0, 9);
    PrintMatrix(matrix);
    ArrangeTheArray(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
}

Main();