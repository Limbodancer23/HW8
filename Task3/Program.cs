// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int Rows1 = 2;
int columns1 = 3;
int Rows2 = 3;
int columns2 = 2;

int[,] matrix1 = GetMatrix(Rows1, columns1);
int[,] matrix2 = GetMatrix(Rows2, columns2);
int[,] ResultMatrix = ResMatrix(matrix1, matrix2);

PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();
PrintMatrix(ResultMatrix);

int[,] ResMatrix(int[,] matr1, int[,] matr2)
{
    int res = 0;
    int[,] resultMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                res = res + (matr1[i, k] * matr2[k, j]);
            }
            resultMatr[i, j] = res;
            res = 0;
        }
    }
    return resultMatr;
}


int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}