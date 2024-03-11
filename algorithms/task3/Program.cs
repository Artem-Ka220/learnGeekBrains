// Сортировка Выбором
using System;
class Solution{
    static void Main(){
        Console.WriteLine("Укажите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(size);
        int[] myNewArray = CreateArray(size);

        Console.WriteLine($"Starting array - [{string.Join(", ",myNewArray)}]");
        Console.WriteLine($"Final array - [{string.Join(", ", SortArray(myNewArray))}]");
    }
    static int[] CreateArray(int width){
        int[] anyArray = new int[width];
        for(int i = 0; i < anyArray.Length; i++){
            anyArray[i] = new Random().Next(-17,17);
        }
        return anyArray;
    }

    static int[] SortArray(int[] anyArray){
        
        for(int i = 0; i < anyArray.Length; i++){
            int min = i;
            for(int j = i; j < anyArray.Length; j++){
                if(anyArray[j] < anyArray[min]){
                        min = j;
                }
            }
                if(anyArray[min] == anyArray[i]){
                    continue;
                }
                int temp = anyArray[i];
                anyArray[i] = anyArray[min];
                anyArray[min] = temp;
        }
        return anyArray;
    }
}

