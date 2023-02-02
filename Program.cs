// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//int rows = ReadInt("Введите количество строк: ");
//int colums = ReadInt("Введите количество столбцов: ");
//double[,] numbers = new double[rows, colums];
//FillArray2D(numbers);
//PrintArray2D(numbers);

// Заполнение массива рандомными вещественными числами
//void FillArray2D(double[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
    //{
      //  for (int j = 0; j < array.GetLength(1); j++)
        //{
          //  array[i, j] = new Random().Next(-99, 99) / 10.0;
        //}
    //}
//}

//  Функция вывода массива в терминал
//void PrintArray2D(double[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
   // {
     //   for (int j = 0; j < array.GetLength(1); j++)
       // {
         //   Console.Write(array[i, j] + " ");
        //}
        //Console.WriteLine();
    //}
    //Console.WriteLine();
//}

// Функция ввода 
//int ReadInt(string message)
//{
  //  Console.Write(message);
    //return Convert.ToInt32(Console.ReadLine());
//}


//Задача 50. Напишите программу, которая на вход принимает значение элемента 
//в двумерном массиве, и возвращает позицию этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int GetNumberFromPositionInArray(int[,] someIntArray, int elementPosition)
{
    int position = elementPosition;

    if (elementPosition > 0 && elementPosition <= someIntArray.Length)
    {
        int rowLength = someIntArray.GetLength(1);

        int i = 0, j = 0;
        // строка (row ряд) в котором находится нужный элемент
        while (elementPosition > rowLength)
        {
            elementPosition -= rowLength;
            i++;
        }
        // индекс элемента в конкретном ряду (колонка)
        j = rowLength - ( rowLength - elementPosition ) - 1;

        return someIntArray[i, j];
    }
    // нужно вернуть число!
    // если ни чего не получилось,
    // то возвращаем число,
    // которого точно не может быть в массиве.
    // например "-1" для массива положительных чисел.

    return -1;
}


int[,] myIntArray = Create2DimArray(hight:3, length: 5, min: 0, max:10);
Print2DArray(myIntArray);


int position = new Random().Next(0, myIntArray.Length);
int number = GetNumberFromPositionInArray(myIntArray, position);

String str50 = number >= 0 ?
    $"На {position} позиции в массиве находится число = {number}" :
    $"позиция {position} за пределами массива";

Console.WriteLine(str50);
