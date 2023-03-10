/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void FillSpiralArray(int[,] matrix){
        int i = 0, j = 0;
        int value = 1;
        int n = matrix.GetLength(0);

    while(n != 0){
        int k = 0;
        do {
            matrix[i, j++] = value++;
            k++;
        } while(k < n - 1); 
        for (k = 0; k < n - 1; k++) matrix[i++, j] = value++;
        for (k = 0; k < n - 1; k++) matrix[i, j--] = value++;
        for (k = 0; k < n - 1; k++) matrix[i--, j] = value++;

        i++; j++;
        if(n < 2) n = 0; else n = n - 2;
    }
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(matrix[i,j] < 10) Console.Write($"0{matrix[i,j]} "); 
            else Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrix = new int[4,4];
FillSpiralArray(matrix);
PrintMatrix(matrix);