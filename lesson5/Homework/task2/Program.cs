using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    

 // Обмен первой с последней строкой
 public static int[,] SwapFirstLastRows(int[,] array)
  {
        int[,] myNewArray = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == 0)
                {
                    myNewArray[i, j] = array[array.GetLength(0) - 1, j];
                }
                else if (i == array.GetLength(0) - 1)
                {
                    myNewArray[i, j] = array[0, j];
                }
                else
                {
                    myNewArray[i, j] = array[i, j];
                }
            }
        }
        return myNewArray;
   }

    public static void PrintResult(int[,] numbers)
    {
       int[,] myArray = UserInputToCompileForTest.SwapFirstLastRows(numbers);
       UserInputToCompileForTest.PrintArray(myArray);
    }
}    
//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}