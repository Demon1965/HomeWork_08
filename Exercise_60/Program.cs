/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int num=15;
int list=2, row=2, column=2;
int[,,] array3d = new int[list, row , column];
for(int k=0; k<list; k++)
{
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            num=num+5+k+i+j;
            array3d[k,i,j]=num;
            Console.Write($"{array3d[k,i,j]} {(k,i,j)}" + "  ");
        }
        Console.WriteLine();
    }
}
