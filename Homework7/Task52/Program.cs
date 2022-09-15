﻿/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Enter a number of row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of column: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[row,column];

double result = 0;
double AverageCol = 0;

FillArray(matrix);


void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 20); // [0;19]
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}


    Console.Write("The average of columns is: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result = result + matrix[i,j];
        }
    AverageCol = result / column;
    Console.Write($"{AverageCol:f2} ");
    result = 0;
    }
    




