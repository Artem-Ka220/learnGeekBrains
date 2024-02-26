// // Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] СreateArray()
{
    int [] array2 = new int[size];
    return array2;
}

int[] result= СreateArray();

CompletionArray(result);
PrintArray(result);

Console.WriteLine(GetSimpleNumber(result));

void CompletionArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(2,15);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
    System.Console.WriteLine();
}

int GetSimpleNumber(int[] array)
{
    int count=0;

    for (int i = 0; i < array.Length; i++)  // [1 3 4 19 3]
    {
        bool isFind=true;

        for (int j = 2; j < array[i]; j++)  
        {
            if(array[i] % j==0)
            {
                isFind=false;
                break;
            }
        }
        if(isFind==true)
        {
            count= count+1;
        }
    }
    return count;
}
