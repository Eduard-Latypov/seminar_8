// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 


// const int M = 5;
// const int N = 4;
// int[,] myArray = FillArray(M, N);
// PrintArray(myArray);



// int[,] FillArray(int m, int n)
// {
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return arr;
// }


// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

// }


// int[,] new_arr = new int[N, M];
// for (int i = 0; i < new_arr.GetLength(0); i++)
// {
//     for (int j = 0; j < new_arr.GetLength(1); j++)
//     {
//         new_arr[i, j] = myArray[j, i];
//     }
// }
// System.Console.WriteLine();
// PrintArray(new_arr);




// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.




const int M = 5;
const int N = 4;
int[,] myArray = FillArray(M, N);
PrintArray(myArray);



int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


int[] arr = new int[10];
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        arr[myArray[i, j]] += 1;
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != 0)
    {
        System.Console.WriteLine($"Элемент {i} встречается {arr[i]} раз");
    }
}




// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.



// const int M = 3;
// const int N = 3;
// int[,] myArray = FillArray(M, N);
// PrintArray(myArray);



// int[,] FillArray(int m, int n)
// {
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return arr;
// }


// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// int min = myArray[0, 0];
// int index = 0;
// int jindex = 0;


// int[,] new_arr = new int[M - 1, N - 1];
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         if (myArray[i, j] < min)
//         {
//             min = myArray[i, j];
//             index = i;
//             jindex = j;
//         }
//     }
// }


// int num_i = 0;
// int num_j = 0;
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     if (i == index)
//         continue;
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         if (j == jindex)
//             continue;
//         new_arr[num_i, num_j] = myArray[i, j];
//         num_j++;
//     }
//     num_j = 0;
//     num_i++;
// }

// PrintArray(new_arr);

