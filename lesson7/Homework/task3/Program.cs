using System;
class Solution {
  static void Main() {
    int[] myArray = CreateArray(7);
    for(int i = 0; i < myArray.Length; i++){
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
    int any = myArray.Length - 1;
    PrintArray(myArray, any);
  }
static  int[] CreateArray(int sizeArray)
{
 Random rnd = new Random();
 int[] array = new int[sizeArray];
    for(int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(21);
    }
    return array;
}
static void PrintArray(int[] anyArray, int count){
    
    if(count < 0){
        return;
    }
    if(count == anyArray.Length - 1){
    Console.Write("[ " + anyArray[count] + ", ");
    }else if(count > 0){
        Console.Write(anyArray[count] + ", ");
    }else{
        Console.Write(anyArray[count] + " ]");
    }
    count--;
    PrintArray(anyArray,count);
}
}
