/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
int[,] generate2DArray(int countRow, int countCol, int deviation)
{
    int[,] array = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            array[i, j] = new Random().Next(1, deviation + 1);
        }
    }
    return array;
}

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] fromMoreToLess(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int num = 0; num < array.GetLength(1) - 1; num++)
            {
                if (array[i, num] < array[i, num + 1])
                {
                    int buf = array[i, num + 1];
                    array[i, num + 1] = array[i, num];
                    array[i, num] = buf;
                }
            }
        }
    }
    return array;
}
Console.WriteLine("Задан массив: ");
int[,] generatedArray = generate2DArray(5,5,10);
print2dArray(generatedArray);
Console.WriteLine();
Console.WriteLine("Mассив по убыванию: ");
int[,] newArray = fromMoreToLess(generatedArray);
print2dArray(newArray);
