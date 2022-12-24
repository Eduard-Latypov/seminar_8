// Задача состоит в том, чтобы написать функцию, которая на вход принимает строку 
// текста и удалив все гласные буквы из текста возвращает ее
// hello => hll
// PriVet => PrVt
// FluGegEnhAyMEn => FlGgnhyMn


// string Shortcut(string input)
// {
//     string abc = "aeiou";
//     for (int i = 0; i < abc.Length; i++)
//     {
//         if (input.ToLower().Contains(abc[i].ToString()))
//         {
//             input = input.Replace(abc[i].ToString(), "");
//             input = input.Replace(abc[i].ToString().ToUpper(), "");
//         }
//     }
//     return input;
// }

// string str = "FluGegEnhAyMEn";
// System.Console.WriteLine(Shortcut(str));


// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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





