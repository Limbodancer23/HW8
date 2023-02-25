// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int RowNumber = SetNumber("Rows: ");
int ColNumber = SetNumber("Columns: ");

int[,] matrix = GetMatrix(RowNumber, ColNumber);
PrintMatrix(matrix);
System.Console.WriteLine();
CountLowerStr(0);




void CountLowerStr(int sum)
{
    int[] arrCount = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arrCount[i] = sum;
        sum = 0;
    }
    int min = arrCount[0];
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(arrCount[i] < min)
        {
            min = arrCount[i];
            minIndex = i;
        }
    }
    System.Console.WriteLine($"The lower summ in string number: {minIndex + 1}");
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

int SetNumber(string number)
{
    System.Console.WriteLine($"Enter number of {number}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}