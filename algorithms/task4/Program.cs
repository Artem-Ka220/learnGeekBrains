//сортировка пузырьком
int n = 5;

int[] array = new int[n];

for(int i = 0; i < n; i++){
    array[i] = Random.Shared.Next(100);
}
bool Check(int[] arr){

    for(int i = 0; i < arr.Length - 1; i++){
        if(arr[i] > arr[i + 1]){
            return false;
        }
    }
    return true;
}
Console.WriteLine(Check(array));
Console.WriteLine($"[{string.Join(", ", array)}]");
for(int k = 0; k < n - 1; k++){
for(int i = 0; i < n - 1; i++){
    if(array[i] > array[i + 1]){
        int temp = array[i];
        array[i] = array[i + 1];
        array[i + 1] = temp;
    }
}
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(Check(array));