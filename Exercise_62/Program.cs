/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] RotateMatrix(int[,]matrix, int row, int column)
{
    int temp=0;
    for(int i = 0; i < row/2; i++)
    {
        for(int j = i; j < column-1-i; j++)
        { 
            temp=matrix[i,j];
            matrix[i,j]=matrix[j,column-1-i]; // 1 corner
            matrix[j,column-1-i]=matrix[row-i-1,column-1-j]; // 2 corner
            matrix[row-i-1,column-1-j]=matrix[row-1-j,i];  // 3 corner
            matrix[row-1-j,i]=temp; // 4 corner
        }
    }  
    return matrix;
}

int[,] SpiralMatrix(int row, int column)
{
    int [,] matrix = new int [row, column];
    int num=01;
    int count=0;
    int i=0, j=0;
    while(i<row/2+1)
    { 
        while(j<column)
        {
            if(matrix[i,j]==0)
            {
                matrix[i,j] = num;
                num++;
            }
            j++;
        }
        RotateMatrix(matrix, row, column);
        count++;
        j=1;
        if(count>3) 
        {
            i++;
            count=0;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            Console.Write(matrix[i,j] + "    ");
        }
        Console.WriteLine();
    }
}  


Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] matrix = SpiralMatrix(row, column);
PrintMatrix(matrix, row, column);