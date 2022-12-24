// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07





int M = new Random().Next(5, 10);
int N = new Random().Next(5, 10); ;
int[,] SpiralArray = FillArraySpiral(M, N);
PrintArray(SpiralArray);



int[,] FillArraySpiral(int rows, int col)
{
    int[,] myArray = new int[rows, col];
    int index = 1;
    int i = 0;
    int j = -1;
    int right = 1;
    int down = 0;
    while (index <= rows * col)
    {
        if (((0 <= (i + down)) && ((i + down) < rows)) && ((0 <= (j + right)) && ((j + right) < col)) && (myArray[(i + down), (j + right)] == 0))
        {
            j += right;
            i += down;
            myArray[i, j] = index;
            index++;
        }
        else if (right == 1)
        {
            right = 0;
            down = 1;
        }
        else if (down == 1)
        {
            down = 0;
            right = -1;
        }
        else if (right == -1)       // полдня Карл, я потратил на нее пол мать его дня))
        {
            right = 0;
            down = -1;
        }
        else if (down == -1)
        {
            down = 0;
            right = 1;
        }
    }
    return myArray;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


