
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
int[,] matrix = new int[row, column];
Console.Write("Первоночальный массив: ");
Console.WriteLine();
inputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив: ");
int k = 0;
for(int i = 0; i < row; i++)
{
    for(int j = 0; j < column; j++)
    {
        for(int l = column - 1; l > j; l--)
        {
        if(matrix[i,l] > matrix[i,l-1])
        {
            k = matrix[i,l];
            matrix[i,l] = matrix[i,l-1];
            matrix[i,l-1] = k;
        } 
    }
    Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}




// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



