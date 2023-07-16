// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] FillArray(int x, int y, int z, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[x, y, z];
    Random rand = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for(int k = 0; k < tempMatrix.GetLength(2); k++)
            {
                tempMatrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,,] matrixForPrint)
{
    for(int i = 0; i < matrixForPrint.GetLongLength(0); i++)
    {
        for(int j = 0; j < matrixForPrint.GetLongLength(1); j++)
        {
            for(int k = 0; k < matrixForPrint.GetLength(2); k++)
            {
                Console.Write(matrixForPrint[i, j, k]);
                Console.Write($"({i}, {j}, {k})     ");
            }
        }
        Console.WriteLine();
    }
}

void Main()
{
    int x = ReadInt("Введите число ячеек массива по оси х: ");
    int y = ReadInt("Введите число ячеек массива по оси y: ");
    int z = ReadInt("Введите число ячеек массива по оси z: ");
    int[,,] array = FillArray(x, y, z, 0, 10);
    PrintMatrix(array);
}

Main();