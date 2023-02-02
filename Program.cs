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

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }
