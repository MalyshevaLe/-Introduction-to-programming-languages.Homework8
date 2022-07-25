//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7
//2 3 5 9
//2 4 4 8


/*int[,] ArrayRandom (int rows, int columns)
{      
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
        }
} 


void SortRowsArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = j+1; x < array.GetLength(1); x++)
            {
                if (array [i,j] > array [i,x])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,x];
                    array[i,x] = temp;                    
                }                
            }

        }  
    }
} 

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();
int[,] array = ArrayRandom (m, n);
printArray(array);
Console.WriteLine();
SortRowsArr(array);
printArray(array);*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



/*int[,] ArrayRandom (int rows, int columns)
{      
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 51);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
        }
} 

void ArrRowMinimalSum (int[,] array)
{
    int sum = int.MaxValue;
    int minRowsIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows += array[i,j];
        }
        if (sumRows < sum)
        {
            sum = sumRows;
            minRowsIndex = i;            
        }
        Console.WriteLine($"Сумма в строке № {i+1} = {sumRows};");
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов в строке: {minRowsIndex+1}");
    
}   

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] arr = ArrayRandom (rows, columns);
printArray(arr);
Console.WriteLine();
ArrRowMinimalSum(arr);*/




//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//и

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

//Их произведение будет равно следующему массиву:

//1 20 56 10
//20 81 8 6
//6 8 4 24
//10 6 24 49


/*int[,] ArrayRandom (int rows, int columns)
{      
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
        }
} 

int[,] MultiplicationMatrix (int[,] matrix1, int[,] matrix2)
{
    int[,] arrayResult = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            arrayResult[i,j] = matrix1[i,j] * matrix2[i,j];
        }
    }
    return arrayResult;
}

Console.Write("Введите количество строк первого массива: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество строк второго массива: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = ArrayRandom (rows1, columns1);
printArray(array1);
Console.WriteLine();
int[,] array2 = ArrayRandom (rows2, columns2);
printArray(array2);
Console.WriteLine();
if (rows1==rows2 && columns1==columns2)
{
    Console.WriteLine("Произведение элементов двух матриц");
    printArray(MultiplicationMatrix(array1, array2));
}
else
{
    Console.WriteLine("Невозможно найти произведение элементов двух матриц, т.к. разные размеры массивов");
}*/
    


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)


/*int[,,] fillArray3d (int dim, int row, int col)
{
    int[,,] arrResult = new int[dim,row,col];
    for (int z = 0; z < dim; z++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                arrResult[z,i,j] = new Random().Next (10,100);
            }
        }
    }
    return arrResult;
}

void PrintArray3d (int[,,] array3d)
{
    for (int z = 0; z < array3d.GetLength(0); z++)
    {
        for (int i = 0; i < array3d.GetLength(1); i++)
        {
            for (int j = 0; j < array3d.GetLength(2); j++)
            {
                Console.Write ($"{array3d[z,i,j]} ({z},{i},{j}) ");
            }
            Console.WriteLine();
        }
    }
}
Console.Write("Введите 1-ое измерение массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое измерение массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое измерение массива: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine ("Трехмерный массив:");
int[,,] array = fillArray3d(m, n, k);
PrintArray3d(array);*/


//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7


void SpiralArray(int[,] array)
{
    int number = 1;
    int i = 0;
    int j = 0;
    
    while (number <= array.GetLength(0) * array.GetLength(1))
    {
        array[i,j] = number;
        if (i <= j+1 && i+j <  array.GetLength(0)-1){
            j++;}
        else if (i < j && i+j >= array.GetLength(1)-1){
            i++;}
        else if (i >= j && i+j > array.GetLength(0)-1){
            j--;} 
        else
        {
            i--; 
        }
        number++;
    }
}
  
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
        }
}
int [,] arr = new int[4,4];
SpiralArray(arr);
printArray(arr);
