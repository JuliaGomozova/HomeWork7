/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
        
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
int rows = GetNumber("Зададим двумерный массив, для этого введите количество строк:");
int columns = GetNumber("Количество столбцов:");

Console.WriteLine();

int[,] matrix = InitMatrix(rows, columns); 
PrintMatrix(matrix);

int indRow = GetNumber("Введите индекс строки необходимого элемента:");
int indColumn = GetNumber("Введите индекс столбца необходимого элемента:");

if (indRow < rows && indColumn < columns && indRow >= 0 && indColumn >= 0)
{
    Console.WriteLine($"Элемент с индексами [{indRow},{indColumn}] = {matrix[indRow, indColumn]}");
}
else
{
    Console.WriteLine("Элемента с такими индексами в массиве нет.");
}