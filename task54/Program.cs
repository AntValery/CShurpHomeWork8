/*Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateMatrix(){
    int[,] matrix = new int[4,4];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(0, 10);
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

void SortMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            int currentIndex = j;
            for(int k = 0; k < matrix.GetLength(1); k++){
                //int max;
                if (matrix[i,currentIndex] < matrix[i,k] && currentIndex < k){
                    int max = matrix[i,k];
                    matrix[i,k] = matrix[i,currentIndex];
                    matrix[i,currentIndex] = max;
                }

            }
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    } 
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);


