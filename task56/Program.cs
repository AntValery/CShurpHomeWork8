/*Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] CreateMatrix(){
    int[,] matrix = new int[4,4];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(-10, 11);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetNumberMaxSum(int[,] matrix){
    
    int[] sum = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            sum[i] += matrix[i,j];
        }
    }

    int max = 0;
    for(int i = 0; i < sum.GetLength(0); i++){
        if (sum[i] > max) max = i;
    }

    return max+1;
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"строка {GetNumberMaxSum(matrix)}");