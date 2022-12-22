/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

//Инициализация двумерного массива случайными целыми числами        
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

//Вывод матрицы на консоль
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

//печать одномерного массива вечественных чисел
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine();
}

//Ищет среднее арифметическое значенее в каждом столбце двумерного массива. Возвращает массив найденных средних
double[] FindAvarageInColumns(int[,] matrix)
{
    double[] avarage= new double[matrix.GetLength(1)];
    double sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                sum += matrix[i,j]; 
            avarage[j] = sum/matrix.GetLength(0);                 
        }
    return avarage;
}

int rows = GetNumber("Зададим двумерный массив, для этого введите количество строк:");
int columns = GetNumber("Количество столбцов:");
Console.WriteLine();

int[,] matrix = InitMatrix(rows, columns); 
PrintMatrix(matrix);
Console.WriteLine();

double[] arrayOfAverages = FindAvarageInColumns(matrix);

Console.Write($"Средняя арифмитическая в каждом столбце: ");
PrintArray(arrayOfAverages);