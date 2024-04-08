// быстрая сортировка O(n * log2(n))
// напишите программу, которая сложит числа а и в без прямого сложения
// Console.Clear();
// Console.WriteLine("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n} + {m} = {sumNumbers(n,m)}");

// int sumNumbers(int a,int b){
//     if(b == 0)
//     return a;
//     return sumNumbers(a + 1, b - 1);
// }

//Найти n-ое число Фибоначи
// //f(n) = f(n - 1) + f(n - 2)

// Console.Clear();
// Console.WriteLine("Введите номер: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(fib(n));
// int fib(int n){
//     if(n == 0 || n == 1){
//         return n;
//     }
//     return fib(n - 1) + fib(n - 2);
// }

// int a0 = -0, a1 = 1, aNext;
// for(int i = 0; i < n; i++){
//     Console.Write($"{a1}");
//     aNext = a0 + a1;
//     a0 = a1;
//     a1 = aNext;
// }
Console.Clear();
int[] array = {7, 8 , 3, 1, 1, 0, 8, 9, 3, 4, 2};
Console.WriteLine($"Не отсортированный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array))}]");

int[] quickSort(int[] array){
    if (array.Length < 2){
        return array;
    }
    else{
        int pivot = array[0];
        int count = 0;
        foreach(int element in array){
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < pivot){
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach(int element in array){
            if (element > pivot)
                count++;
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > pivot){
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach(int element in array){
            if (element == pivot)
                count++;
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++){
            pivotArray[i] = pivot;
        }
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}
int[] Concat(int[] a, int[] b, int[] c){
    int[] result = new int[a.Length + b.Length + c.Length];
    for (int i = 0; i < a.Length; i++){
        result[i] = a[i];
    }
    for (int i = a.Length; i < a.Length + b.Length; i++){
        result[i] = b[i - a.Length];
    }    
    for (int i = a.Length + b.Length; i < result.Length; i++){
        result[i] = c[i - (a.Length + b.Length)];
    }
    return result;
}