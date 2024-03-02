using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
      int [] myArray = new int[array.GetLength(0)];
      int sum = 0;
      for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
          sum = sum + array[i,j];
        }
        myArray[i] = sum;
        sum = 0;
      }
      return myArray;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
       int min = array[0];
       int placeMin = 0;
       for(int i = 0; i < array.Length; i++){
         if(min > array[i]){
           placeMin = i;
         }
       }
      return placeMin;
    }
    public static void PrintResult(int[,] numbers)
    {   
       int[] newArray = UserInputToCompileForTest.SumRows(numbers);
       int minNum = UserInputToCompileForTest.MinIndex(newArray);
       Console.Write(minNum);
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
            
            numbers = new int[,] {
                {1, 0, 0},
                {1, 1, 0},
                {0, 40, 0},
                {0, 0,  0}      
        };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
