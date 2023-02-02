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

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();