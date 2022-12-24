// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


const int M = 2;
const int N = 2;
const int Z = 2;
int[,,] myArray = FillArray(M, N, Z);
PrintArray(myArray);




int[,,] FillArray(int m, int n, int z)
{
    int[,,] arr = new int[m, n, z];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[j, k, i] = new Random().Next(10, 100);
            }
        }
    }
    return arr;
}


void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[j, k, i]}({j},{k},{i}) \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


