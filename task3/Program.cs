//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int [] FindSumOfRowElements(int[,]matrixWeHave)
{
    int [] sumArray = new int [matrixWeHave.GetLength(0)];
    for(int i = 0; i < matrixWeHave.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrixWeHave.GetLength(1); j++)
        {
            sum += matrixWeHave[i, j];

        }
        sumArray[i] = sum;
    }
    return sumArray;
}
void FindMinInArray(int [] arrayWeHave)
{   
    int i = 0;
    int min = arrayWeHave[i];
    int indexOfMin = i;
    for(i = 0; i < arrayWeHave.Length; i++)
    {
    if(min > arrayWeHave[i])
    {
        min = arrayWeHave[i];
        indexOfMin = i;
    }
    }
    Console.WriteLine(indexOfMin);
}

Console.WriteLine("Введите колличество строк массива: ");//не важно какой будет размер, ведь квадрат это частный случай прямоугольника
int size1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов массива: ");
int size2 = int.Parse(Console.ReadLine()!);
int [,] matrixMadeUp = new int [size1, size2];
inputMatrix(matrixMadeUp);
Console.WriteLine("Исходная матрица: ");
PrintMatrix(matrixMadeUp);
Console.WriteLine($"Массив из суммы элементов строк: [{string.Join(", ", FindSumOfRowElements(matrixMadeUp))}]");
Console.WriteLine("Номер строки с наименьшей суммой элементов: ");
FindMinInArray(FindSumOfRowElements(matrixMadeUp));