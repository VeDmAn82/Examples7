﻿// int a = 5;

// int b = 10;

// int tmp = b;
// b = a;
// a = tmp;

// Console.WriteLine(a);
// Console.WriteLine(b);

// Задача55

// int[,] RotateMatrix(int[,] array)
// {
// int[,] answer = new int[10 , 10];
// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         answer[i , j] = array [j , i];
//     }
// } 
// return answer;
// }



// Задача57

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);

// Console.WriteLine();

// int[,] FindArray = FindRepeats(result);
// PrintCuontArray(FindArray);

// int[,] FindRepeats(int[,] array)
// {
//     int[,] arrayCount = new int[2, array.GetLength(0) * array.GetLength(1)];

//     int numCount = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             bool isExist = false;
//             for (int y = 0; y < arrayCount.GetLength(1); y++)
//             {
//                 if (arrayCount[0, y] == array[i, j])
//                 {
//                     arrayCount[1, y] = arrayCount[1, y] + 1;
//                     isExist = true;
//                     break;
//                 }
//             }
//             if (!isExist)
//             {
//                 arrayCount[0, numCount] = array[i, j];
//                 arrayCount[1, numCount] = 1;
//                 numCount++;
//             }
//         }
//     }
//     return arrayCount;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void PrintCuontArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {

//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             if (array[1, i] == 0)
//             {
//                 return;
//             }
//             Console.Write($"{array[j, i]} ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//         }
//     }

//     return array;
// }


// Задача59

