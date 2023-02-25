// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Rows = 2;
int columns = 2;
int Verge = 2;

int[, ,] Arr = GetMatrix(Rows, columns, Verge);

PrintMatrix(Arr);

int[,,] GetMatrix(int rows, int col, int ver)
{
    int[,,] Array = new int[rows, col, ver];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Array[i, j, z] = new Random().Next(0, 100);
            }
        }
    }
    return Array;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                System.Console.Write($"{matrix[i, j, z]}({i},{j},{z}) ");
            }
            System.Console.WriteLine();
        }
    }
}