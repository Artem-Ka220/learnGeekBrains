int n = 5;
int[,] matrix = new int [n,n];
for(int i = 1; i < n; i++){
    //for(int j = i; j < n; j++){
        for(int j = 1; j < n; j++){
          matrix[i,j] = i * j;
          matrix[j,i] = i * j;
    }
    Console.WriteLine();
}

for(int i = 1; i < n; i++){
    for(int j = 1; j < n; j++){
        Console.Write(matrix[i,j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
