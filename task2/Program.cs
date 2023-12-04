//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();
void inputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrixWeHave)
{
    for(int i = 0; i < matrixWeHave.GetLength(0); i++)
    {
        for(int j = 0; j < matrixWeHave.GetLength(1); j++)
        {
            Console.Write($"{matrixWeHave[i, j]}\t");
        }
        Console.WriteLine();
    }
    
}
void reverseMatrix(int[,] matrixWeHave)
{
       for(int j = 0; j < matrixWeHave.GetLength(1); j++)
        {
            int temp = matrixWeHave[0, j];
            matrixWeHave[0, j] = matrixWeHave[matrixWeHave.GetLength(0) - 1, j];
            matrixWeHave[matrixWeHave.GetLength(0) - 1, j] = temp;
        }
}

Console.WriteLine("Введите колличество строк массива: ");
int size1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов массива: ");
int size2 = int.Parse(Console.ReadLine()!);
int [,] matrixMadeUp = new int [size1, size2];
inputMatrix(matrixMadeUp);
Console.WriteLine("Исходная матрица: ");
PrintMatrix(matrixMadeUp);
reverseMatrix(matrixMadeUp);
Console.WriteLine("Конечная матрица: ");
PrintMatrix(matrixMadeUp);
