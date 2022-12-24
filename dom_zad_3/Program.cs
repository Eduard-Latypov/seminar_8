// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


const int M = 3;
const int N = 3;
int[,] myArray = FillArray(M, N);
int[,] new_myArray = FillArray(M, N);
PrintArray(myArray);
PrintArray(new_myArray);
PrintArray(MultiplyArrays(myArray, new_myArray));






int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(2, 4);
        }
    }
    return arr;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


int[,] MultiplyArrays(int[,] first_arr, int[,] second_arr)
{
    int[,] new_arr = new int[first_arr.GetLength(1), second_arr.GetLength(0)];
    for (int i = 0; i < first_arr.GetLength(0); i++)
    {
        for (int j = 0; j < second_arr.GetLength(1); j++)
        {
            for (int k = 0; k < second_arr.GetLength(0); k++)
            {
                new_arr[i, j] += first_arr[i, k] * second_arr[k, j];
            }
        }
    }
    return new_arr;
}