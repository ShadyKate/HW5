Console.Clear();
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void inputMatrix(int[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,]matrixWeHave)
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

void findElementOnPosition(int [,] matrixWeHave, int pos0, int pos1)
{
    for(int i = 0; i < matrixWeHave.GetLength(0); i++)
    {
        for(int j = 0; j < matrixWeHave.GetLength(1); j++)
        {
            if(pos0 == i && pos1 == j)
            {
                Console.WriteLine($"Искомый элемент матрицы: {matrixWeHave[i, j]}");
            }
            
        }
            if(pos0 > matrixWeHave.GetLength(0) || pos1 > matrixWeHave.GetLength(1))
            {
                Console.WriteLine("Введенного значения не существует");
                break; //помню, что это дурной тон, но не дошло, как правильнее использовать здесь метод флажка
            }
    }
}


Console.WriteLine("Введите размерность массива (два числа без запятых):");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray(); 
int [,] matrixMadeUp = new int [size[0], size[1]];
inputMatrix(matrixMadeUp);
Console.WriteLine("Полученный массив");
PrintMatrix(matrixMadeUp);
Console.WriteLine("Введите номер строки искомого элемента: ");
int position0 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца искомого элемента: ");
int position1 = int.Parse(Console.ReadLine()!);
findElementOnPosition(matrixMadeUp, position0, position1);
