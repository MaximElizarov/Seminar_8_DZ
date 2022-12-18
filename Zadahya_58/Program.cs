Console.Write("Введите размер первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер второй матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int [m,n];
int[,] matrix2 = new int [a,b];
int[,] matrix3 = new int [m,b];
Random rand = new Random();
Console.WriteLine("Первая матрицы: ");
for (int i=0; i < matrix1.GetLength(0); i++)
{
   for (int j=0; j < matrix1.GetLength(1); j++)
   {
       matrix1[i,j]=rand.Next(100);
       Console.Write(matrix1[i,j]+" ");
   }
   Console.WriteLine();
}
Console.WriteLine("Вторая матрицы: ");
for (int i=0; i < matrix2.GetLength(0); i++)
{
   for (int j=0; j < matrix2.GetLength(1); j++)
   {
       matrix2[i,j]=rand.Next(100);
       Console.Write(matrix2[i,j]+" ");
   }
   Console.WriteLine();
}
Console.WriteLine("Результирующая: ");
for(int i = 0; i < m; i++){
    for(int j = 0; j < b; j++){
        for (int k = 0; k < m; k++){
            matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
        }
        Console.Write(matrix3[i,j]+" ");
    }
    Console.WriteLine();

}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
