/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] CreateMatrix(){
    int[,] matrix = new int[2,2];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(1, 5);
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

int[,] FillMultMatrix(int[,] a, int[,] b){          // a - матрица 1, b - матрица 2
    int[,] mult = new int[a.GetLength(0),a.GetLength(1)];

    for(int i = 0; i < a.GetLength(0); i++){
        for(int j = 0; j < a.GetLength(1); j++){
            int sum = 0;
            for(int k = 0; k < a.GetLength(1); k++){
                sum += a[i,k] * b[k,j];
            }
            mult[i,j] = sum;
        }
    }
    return mult;
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
Console.WriteLine();

int[,] matrix1 = CreateMatrix();
PrintMatrix(matrix1);
Console.WriteLine();

int[,] mult = FillMultMatrix(matrix, matrix1);
PrintMatrix(mult);